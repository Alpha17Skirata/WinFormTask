using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Views
{ 
    public partial class CheckPasswordView : Form, IPasswordView
    {
        private string message;
        private bool isSuccessful;

        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string PasswordValue { get => passwordTextBox.Text; set => passwordTextBox.Text = value; }

        public CheckPasswordView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            checkPasswordBtn.Click += delegate
            {
                CheckPasswordEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful == false)
                {
                    MessageBox.Show(message);
                }
            };
            changeRole.Click += delegate
            {
                BackEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler CheckPasswordEvent;
        public event EventHandler ChangePasswordEvent;
        public event EventHandler BackEvent;

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}

