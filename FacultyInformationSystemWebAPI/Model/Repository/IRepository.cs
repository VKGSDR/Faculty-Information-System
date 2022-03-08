using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystemWebAPI.Model.Repository
{
    //Generic Repository
    public interface IRepository<T>
    {
        bool Add(T sObj);
        List<T> Get();
        T Show(int id);
        bool UpDate(int id, T sObj);
        bool Delete(int id);
    }
}
