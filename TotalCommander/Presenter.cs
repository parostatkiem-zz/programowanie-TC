using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TotalCommander
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
           
            view.GetAllDrives += View_GetAllDrives;
            view.RefreshFilesEvent += View_RefreshFilesEvent;
            view.ItemSelectedEvent += View_ItemSelectedEvent;
           
        }

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
                output = new string[] {""};
            }
            return output;
        }

        private DriveInfo[] View_GetAllDrives(object arg1, EventArgs arg2)
        {
            return model.GetAvailableDrives();
        }
    }
}
