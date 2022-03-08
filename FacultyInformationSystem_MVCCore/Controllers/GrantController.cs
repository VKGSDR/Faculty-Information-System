using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using FacultyInformationSystem_MVCCore.Models;
using Newtonsoft.Json;
using System.Text;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class GrantController : Controller
    {
        // GET: GrantController
        public async Task<IActionResult> Index()
        {
            List<Grant> grants = new List<Grant>();
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:11884/api/Grants");

            string apiResponse = await response.Content.ReadAsStringAsync();
            grants = JsonConvert.DeserializeObject<List<Grant>>(apiResponse);
            return View(grants);
        }

        // GET: GrantController/Details/5

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            Grant grantObj = new Grant();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Grants/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    grantObj = JsonConvert.DeserializeObject<Grant>(apiResponse);
                }
            }
            return View(grantObj);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsbyFaculty(int id)
        {
            List<Grant> grants = new List<Grant>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Grants/FacultyGrant?id="+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    grants = JsonConvert.DeserializeObject<List<Grant>>(apiResponse);
                }
            }
            return View(grants);
        }

        [HttpGet]
        // GET: GrantController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Grant gObj)
        {
            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(gObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Grants", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Grant>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Record Created Successfully..";
                return RedirectToAction("Index");
            }
            else
            {
                
                return View();
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            Grant gObj = new Grant();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Grants/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    gObj = JsonConvert.DeserializeObject<Grant>(apiResponse);
                }
            }
            return View(gObj);
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Grant gObj)
        {
            Grant grantObj = new Grant();

            using (HttpClient httpClient = new HttpClient())
            {
                StringContent Content = new StringContent(JsonConvert.SerializeObject(gObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Grants/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        grantObj = JsonConvert.DeserializeObject<Grant>(apiResponse);
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

        // POST: GrantController/Delete/5
        //[HttpPost]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:11884/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Grants/" + id.ToString());
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

