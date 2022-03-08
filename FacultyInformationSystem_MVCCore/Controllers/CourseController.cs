using FacultyInformationSystem_MVCCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class CourseController : Controller
    {

        // GET: CourseController
        public async Task<IActionResult> Index()
        {
            List<Course> courses = new List<Course>();
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));

            var response = await httpClient.GetAsync(" http://localhost:11884/api/Courses ");

            string apiResponse = await response.Content.ReadAsStringAsync();
            courses = JsonConvert.DeserializeObject<List<Course>>(apiResponse);
            return View(courses);
        }

        // GET: CourseController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Course courseObj = new Course();
            
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Courses/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    courseObj = JsonConvert.DeserializeObject<Course>(apiResponse);
                }
            }
            return View(courseObj);
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course courseObj)
        {

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
            StringContent Content = new StringContent(JsonConvert.SerializeObject(courseObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Courses", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Course>(apiResponse) != null)
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
            Course courseObj = new Course();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Courses/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    courseObj = JsonConvert.DeserializeObject<Course>(apiResponse);
                }
            }
            return View(courseObj);
        }


        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Course courseObj)
        {
            Course roomObj = new Course();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                StringContent Content = new StringContent(JsonConvert.SerializeObject(courseObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Courses/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        roomObj = JsonConvert.DeserializeObject<Course>(apiResponse);
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

        
        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("JWToken"));
                client.BaseAddress = new Uri(" http://localhost:11884/api/");
                
                var deleteTask = client.DeleteAsync("Courses/" + id.ToString());
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
