using FacultyInformationSystem_MVCCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class SubjectController : Controller
    {
        // GET: SubjectController
        
        public async Task<IActionResult> Index()
        {
            List<Subject> subjects = new List<Subject>();
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(" http://localhost:11884/api/Subjects ");

            string apiResponse = await response.Content.ReadAsStringAsync();
            subjects = JsonConvert.DeserializeObject<List<Subject>>(apiResponse);
            return View(subjects);
        }

        // GET: SubjectController/Details/5
       
        public async Task<ActionResult> Details(int id)
        {
            Subject subObj = new Subject();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Subjects/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    subObj = JsonConvert.DeserializeObject<Subject>(apiResponse);
                }
            }
            return View(subObj);
        }

        
        // GET: SubjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
       
        public async Task<IActionResult> Create(Subject subjectObj)
        {

            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(subjectObj), Encoding.UTF8, "application/json");



            var response = await httpClient.PostAsync("http://localhost:11884/api/Subjects", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Subject>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Record Created Successfully..";
                return RedirectToAction("Index");
            
            }
            else
            {
                //return RedirectToAction("Index");
                return View();
            }

        }

        // GET: SubjectController/Edit/5
   
        public async Task<IActionResult> Edit(int id)
        {
            Subject subObj = new Subject();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Subjects/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    subObj = JsonConvert.DeserializeObject<Subject>(apiResponse);
                }
            }
            return View(subObj);
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Subject subObj)
        {
            Subject subjectObj = new Subject();

            using (HttpClient httpClient = new HttpClient())
            {
                StringContent Content = new StringContent(JsonConvert.SerializeObject(subObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Subjects/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        subjectObj = JsonConvert.DeserializeObject<Subject>(apiResponse);
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

        
        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(" http://localhost:11884/api/");
                
                var deleteTask = client.DeleteAsync("Subjects/" + id.ToString());
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
