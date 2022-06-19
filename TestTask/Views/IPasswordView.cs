using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Views
{
    public interface IPasswordView
    {
        public string PasswordValue { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        event EventHandler CheckPasswordEvent;
        event EventHandler ChangePasswordEvent;
        event EventHandler BackEvent;
        void Show();
        void Hide();
    }
}
