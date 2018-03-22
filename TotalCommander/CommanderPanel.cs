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
        public event Func<object, EventArgs, DriveInfo[]> LoadDrives;
        public CommanderPanel()
        {
            InitializeComponent();
        }

        public string CurrentPath
        {
            get { return textBoxPath.Text; }
            private set
            {
                if (value != null)
                    textBoxPath.Text = value;
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
                    comboBoxDriveSelect.Items.Add(dr.Name+"    "+dr.VolumeLabel);
                }
            }
        }
        private DriveInfo[] driveList;



        private void comboBoxDriveSelect_DropDown(object sender, EventArgs e)
        {
            if (LoadDrives != null)
               DriveList= LoadDrives(sender,e);
        }

        private void comboBoxDriveSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPath = DriveList[comboBoxDriveSelect.SelectedIndex].Name;
        }
    }
}
