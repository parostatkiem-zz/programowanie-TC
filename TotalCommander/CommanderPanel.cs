using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TotalCommander
{
    public partial class CommanderPanel : UserControl
    {
        #region Public
        #region Events
        public event Func<object, EventArgs, DriveInfo[]> LoadDrives;
        public event Func<object, EventArgs, string[]> RefreshFilesEvent;
        public event Func<object, EventArgs,string> ItemSelectedEvent;
        public event Action<object,bool> CopyTrigger;
        #endregion
        public CommanderPanel()
        {
            InitializeComponent();
        }

        public string CurrentPath
        {
            get { return textBoxPath.Text; }
            private set
            {
                if (value != null && value!="")
                {
                    if (value[value.Length - 1] != '\\') value += '\\';
                    textBoxPath.Text = value;
                    RefreshFiles(this,null);
                }           
            }
        }
        public string CurrentSelectedItem
        {
            get
            { 
                string selectedItem = listBoxOutput.SelectedItem as string;
                if (selectedItem == null || selectedItem == "") return null; //cos poszło nie tak, nic nie jest zaznaczone
                return selectedItem;
            }
        }

        public DriveInfo[] DriveList
        {
            get { return driveList; }
            set
            {
                if (value == null) return;
                    driveList = value;
                //wypelnianie listy
                comboBoxDriveSelect.Items.Clear();
                foreach (DriveInfo dr in driveList)
                {
                    comboBoxDriveSelect.Items.Add(dr.Name+"  "+dr.VolumeLabel);
                }
              
            }
        }

        public void RefreshOutput()
        {
            CurrentPath = CurrentPath;//odswieza widok
        }

        #endregion
        #region Private
        #region Fields
        private DriveInfo[] driveList;

        #endregion

        private void comboBoxDriveSelect_DropDown(object sender, EventArgs e)
        {
            if (LoadDrives != null)
               DriveList= LoadDrives(sender,e);
           
        }

        private void comboBoxDriveSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPath = DriveList[comboBoxDriveSelect.SelectedIndex].Name;
        }

        private void RefreshFiles(object sender, EventArgs e)
        {
            this.listBoxOutput.Items.Clear();
            listBoxOutput.Items.AddRange(RefreshFilesEvent(sender,e));
            
        }

        private void textBoxPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CurrentPath = textBoxPath.Text;
        }

        private void listBoxOutput_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentSelectedItem != null)
                CurrentPath = ItemSelectedEvent(this, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CopyTrigger(this,false);
           
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            CopyTrigger(this, true);
        }

        private void listBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//enter
                listBoxOutput_DoubleClick(sender, e);


        }
    }
}
