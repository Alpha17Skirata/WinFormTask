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
    public partial class ChangePasswordView : Form, IPasswordView
    {
        private string message;
        public ChangePasswordView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public string PasswordValue { get => passwordTextBox.Text; set => passwordTextBox.Text = value; }
        public string Message { get => message; set => message = value; }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void AssociateAndRaiseViewEvents()
        {
            savePasswordBtn.Click += delegate
            {
                ChangePasswordEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(message);
            };
            backBtn.Click += delegate
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
