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
    public partial class View1 : Form
    {
        public View1()
        {
            InitializeComponent();
            commanderPanel1.LoadDrives += CommanderPanel_LoadDrivers;
        }

        private void CommanderPanel_LoadDrivers(CommanderPanel obj)
        {
          var drives = new List<string>();
            //przeniesc chyba do modelu
            foreach(DriveInfo dr in DriveInfo.GetDrives() )
            {
                if (dr.IsReady)
                    drives.Add(dr.Name+"   "+dr.VolumeLabel);
            }
            obj.DriveList = drives.ToArray();
        }
    }
}
