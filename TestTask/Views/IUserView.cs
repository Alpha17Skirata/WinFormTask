using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Views
{
    public interface IUserView
    {
        public string HumanName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Date { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string HouseNumber { get; set; }
        public string Flat { get; set; }


        event EventHandler SearchEvent;
        event EventHandler BackEvent;

        void SetHumanListBindingSource(BindingSource humanList);
        void Show();
        void Hide();
    }
}
