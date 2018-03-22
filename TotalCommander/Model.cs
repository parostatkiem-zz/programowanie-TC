using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TotalCommander
{
    class Model
    {
        public DriveInfo[] GetAvailableDrives()
        {
            var drives = new List<DriveInfo>();
            //przeniesc chyba do modelu
            foreach (DriveInfo dr in DriveInfo.GetDrives())
            {
                if (dr.IsReady)
                    drives.Add(dr);
            }
            return drives.ToArray();
        }
    }
}
