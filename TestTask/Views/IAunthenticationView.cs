using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Views
{
    public interface IAunthenticationView
    {
        public event EventHandler OpenUserEvent;
        public event EventHandler OpenCheckPasswordEvent;

        void Show();
        void Hide();
    }
}
