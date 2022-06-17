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
        private ITaskRepository repository;
        private IAdminView adminView;
        private IUserView userView;
        private BindingSource bindingSource;
        private IEnumerable<UserFormViewModel> userFormViewModels;

        public Presenter(ITaskRepository repository, IUserView userView, IAdminView adminView)
        {
            this.bindingSource = new BindingSource();
            this.repository = repository;
            this.userView = userView;
            this.userView.SearchEvent += SearchHuman;
            this.userView.BackEvent += BackUserPage;
            this.userView.SetHumanListBindingSource(bindingSource);
            this.adminView = adminView;
            this.adminView.SaveEvent += SaveNewHuman;
            this.adminView.BackEvent += BackAdminPage;
            this.adminView.CancelEvent += CleanForms;
        }

        private void CleanForms(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void BackUserPage(object sender, EventArgs e)
        {
            userView.Hide();
            IAunthenticationView aunthenticationView = Authentication.GetInstance();
            aunthenticationView.Show();
        }

        private void BackAdminPage(object sender, EventArgs e)
        {
            adminView.Hide();
            IAunthenticationView aunthenticationView = Authentication.GetInstance();
            aunthenticationView.Show();
        }

        private void SearchHuman(object sender, EventArgs e)
        {
            var userFormViewModel = new UserFormViewModel();
            userFormViewModel.Name = ToUpperFirstLetter(userView.HumanName);
            userFormViewModel.Surname = ToUpperFirstLetter(userView.Surname);
            userFormViewModel.MiddleName = ToUpperFirstLetter(userView.MiddleName);
            userFormViewModel.Birthday = DateTime.TryParse(userView.Date, out _) ? Convert.ToDateTime(userView.Date) : null;
            userFormViewModel.Number = userView.Number;
            userFormViewModel.AddressName = userView.Address.Trim(' ');
            userFormViewModel.HouseNumber = int.TryParse(userView.HouseNumber, out _) ? Convert.ToInt32(userView.HouseNumber) : null;
            userFormViewModel.Flat = int.TryParse(userView.Flat, out _) ? Convert.ToInt32(userView.Flat) : null;
            userFormViewModels = repository.SearchUsingConditions(userFormViewModel);
            bindingSource.DataSource = userFormViewModels;
        }

        private void SaveNewHuman(object sender, EventArgs e)
        {
            var humanModel = new Human();
            var addressModel = new Address();
            humanModel.Name = ToUpperFirstLetter(adminView.HumanName);
            humanModel.Surname = ToUpperFirstLetter(adminView.Surname);
            humanModel.MiddleName = ToUpperFirstLetter(adminView.MiddleName);
            humanModel.Birthday = DateTime.TryParse(adminView.Date, out _) ? Convert.ToDateTime(adminView.Date) : null;
            humanModel.Number = adminView.Number;
            humanModel.Flat = int.TryParse(adminView.HouseNumber, out _) ? Convert.ToInt32(adminView.HouseNumber) : null; 
            addressModel.AddressName = adminView.Address.Trim(' ');
            addressModel.HouseNumber = int.TryParse(adminView.HouseNumber, out _) ? Convert.ToInt32(adminView.HouseNumber) : null;
            try
            {
                ValidateData validation = new ValidateData();
                validation.Validate(humanModel);
                validation.Validate(addressModel);
                repository.Add(humanModel, addressModel);
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

        private string ToUpperFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return source;
            }
            source = source.ToLower();
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}
