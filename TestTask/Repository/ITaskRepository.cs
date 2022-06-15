using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace TestTask.Repository
{
    public interface ITaskRepository
    {
        void Add(Human humanModel, Address address);
        IEnumerable<UserFormViewModel> SearchUsingConditions(UserFormViewModel model);
    }
}
