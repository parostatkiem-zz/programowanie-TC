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
        #endregion
        public View1()
        {
            InitializeComponent();
            commanderPanelLeft.LoadDrives += CommanderPanel_LoadDrives;
            commanderPanelLeft.RefreshFilesEvent += CommanderPanel_RefreshFilesEvent;
            commanderPanelLeft.ItemSelectedEvent += CommanderPanel_ItemSelectedEvent;
            commanderPanelLeft.CopyTrigger += CommanderPanel_CopyTrigger;

            commanderPanelRight.LoadDrives += CommanderPanel_LoadDrives;
            commanderPanelRight.RefreshFilesEvent += CommanderPanel_RefreshFilesEvent;
            commanderPanelRight.ItemSelectedEvent += CommanderPanel_ItemSelectedEvent;
            commanderPanelRight.CopyTrigger += CommanderPanel_CopyTrigger;

        }

      

        public void ShowError(string message)
        {
            MessageBox.Show(message, "ERROR",MessageBoxButtons.OK,  MessageBoxIcon.Warning);
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

            CopySomething(sourcePanel.CurrentPath, sourcePanel.CurrentSelectedItem, destinationPanel.CurrentPath,moveInsteadOfCopying);
            destinationPanel.RefreshOutput();
            if (moveInsteadOfCopying)
                sourcePanel.RefreshOutput();
        }

        #endregion

    }
}
