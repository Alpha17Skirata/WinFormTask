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
    public partial class Authentication : Form , IAunthenticationView
    {
        private static Authentication instance;
        public static Authentication GetInstance()
        {
            if(instance==null || instance.IsDisposed)
            {
                instance = new Authentication();
            }
            else
            {
                instance.BringToFront();
            }
            return instance;
        }
        public Authentication()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            userButton.Click += delegate { OpenUserEvent?.Invoke(this, EventArgs.Empty); };
            adminButton.Click += delegate { OpenCheckPasswordEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler OpenUserEvent;
        public event EventHandler OpenCheckPasswordEvent;

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
