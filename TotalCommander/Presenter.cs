using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TotalCommander
{
    class Presenter
    {
        IView view;
        Model model;
        Task bgTask;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
           
            view.GetAllDrives += View_GetAllDrives;
            view.RefreshFilesEvent += View_RefreshFilesEvent;
            view.ItemSelectedEvent += View_ItemSelectedEvent;
            view.CopySomething += View_CopySomething;
            view.DeleteSomething += View_DeleteSomething;
            view.CreateNewFolder += View_CreateNewFolder;
          
        }

        #region Events
        private string View_ItemSelectedEvent(string arg1, string arg2)
        {
            return model.ItemSelectedAction(arg1, arg2);
        }

        private string[] View_RefreshFilesEvent(object arg1, EventArgs arg2, string path)
        {
            var output= model.GetDirectoryContents(path);
            if (output == null)
            {
                view.ShowError("Nie udało się wczytać zawartości wskazanego folderu.\nByć może nie masz uprawnień lub folder nie istnieje");
                output = new string[] {"[..]"};
            }
            return output;
        }

        private DriveInfo[] View_GetAllDrives(object arg1, EventArgs arg2)
        {
            return model.GetAvailableDrives();
        }
        private void View_CopySomething(string sourcePath, string sourceItem, string destPath, bool moveInsteadOfCopying = false)
        {
            if(sourceItem==null)
                if (!view.ShowConfirmation("Czy na pewno chcesz skopiować/przenieść aktualnie otwarty katalog\n" + sourcePath)) return;
            view.AsyncOperationBegin();
            bgTask = new Task(() =>
              {
                 
                  if (!model.Copy(sourcePath, sourceItem, destPath, moveInsteadOfCopying))
                      view.ShowError("Nie udało się wykonać operacji.\nCzy na pewno posiadasz prawa do jej wykonania?");
              });
            bgTask.ContinueWith(task => view.AsyncOperationEnd(), TaskScheduler.FromCurrentSynchronizationContext());

            bgTask.Start();
        }
        private void View_DeleteSomething(string sourcePath, string sourceItem)
        {
            if (sourceItem==null ||sourceItem=="")
                { view.ShowError("Żaden obiekt nie jest zaznaczony.\nNie możesz usunąć folderu, w którym się aktualnie znajdujesz, bo to spowodowałoby rozpad wszechświata!"); return; }
            if (!view.ShowConfirmation("Czy na pewno chcesz usunąć\n" + sourcePath + sourceItem)) return;
            view.AsyncOperationBegin();
            bgTask = new Task(() => {
                if (!model.Delete(sourcePath, sourceItem)) view.ShowError("Nie udało się wykonać operacji.\nCzy na pewno posiadasz prawa do jej wykonania?");
            });
            bgTask.ContinueWith(task => view.AsyncOperationEnd(), TaskScheduler.FromCurrentSynchronizationContext());

            bgTask.Start();
            
        }
        private void View_CreateNewFolder(string path)
        {
            if (!model.CreateFolder(path)) view.ShowError("Nie udało się wykonać operacji.\nCzy na pewno posiadasz prawa do jej wykonania?");

        }


        #endregion

    }
}
