using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.Views;

namespace TestTask
{
    public partial class UserView : Form, IUserView
    {
        private TextBox[] textBoxes;
        public UserView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            searchButton.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            changeUserRole.Click += delegate { BackEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string HumanName { get => textHumanName.Text; set => textHumanName.Text = value; }
        public string Surname { get => textSurname.Text; set => textSurname.Text = value; }
        public string MiddleName { get => textMiddleName.Text; set => textMiddleName.Text = value; }
        public string Date { get => textBirthdayDate.Text; set => textBirthdayDate.Text = value; }
        public string Number { get => textNumber.Text; set => textNumber.Text = value; }
        public string Address { get => textAddress.Text; set => textAddress.Text = value; }
        public string HouseNumber { get => textHouseNumber.Text; set => textHouseNumber.Text = value; }
        public string Flat { get => textFlat.Text; set => textFlat.Text = value; }

        public event EventHandler SearchEvent;
        public event EventHandler BackEvent;
        

        public void SetHumanListBindingSource(BindingSource humanList)
        {
            dataGridView1.DataSource = humanList;
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
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
                        textBoxes[i + 1 > textBoxes.Length - 1 ? textBoxes.Length - 1 : i + 1].Focus();
                        break;
                    }
                }
            }
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            textBoxes = new TextBox[] {textHumanName, textSurname, textMiddleName, textBirthdayDate, textNumber, textAddress, textHouseNumber, textFlat  };
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
            if (!((character >= 'А' && character <= 'я') || (character >= '0' && character <= '9') || character == 'ё' || character == 'Ё') && character != 8 && character != 32)
            {
                e.Handled = true;
            }
        }

        private void textBirthdayDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46)
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
            if (textNumber.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void textBirthdayDate_TextChanged(object sender, EventArgs e)
        {
            if (textBirthdayDate.Text.Length == 2 || textBirthdayDate.Text.Length == 5)
            {
                textBirthdayDate.AppendText(".");
            }
            if (textBirthdayDate.Text.Length >= 11)
            {
                textBirthdayDate.Clear();
            }
        }

        private void textNumber_TextChanged_1(object sender, EventArgs e)
        {
            if (textNumber.Text.Length == 1 || textNumber.Text.Length == 4)
            {
                textNumber.AppendText("-");
            }
            if (textNumber.Text.Length >= 8)
            {
                textNumber.Clear();
            }
        }
    }
}
