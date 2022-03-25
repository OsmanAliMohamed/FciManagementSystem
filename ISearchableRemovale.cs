using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FciManagementSystem
{
    public interface ISearchableRemovale<T>
    {
        List<T> Search(string name);
        void Delete(string name, string department);
    }
}
