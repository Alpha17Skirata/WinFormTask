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
        private IPasswordRepository passwordRepository;
        private IPasswordView changePasswordView;
        private IAdminView adminView;
        private IUserView userView;
        private BindingSource bindingSource;
        private IEnumerable<UserFormViewModel> userFormViewModels;

        public Presenter(ITaskRepository repository, IPasswordRepository passwordRepository, IUserView userView, IAdminView adminView)
        {
            this.bindingSource = new BindingSource();
            this.repository = repository;
            this.passwordRepository = passwordRepository;
            this.userView = userView;
            this.userView.SearchEvent += SearchHuman;
            this.userView.BackEvent += BackFromUserPage;
            this.userView.SetHumanListBindingSource(bindingSource);
            this.adminView = adminView;
            this.adminView.SaveEvent += SaveNewHuman;
            this.adminView.BackEvent += BackFromAdminPage;
            this.adminView.CancelEvent += CleanForms;
            this.adminView.ChangePasswordEvent += OpenChangePasswordView;
            changePasswordView = new ChangePasswordView();
            changePasswordView.ChangePasswordEvent += ChangePassword;
            changePasswordView.BackEvent += BackToAdminPage;
        }

        private void OpenChangePasswordView(object sender, EventArgs e)
        {
            adminView.Hide();
            changePasswordView.Show();
        }

        private void BackToAdminPage(object sender, EventArgs e)
        {
            changePasswordView.Hide();
            adminView.Show();
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            var password = new Password();
            password.Id = 1;
            password.PasswordValue = changePasswordView.PasswordValue.Trim(' ');
            try
            {
                passwordRepository.ChangePassword(password);
                changePasswordView.Hide();
                changePasswordView.Message = "Пароль изменен";
                changePasswordView.PasswordValue = "";
                adminView.Show();
            }
            catch (Exception ex)
            {
                changePasswordView.Message = ex.Message;
            }
        }

        private void CleanForms(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void BackFromUserPage(object sender, EventArgs e)
        {
            userView.Hide();
            IAunthenticationView aunthenticationView = Authentication.GetInstance();
            aunthenticationView.Show();
        }

        private void BackFromAdminPage(object sender, EventArgs e)
        {
            adminView.Hide();
            IAunthenticationView aunthenticationView = Authentication.GetInstance();
            aunthenticationView.Show();
        }

        private void SearchHuman(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userView.HumanName) &&
                string.IsNullOrEmpty(userView.Surname) &&
                string.IsNullOrEmpty(userView.MiddleName) &&
                string.IsNullOrEmpty(userView.Date) &&
                string.IsNullOrEmpty(userView.Number) &&
                string.IsNullOrWhiteSpace(userView.Address) &&
                string.IsNullOrEmpty(userView.HouseNumber) &&
                string.IsNullOrEmpty(userView.Flat))
            {
                userView.IsSuccessful = true;
            }
            else
            {
                var userFormViewModel = new UserFormViewModel();
                userFormViewModel.Name = ToUpperFirstLetter(userView.HumanName);
                userFormViewModel.Surname = ToUpperFirstLetter(userView.Surname);
                userFormViewModel.MiddleName = ToUpperFirstLetter(userView.MiddleName);
                if (string.IsNullOrEmpty(userView.Date))
                {
                    userFormViewModel.Birthday = DateTime.TryParse(userView.Date, out _) ? Convert.ToDateTime(userView.Date) : null;
                }
                else
                {
                    try
                    {
                        userFormViewModel.Birthday = DateTime.Parse(userView.Date);
                    }
                    catch (FormatException ex)
                    {
                        userView.IsSuccessful = false;
                        userView.Message = "Некорректный формат даты";
                        return;
                    }
                }
                userFormViewModel.Number = userView.Number;
                userFormViewModel.AddressName = userView.Address.Trim(' ');
                userFormViewModel.HouseNumber = int.TryParse(userView.HouseNumber, out _) ? Convert.ToInt32(userView.HouseNumber) : null;
                userFormViewModel.Flat = int.TryParse(userView.Flat, out _) ? Convert.ToInt32(userView.Flat) : null;
                userFormViewModels = repository.SearchUsingConditions(userFormViewModel);
                userView.IsSuccessful = true;
                bindingSource.DataSource = userFormViewModels;
            }
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
