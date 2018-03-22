using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TotalCommander
{
    interface IView
    {
      //  DriveInfo[] DriveList { get; set; }

        event Func<object, EventArgs, DriveInfo[]> GetAllDrives;
        event Func<object, EventArgs, string,string[]> RefreshFilesEvent;
        void ShowError(string message);
    }
}
