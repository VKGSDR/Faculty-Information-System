using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class DepartmentController : Controller
    {

        Uri baseAddress = new Uri("http://localhost:11884/api");

        HttpClient httpClient;
        public DepartmentController()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = baseAddress;

        }

        public async Task<IActionResult> Index()
        {
            List<Department> departments = new List<Department>();
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
            var response = await httpClient.GetAsync("http://localhost:11884/api/Departments");

            string apiResponse = await response.Content.ReadAsStringAsync();
            departments = JsonConvert.DeserializeObject<List<Department>>(apiResponse);
            return View(departments);
        }

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            Department departmentObj = new Department();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Departments/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    departmentObj = JsonConvert.DeserializeObject<Department>(apiResponse);
                }
            }
            return View(departmentObj);
        }

        // GET: DepartmentController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Department dObj)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
            StringContent content = new StringContent(JsonConvert.SerializeObject(dObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Departments", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Department>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Record Created Successfully..";
                return RedirectToAction("Index");
            }
            else
            {                   
                return View();
            }

        }

        // GET: DepartmentController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Department deptObj = new Department();



            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Departments/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    deptObj = JsonConvert.DeserializeObject<Department>(apiResponse);
                }
            }
            return View(deptObj);
        }

       

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Department deptObj)
        {
            Department departmentObj = new Department();



            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                StringContent Content = new StringContent(JsonConvert.SerializeObject(deptObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Departments/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        departmentObj = JsonConvert.DeserializeObject<Department>(apiResponse);
                        ViewBag.Status = "Success";
                        TempData["AlertMessage"] = "Record Edited Successfully..";
                    }
                    else
                    {
                        ViewBag.Status = "Unsuccessful";
                    }
                }
            }
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                client.BaseAddress = new Uri("http://localhost:11884/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Departments/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    TempData["AlertMessage"] = "Record Deleted Successfully..";
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
