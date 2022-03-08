using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystemWebAPI.Model.Repository
{
    public class FacultyRepo : IFacultyRepository
    {

        FIS_DBContext _db = new FIS_DBContext();

        public FacultyRepo()
        {

        }
        public FacultyRepo(FIS_DBContext db)
        {
            _db = db;
        }

        public static List<Faculty> facultyList = new List<Faculty>()
        {
            
        };
        public bool AddFacultyInfo(Faculty fObj)
        {
            int originalRecord = _db.Faculties.Count();
            int newRecord = 0;

            if (fObj != null)
            {
                _db.Faculties.Add(fObj);
                _db.SaveChanges();
                newRecord = _db.Faculties.Count();
            }
            else
            {
                throw new Exception("Faculty Record is not Added");
            }
            if(newRecord > originalRecord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteFacultyInfo(int fid)
        {
            int originalRecord = _db.Faculties.Count();
            int newRecord = 0;

            if (fid > 0)
            {
                Faculty tempFac = _db.Faculties.Find(fid);
                if(tempFac != null)
                {
                    _db.Faculties.Remove(tempFac);
                    _db.SaveChanges();
                    newRecord = _db.Faculties.Count();
                }
                else
                {
                    throw new Exception("Faculty Record doesn't exist");
                }
            }
            else
            {
                throw new Exception("Enter Valid Faculty ID");
            }
            if (newRecord < originalRecord)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Faculty> GetFaculties()
        {
            return _db.Faculties.ToList<Faculty>();
        
        }

        public List<Faculty> ShowFacultyByDepartment(int deptid)
        {
            List<Faculty> facList = facultyList.FindAll(sObj => sObj.DeptId == deptid);
            if(facList == null)
            {
                throw new Exception("Record Not Found");
            }
            //return facultyList.Find(s => s.DeptId == deptid).ToList();
            return facList;
            //throw new NotImplementedException();
        }

        public Faculty ShowFacultyByUsername(string username)
        {
            Faculty fac = facultyList.Find(sObj => sObj.UserName == username);
            if (fac == null)
            {
                throw new Exception("Record Not Found");
            }
            //return facultyList.Find(s => s.DeptId == deptid).ToList();
            return fac;
            //throw new NotImplementedException();
        }

        public Faculty ShowFacultyInfoByID(int fid)
        {
            Faculty tempFaculty = _db.Faculties.FirstOrDefault(s => s.FacultyId == fid);
            return tempFaculty;
           
        }

        //public bool UpdateFacultyInfo(int fid, Faculty fObj)
        //{
        //    bool flag = false;
        //    if (fid != fObj.FacultyId)
        //    {
        //        throw new Exception("Please Enter Valid Faculty ID");
        //    }
        //    else
        //    {
        //        Faculty tempFaculty = _db.Faculties.Find(fid);
        //        tempFaculty.FirstName = fObj.FirstName;
        //        tempFaculty.LastName = fObj.LastName;
        //        tempFaculty.FacultyAddress = fObj.FacultyAddress;
        //        tempFaculty.City = fObj.City;
        //        tempFaculty.FacultyState = fObj.FacultyState;
        //        tempFaculty.Pincode = fObj.Pincode;
        //        tempFaculty.MobileNo = fObj.MobileNo;
        //        tempFaculty.LastName = fObj.LastName;
        //        tempFaculty.HireDate = fObj.HireDate;
        //        tempFaculty.EmailAddress = fObj.EmailAddress;
        //        tempFaculty.DateOfBirth = fObj.DateOfBirth;
        //        tempFaculty.DeptId = fObj.DeptId;
        //        tempFaculty.DesignationId = fObj.DesignationId;
        //        _db.SaveChanges();
                
        //        flag = true;
        //    }
        //    _db.Entry(fObj).State = EntityState.Modified;
           
        //    return flag;
        //}
        private bool FacultyExists(int id)
        {
            return _db.Faculties.Any(e => e.FacultyId == id);
        }

        public bool UpdateFacultyInfo(int id, Faculty fObj)
        {
            if (id != fObj.FacultyId)
            {
                throw new Exception("Invaild Faculty ID");
            }
            else
            {
                Faculty tempFaculty = _db.Faculties.Find(id);

                tempFaculty.FirstName = fObj.FirstName;
                tempFaculty.LastName = fObj.LastName;
                tempFaculty.FacultyAddress = fObj.FacultyAddress;
                tempFaculty.City = fObj.City;
                tempFaculty.FacultyState = fObj.FacultyState;
                tempFaculty.Pincode = fObj.Pincode;
                tempFaculty.MobileNo = fObj.MobileNo;
                tempFaculty.LastName = fObj.LastName;
                tempFaculty.HireDate = fObj.HireDate;
                tempFaculty.EmailAddress = fObj.EmailAddress;
                tempFaculty.DateOfBirth = fObj.DateOfBirth;
                tempFaculty.DeptId = fObj.DeptId;
                tempFaculty.DesignationId = fObj.DesignationId;

                _db.SaveChanges();
            }
            //hdbCon.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return true;
        }

    }
}
