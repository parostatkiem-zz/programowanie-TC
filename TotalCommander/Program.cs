using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TotalCommander
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            View1 view = new View1();
            Presenter p = new Presenter(model, view);
            Application.Run(view);
        }
    }
}
