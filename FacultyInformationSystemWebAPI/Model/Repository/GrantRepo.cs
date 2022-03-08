using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystemWebAPI.Model.Repository
{
    public class GrantRepo : IGrantRepository
    {
        private readonly FIS_DBContext _db;

        public GrantRepo(FIS_DBContext db)
        {
            _db = db;
        }

        public static List<Grant> grantList = new List<Grant>()
        {

        };
        public bool AddGrantInfo(Grant gObj)
        {
            int originalRecord = _db.Grants.Count();
            int newRecord = 0;

            if (gObj != null)
            {
                _db.Grants.Add(gObj);
                _db.SaveChanges();
                newRecord = _db.Grants.Count();
            }
            else
            {
                throw new Exception("Grant Record is not Added");
            }
            if (newRecord > originalRecord)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool DeleteGrantInfo(int gid)
        {
            int originalRecord = _db.Grants.Count();
            int newRecord = 0;

            if (gid > 0)
            {
                Grant tempGrant = _db.Grants.Find(gid);
                if (tempGrant != null)
                {
                    _db.Grants.Remove(tempGrant);
                    _db.SaveChanges();
                    newRecord = _db.Grants.Count();
                }
                else
                {
                    throw new Exception("Grant Record doesn't exist");
                }
            }
            else
            {
                throw new Exception("Enter Valid Grant ID");
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

        public List<Grant> GetGrants()
        {
            return _db.Grants.ToList<Grant>();
        }

        public Grant ShowGrantInfoByID(int gid)
        {
            Grant tempGrant = _db.Grants.FirstOrDefault(s => s.GrantId == gid);
            return tempGrant;    
        }

        public bool UpdateGrantInfo(int gid, Grant gObj)
        {
            bool flag = false;
            Grant tempGrant = grantList.FirstOrDefault(s => s.GrantId == gid);
            if (tempGrant != null)
            {
                tempGrant.GrantId = gObj.GrantId;
                tempGrant.FacultyId = gObj.FacultyId;
                tempGrant.GrantTitle = gObj.GrantTitle;
                tempGrant.GrantId = gObj.GrantId;
                tempGrant.GrantDescription = gObj.GrantDescription;


                flag = true;
            }
            return flag;
            
        }
    }
}
