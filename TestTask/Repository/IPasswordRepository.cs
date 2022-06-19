using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask.Repository
{
    public interface IPasswordRepository
    {
        bool CheckPassword(Password password);
        void ChangePassword(Password password);
    }
}
