using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Views
{
    
    public interface IAunthenticationView
    {
        event EventHandler OpenUserEvent;
        event EventHandler OpenAdminEvent;

        void Show();
        void Hide();
    }
}
