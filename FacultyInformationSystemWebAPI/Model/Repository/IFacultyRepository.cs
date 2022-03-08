using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystemWebAPI.Model.Repository
{
    public interface IFacultyRepository
    {
        bool AddFacultyInfo(Faculty fObj);
        List<Faculty> GetFaculties();
        List<Faculty> ShowFacultyByDepartment(int deptid);
        Faculty ShowFacultyInfoByID(int fid);
        bool UpdateFacultyInfo(int fid, Faculty fObj);
        bool DeleteFacultyInfo(int fid);
    }
}
