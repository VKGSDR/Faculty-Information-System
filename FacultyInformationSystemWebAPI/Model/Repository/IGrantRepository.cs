using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystemWebAPI.Model.Repository
{
    public interface IGrantRepository
    {
        bool AddGrantInfo(Grant gObj);
        List<Grant> GetGrants();
        Grant ShowGrantInfoByID(int gid);
        bool UpdateGrantInfo(int gid, Grant gObj);
        bool DeleteGrantInfo(int gid);
    }
}
