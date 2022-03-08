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

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class WorkHistoryController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:11884/api");

        HttpClient httpClient;
        public WorkHistoryController()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = baseAddress;

        }
        // GET: FacultyController

        public async Task<IActionResult> Index()
        {
            List<WorkHistory> workHistories = new List<WorkHistory>();
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:11884/api/WorkHistories");

            string apiResponse = await response.Content.ReadAsStringAsync();
            workHistories = JsonConvert.DeserializeObject<List<WorkHistory>>(apiResponse);
            return View(workHistories);
        }

        // GET: FacultyController/Details/5

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            WorkHistory workHistoryObj = new WorkHistory();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/WorkHistories/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    workHistoryObj = JsonConvert.DeserializeObject<WorkHistory>(apiResponse);
                }
            }
            return View(workHistoryObj);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsbyFaculty(int id)
        {
            List<WorkHistory> workHistories = new List<WorkHistory>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/WorkHistories/FacultyWorkHistory?id="+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    workHistories = JsonConvert.DeserializeObject<List<WorkHistory>>(apiResponse);
                }
            }
            return View(workHistories);
        }

        //GET: FacultyController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(WorkHistory workHistoryObj)
        {
            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(workHistoryObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/WorkHistories", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<WorkHistory>(apiResponse) != null)
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
            WorkHistory workHistoryObj = new WorkHistory();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/WorkHistories/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    workHistoryObj = JsonConvert.DeserializeObject<WorkHistory>(apiResponse);
                }
            }
            return View(workHistoryObj);
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, WorkHistory wObj)
        {
            WorkHistory workHistoryObj = new WorkHistory();



            using (HttpClient httpClient = new HttpClient())
            {
                StringContent Content = new StringContent(JsonConvert.SerializeObject(wObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/WorkHistories/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        workHistoryObj = JsonConvert.DeserializeObject<WorkHistory>(apiResponse);
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
                client.BaseAddress = new Uri("http://localhost:11884/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("WorkHistories/" + id.ToString());
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

