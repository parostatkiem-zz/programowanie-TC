using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TotalCommander
{
    public partial class CommanderPanel : UserControl
    {
        public event Action<CommanderPanel> LoadDrives;
        public CommanderPanel()
        {
            InitializeComponent();
        }

        public string CurrentPath
        {
            get { return textBoxPath.Text; }
        }

        public string[] DriveList
        {
            set
            {
                comboBoxDriveSelect.Items.Clear();
                if(value!=null)
                comboBoxDriveSelect.Items.AddRange(value);
            }
        }

        

        private void comboBoxDriveSelect_DropDown(object sender, EventArgs e)
        {
            if (LoadDrives != null)
                LoadDrives(this);
        }
    }
}
