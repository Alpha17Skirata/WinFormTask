using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Presenters;
using TestTask.Views;

namespace TestTask.Repository
{
    public class MainPresenter
    {
        private IAunthenticationView aunthenticationView;
        private readonly string sqlConnection;

        public MainPresenter(IAunthenticationView aunthenticationView, string sqlConnection)
        {
            this.aunthenticationView = aunthenticationView;
            this.sqlConnection = sqlConnection;
            this.aunthenticationView.OpenAdminEvent += ShowAdminEvent;
            this.aunthenticationView.OpenUserEvent += ShowUserEvent;
        }

        private void ShowUserEvent(object sender, EventArgs e)
        {
            IUserView userView = new UserView();
            new Presenter(sqlConnection, userView);
            aunthenticationView.Hide();
        }

        private void ShowAdminEvent(object sender, EventArgs e)
        {
            IAdminView adminView = new AdminView();
            new Presenter(sqlConnection, adminView);
            aunthenticationView.Hide();
        }
    }
}
