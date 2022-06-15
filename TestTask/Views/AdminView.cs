using System;
using System.Windows.Forms;

namespace TestTask.Views
{
    public partial class AdminView : Form, IAdminView
    {
        private TextBox[] textBoxes;
        private string message;

        public AdminView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            saveBtn.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(message);
            };
            changeAdminRole.Click += delegate { BackEvent?.Invoke(this, EventArgs.Empty); };
            cancelBtn.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string HumanName { get => textHumanName.Text; set => textHumanName.Text=value; }
        public string Surname { get => textSurname.Text; set => textSurname.Text=value; }
        public string MiddleName { get => textMiddleName.Text; set => textMiddleName.Text=value; }
        public string Date { get => textBirthdayDate.Text; set => textBirthdayDate.Text=value; }
        public string Number { get => textNumber.Text; set => textNumber.Text=value; }
        public string Address { get => textAddress.Text; set => textAddress.Text=value; }
        public string HouseNumber { get => textHouseNumber.Text; set => textHouseNumber.Text = value; }
        public string Flat { get => textFlat.Text; set => textFlat.Text = value; }
        public string Message { get => message; set => message=value; }

        public event EventHandler CancelEvent;
        public event EventHandler SaveEvent;
        public event EventHandler BackEvent;

        private void AdminView_Load(object sender, EventArgs e)
        {
            textBoxes = new TextBox[] { textHumanName, textSurname, textMiddleName, textBirthdayDate, textNumber, textAddress, textHouseNumber, textFlat };
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (sender.Equals(textBoxes[i]))
                    {
                        textBoxes[i - 1 < 0 ? 0 : i - 1].Focus();
                        break;
                    }
                }
            }
            else if (e.KeyData == Keys.Down)
            {
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (sender.Equals(textBoxes[i]))
                    {
                        textBoxes[i + 1 > textBoxes.Length - 1  ? textBoxes.Length - 1 : i + 1].Focus();
                        break;
                    }
                }
            }
        }           

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void textHouseNumberFlat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!((character >= 'А' && character <= 'я') || (character >= '0' && character <= '9') || character == 'ё' || character == 'Ё') && character != 8 && character !=32)
            {
                e.Handled = true;
            }
        }

        private void textBirthdayDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number !=46)
            {
                e.Handled = true;
            }
        }

        private void textNameSurnameMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (!((character >= 'А' && character <= 'я') || character == 'ё' || character == 'Ё') && character != 8)
            {
                e.Handled = true;
            }
        }
    }
}
