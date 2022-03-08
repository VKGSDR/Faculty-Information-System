using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyInformationSystem_MVCCore.DropDownList
{
    public class DeptDropDownController: Controller
    {
        public ActionResult Index()
        {

            List<Department> deptIdList = new List<Department>();

            string cs = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select DeptId from Department", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Department d1 = new Department();
                    d1.DeptId = Int32.Parse((string)rdr["DeptId"]);
                    deptIdList.Add(d1);

                }
                SelectList list = new SelectList(deptIdList, "DeptId", "DeptId");
                ViewBag.DropdownList = list;

            }
            return View();
        }
    }
}
