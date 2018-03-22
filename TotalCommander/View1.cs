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
            commanderPanel1.LoadDrives += CommanderPanel1_LoadDrives; ;
        }

        public event Func<object, EventArgs, DriveInfo[]> GetAllDrives;
        private DriveInfo[] CommanderPanel1_LoadDrives(object arg1, EventArgs arg2)
        {
           // var cp = arg1 as CommanderPanel;
            //if (cp == null) return;
            return GetAllDrives(arg1,arg2);
        }

      
       



    }
}
