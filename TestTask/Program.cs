using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Presenters;
using TestTask.Repository;
using TestTask.Views;
using System.Configuration;


namespace TestTask
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connection = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            ITaskRepository adminRepository = new TaskRepository(connection);
            IAunthenticationView aunthenticationView = new Authentication();
            new MainPresenter(aunthenticationView, connection);
            Application.Run((Form)aunthenticationView);
        }
    }
}
