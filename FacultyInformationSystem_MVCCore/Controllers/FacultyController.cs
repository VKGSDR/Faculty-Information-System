using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using FacultyInformationSystem_MVCCore.Models;
using System.Text;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;


namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class FacultyController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:11884/api");

        HttpClient httpClient;
        public FacultyController()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = baseAddress;

        }
        // GET: FacultyController
       
        public async Task<IActionResult> Index()
        {
            List<Faculty> faculties = new List<Faculty>();
            HttpClient httpClient = new HttpClient();
            
            var response = await httpClient.GetAsync("http://localhost:11884/api/Faculties");

            string apiResponse = await response.Content.ReadAsStringAsync();
            faculties = JsonConvert.DeserializeObject<List<Faculty>>(apiResponse);
            return View(faculties);
        }

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            Faculty facultyObj = new Faculty();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Faculties/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    facultyObj = JsonConvert.DeserializeObject<Faculty>(apiResponse);
                }
            }
            return View(facultyObj);
        }

        //GET: FacultyController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Faculty rObj)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
            StringContent Content = new StringContent(JsonConvert.SerializeObject(rObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Faculties", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Faculty>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Record Created Successfully..";
                return RedirectToAction("Index");
            }
            else
            {
                
                return View();
            }

        }



        // GET: CourseController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Faculty fObj = new Faculty();



            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Faculties/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    fObj = JsonConvert.DeserializeObject<Faculty>(apiResponse);
                }
            }
            return View(fObj);
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Faculty fObj)
        {
            Faculty facultyObj = new Faculty();



            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                StringContent Content = new StringContent(JsonConvert.SerializeObject(fObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Faculties/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        facultyObj = JsonConvert.DeserializeObject<Faculty>(apiResponse);
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

        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                client.BaseAddress = new Uri("http://localhost:11884/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Faculties/" + id.ToString());
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

