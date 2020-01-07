using Hastahane.Data.EntityFramework.Models;
using Hastahane.FormUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastahane.FormUI
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(/*MainFormOpen()*/new MainForm()) ;
        }
       static Form mainform;
        public static Form MainFormOpen()
        {
            mainform = new MainForm();
            return mainform;
        }
        public static void abc()
        {

        }
        public static void HideMainForm()
        {
            mainform.Hide();
        }
        public static void ShowMainForm()
        {
            mainform.Show();
        }
        public static void ShowMainForm(Staff Staff)
        {
            mainform = new MainForm(Staff);
            mainform.Show();
        }
        public static Form MainPageReturn()
        {
            return mainform;
        }
    }
}
