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
        public View1()
        {
            InitializeComponent();
            commanderPanel1.LoadDrives += CommanderPanel_LoadDrives;
            commanderPanel1.RefreshFilesEvent += CommanderPanel_RefreshFilesEvent;

        }


        public event Func<object, EventArgs, DriveInfo[]> GetAllDrives;
        public event Func<object, EventArgs,string, string[]> RefreshFilesEvent;
        
        public void ShowError(string message)
        {
            MessageBox.Show(message, "ERROR");
            //TODO: można zmienić na coś bardziej ambitnego
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

      
       



    }
}
