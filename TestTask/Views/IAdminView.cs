using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Views
{
    public interface IAdminView
    {
        string HumanName { get; set; }
        string Surname { get; set; }
        string MiddleName { get; set; }
        string Date { get; set; }
        string Number { get; set; }
        string Address { get; set; }
        string HouseNumber { get; set; }
        string Flat { get; set; }
        string Message { get; set; }
        

        event EventHandler CancelEvent;
        event EventHandler SaveEvent;
        event EventHandler BackEvent;
        event EventHandler ChangePasswordEvent;

        void Show();
        void Hide();
    }
}
