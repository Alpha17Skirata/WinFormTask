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
        private IAdminView adminView;
        private IUserView userView;

        public MainPresenter(IAunthenticationView aunthenticationView, string sqlConnection)
        {
            this.aunthenticationView = aunthenticationView;
            this.aunthenticationView.OpenAdminEvent += ShowAdminEvent;
            this.aunthenticationView.OpenUserEvent += ShowUserEvent;
            this.adminView = new AdminView();
            this.userView = new UserView();
            ITaskRepository repository = new TaskRepository(sqlConnection);
            new Presenter(repository, userView, adminView);
    }

        private void ShowUserEvent(object sender, EventArgs e)
        {
            aunthenticationView.Hide();
            userView.Show();
        }

        private void ShowAdminEvent(object sender, EventArgs e)
        {
            aunthenticationView.Hide();
            adminView.Show();
        }
    }
}
