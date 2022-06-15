using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Views;
using TestTask.Repository;
using System.Windows.Forms;
using TestTask.Model;
using TestTask.Presenters.ValidateTools;

namespace TestTask.Presenters
{
    public class Presenter
    {
        private ITaskRepository phoneBook;
        private IAdminView adminView;
        private IUserView userView;
        private BindingSource bindingSource;
        private IEnumerable<UserFormViewModel> userFormViewModels;
        private string connection;

        public Presenter(string connection, IUserView userView)
        {
            this.bindingSource = new BindingSource();
            this.phoneBook = new TaskRepository(connection);
            this.connection = connection;
            this.userView = userView;
            this.userView.SearchEvent += SearchHuman;
            this.userView.BackEvent += BackUserPage;
            this.userView.SetHumanListBindingSource(bindingSource);
            this.userView.Show();
        }

       

        public Presenter(string connection, IAdminView adminView)
        {
            this.bindingSource = new BindingSource();
            this.phoneBook = new TaskRepository(connection);
            this.connection = connection;
            this.adminView = adminView;
            this.adminView.SaveEvent += SaveNewHuman;
            this.adminView.BackEvent += BackAdminPage;
            this.adminView.CancelEvent += CleanForms;
            this.adminView.Show();
        }

        private void CleanForms(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void BackUserPage(object sender, EventArgs e)
        {
            userView.Hide();
            IAunthenticationView aunthenticationView = new Authentication();
            new MainPresenter(aunthenticationView, connection);
            aunthenticationView.Show();
        }

        private void BackAdminPage(object sender, EventArgs e)
        {
            adminView.Hide();
            IAunthenticationView aunthenticationView = new Authentication();
            new MainPresenter(aunthenticationView, connection);
            aunthenticationView.Show();
        }

        private void SearchHuman(object sender, EventArgs e)
        {
            var userFormViewModel = new UserFormViewModel();
            userFormViewModel.Name = userView.HumanName;
            userFormViewModel.Surname = userView.Surname;
            userFormViewModel.MiddleName = userView.MiddleName;
            userFormViewModel.Birthday = DateTime.TryParse(userView.Date, out _) ? Convert.ToDateTime(userView.Date) : null;
            userFormViewModel.Number = userView.Number;
            userFormViewModel.AddressName = userView.Address.Trim(' ');
            userFormViewModel.HouseNumber = int.TryParse(userView.HouseNumber, out _) ? Convert.ToInt32(userView.HouseNumber) : null;
            userFormViewModel.Flat = int.TryParse(userView.Flat, out _) ? Convert.ToInt32(userView.Flat) : null;
            userFormViewModels = phoneBook.SearchUsingConditions(userFormViewModel);
            bindingSource.DataSource = userFormViewModels;
        }

        private void SaveNewHuman(object sender, EventArgs e)
        {
            var humanModel = new Human();
            var addressModel = new Address();
            humanModel.Name = adminView.HumanName;
            humanModel.Surname = adminView.Surname;
            humanModel.MiddleName = adminView.MiddleName;
            humanModel.Birthday = DateTime.TryParse(adminView.Date, out _) ? Convert.ToDateTime(adminView.Date) : null;
            humanModel.Number = adminView.Number;
            humanModel.HouseNumber = int.TryParse(adminView.HouseNumber, out _) ? Convert.ToInt32(adminView.HouseNumber) : null; 
            humanModel.Flat = int.TryParse(adminView.HouseNumber, out _) ? Convert.ToInt32(adminView.HouseNumber) : null; 
            addressModel.AddressName = adminView.Address.Trim(' ');
            try
            {
                ValidateData validation = new ValidateData();
                validation.Validate(humanModel);
                validation.Validate(addressModel);
                phoneBook.Add(humanModel, addressModel);
                adminView.Message = "Запись добавлена";
                CleanViewFields();
            }
            catch (Exception ex)
            {
                adminView.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            adminView.HumanName = "";
            adminView.Surname = "";
            adminView.MiddleName = "";
            adminView.Date = "";
            adminView.Number = "";
            adminView.Address = "";
            adminView.HouseNumber = "";
            adminView.Flat = "";
        }
    }
}
