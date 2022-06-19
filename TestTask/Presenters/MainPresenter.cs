using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;
using TestTask.Presenters;
using TestTask.Views;

namespace TestTask.Repository
{
    public class MainPresenter
    {
        private IAunthenticationView aunthenticationView;
        private IAdminView adminView;
        private IUserView userView;
        private IPasswordRepository passwordRepository;
        private IPasswordView checkPasswordView;

        public MainPresenter(IAunthenticationView aunthenticationView, string sqlConnection)
        {
            this.aunthenticationView = aunthenticationView;
            checkPasswordView = new CheckPasswordView();
            checkPasswordView.CheckPasswordEvent += CheckPasswordEvent;
            checkPasswordView.BackEvent += BackEvent;
            this.aunthenticationView.OpenCheckPasswordEvent += ShowCheckPasswordEvent;
            this.aunthenticationView.OpenUserEvent += ShowUserEvent;
            this.adminView = new AdminView();
            this.userView = new UserView();
            ITaskRepository repository = new TaskRepository(sqlConnection);
            passwordRepository = new PasswordRepository(sqlConnection);
            new Presenter(repository, passwordRepository, userView, adminView);
        }

        private void ShowCheckPasswordEvent(object sender, EventArgs e)
        {
            aunthenticationView.Hide();
            checkPasswordView.Show();
        }

        private void BackEvent(object sender, EventArgs e)
        {
            checkPasswordView.Hide();
            aunthenticationView.Show();
        }

        private void CheckPasswordEvent(object sender, EventArgs e)
        {
            var password = new Password();
            password.PasswordValue = checkPasswordView.PasswordValue.Trim(' ');
            try
            {
                bool check = passwordRepository.CheckPassword(password);
                if (check) 
                {
                   checkPasswordView.Hide();
                   checkPasswordView.IsSuccessful = true;
                   checkPasswordView.PasswordValue = "";
                   adminView.Show();
                }
                else
                {
                    checkPasswordView.IsSuccessful = false;
                    checkPasswordView.Message = "Неверный пароль";
                }
            }
            catch(Exception ex)
            {
                checkPasswordView.IsSuccessful = false;
                checkPasswordView.Message = ex.Message;
            }
        }

        private void ShowUserEvent(object sender, EventArgs e)
        {
            aunthenticationView.Hide();
            userView.Show();
        }
    }
}
