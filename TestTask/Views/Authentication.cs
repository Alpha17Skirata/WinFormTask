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
        
        public Authentication()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            userButton.Click += delegate { OpenUserEvent?.Invoke(this, EventArgs.Empty); };
            adminButton.Click += delegate { OpenAdminEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler OpenUserEvent;
        public event EventHandler OpenAdminEvent;

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }
    }
}
