using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TotalCommander
{
    public partial class View1 : Form,IView
    {
        #region Public
        #region Events
        public event Func<object, EventArgs, DriveInfo[]> GetAllDrives;
        public event Func<object, EventArgs, string, string[]> RefreshFilesEvent;
        public event Func<string, string, string> ItemSelectedEvent;
        public event Action<string,string,string,bool> CopySomething;
        public event Action<string, string> DeleteSomething;
        public event Action<string> CreateNewFolder;
        
        #endregion
        public View1()
        {
            InitializeComponent();
            commanderPanelLeft.LoadDrives += CommanderPanel_LoadDrives;
            commanderPanelLeft.RefreshFilesEvent += CommanderPanel_RefreshFilesEvent;
            commanderPanelLeft.ItemSelectedEvent += CommanderPanel_ItemSelectedEvent;
            commanderPanelLeft.CopyTrigger += CommanderPanel_CopyTrigger;
            commanderPanelLeft.DeleteTrigger += CommanderPanel_DeleteTrigger;
            commanderPanelLeft.NewFolderTrigger += CommanderPanel_NewFolderTrigger;

            commanderPanelRight.LoadDrives += CommanderPanel_LoadDrives;
            commanderPanelRight.RefreshFilesEvent += CommanderPanel_RefreshFilesEvent;
            commanderPanelRight.ItemSelectedEvent += CommanderPanel_ItemSelectedEvent;
            commanderPanelRight.CopyTrigger += CommanderPanel_CopyTrigger;
            commanderPanelRight.DeleteTrigger+= CommanderPanel_DeleteTrigger;
            commanderPanelRight.NewFolderTrigger += CommanderPanel_NewFolderTrigger;

        }


        public void ShowError(string message)
        {
            MessageBox.Show(message, "ERROR",MessageBoxButtons.OK,  MessageBoxIcon.Warning);
            //TODO: można zmienić na coś bardziej ambitnego
        }

        public bool ShowConfirmation(string message)
        {
            if (MessageBox.Show(message, "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                return true;
            return false;
            //TODO: można zmienić na coś bardziej ambitnego
        }

        #endregion

        #region Private
        private string CommanderPanel_ItemSelectedEvent(object arg1, EventArgs arg2)
        {
            CommanderPanel currentPanel = arg1 as CommanderPanel;
            if (currentPanel == null) ShowError("No panel provided to CommanderPanelLeft_ItemSelectedEvent");
            return ItemSelectedEvent(currentPanel.CurrentPath,currentPanel.CurrentSelectedItem);
        }

        private string[] CommanderPanel_RefreshFilesEvent(object arg1, EventArgs arg2)
        {
            var theCommanderPanel = arg1 as CommanderPanel;
            if (theCommanderPanel != null)
                return RefreshFilesEvent(arg1, arg2, theCommanderPanel.CurrentPath);
            else
                throw new Exception("Wrong object (arg1) provided to method CommandPanel_RefreshFilesEvent");
        }

       
        private DriveInfo[] CommanderPanel_LoadDrives(object arg1, EventArgs arg2)
        {
            return GetAllDrives(arg1,arg2);
        }

        private void CommanderPanel_CopyTrigger(object obj, bool moveInsteadOfCopying = false)
        {
            CommanderPanel sourcePanel = obj as CommanderPanel;
            if (sourcePanel == null) return;
            CommanderPanel destinationPanel=null;
            if (commanderPanelLeft == sourcePanel)
                destinationPanel= commanderPanelRight;
            else
                destinationPanel=commanderPanelLeft ;

            if(sourcePanel.CurrentPath=="" || destinationPanel.CurrentPath=="")
            {
                ShowError("Aby wykonać operację, ścieżki w obu panelach muszą być poprawne.");
                return;
            }
            CopySomething(sourcePanel.CurrentPath, sourcePanel.CurrentSelectedItem, destinationPanel.CurrentPath,moveInsteadOfCopying);
            //RefreshBothPanels();
        }

        private void CommanderPanel_DeleteTrigger(object obj)
        {
            CommanderPanel sourcePanel = obj as CommanderPanel;
            if (sourcePanel == null) return;
            DeleteSomething(sourcePanel.CurrentPath, sourcePanel.CurrentSelectedItem);
           // RefreshBothPanels();
        }
        private void CommanderPanel_NewFolderTrigger(object obj, string folderName)
        {
            CommanderPanel sourcePanel = obj as CommanderPanel;
            if (sourcePanel == null) return;
            if(sourcePanel.CurrentPath=="")
            {
                ShowError("Nie ustawiono żadnej ścieżki!");
                return;
            }
            CreateNewFolder(Path.Combine(sourcePanel.CurrentPath, folderName));
            RefreshBothPanels();
        }
        private void RefreshBothPanels()
        {
            commanderPanelLeft.RefreshOutput();
            commanderPanelRight.RefreshOutput();
        }

        public void AsyncOperationBegin()
        {
            progressBarIsWorking.Visible = true;
        }

        public void AsyncOperationEnd()
        {
            progressBarIsWorking.Visible = false;
            RefreshBothPanels();
        }
        #endregion

    }
}
