using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TotalCommander
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            //view.ViewEvent += View_ViewEvent;
            view.GetAllDrives += View_GetAllDrives;
        }

        private DriveInfo[] View_GetAllDrives(object arg1, EventArgs arg2)
        {
            return model.GetAvailableDrives();
        }
    }
}
