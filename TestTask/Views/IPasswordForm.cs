using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Views
{
    public interface IPasswordForm
    {
        public string Value { get; set; }

        event EventHandler ChangePassword;
        event EventHandler CheckPassword;

        void Close();
    }
}
