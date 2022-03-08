using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class DesignationController : Controller
    {

        Uri baseAddress = new Uri("http://localhost:11884/api");

        HttpClient httpClient;
        public DesignationController()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = baseAddress;

        }


        public async Task<IActionResult> Index()
        {
            List<Designation> designations = new List<Designation>();
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:11884/api/Designations");

            string apiResponse = await response.Content.ReadAsStringAsync();
            designations = JsonConvert.DeserializeObject<List<Designation>>(apiResponse);
            return View(designations);
        }

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            Designation designationObj = new Designation();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Designations/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    designationObj = JsonConvert.DeserializeObject<Designation>(apiResponse);
                }
            }
            return View(designationObj);
        }

        // GET: DesignationController/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(Designation dsObj)
        {

            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(dsObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Designations", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Designation>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Record Created Successfully..";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        // GET: DesignationController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Designation desigObj = new Designation();



            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Designations/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    desigObj = JsonConvert.DeserializeObject<Designation>(apiResponse);
                }
            }
            return View(desigObj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Designation desigObj)
        {
            Designation designationObj = new Designation();



            using (HttpClient httpClient = new HttpClient())
            {
                StringContent Content = new StringContent(JsonConvert.SerializeObject(desigObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Designations/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        designationObj = JsonConvert.DeserializeObject<Designation>(apiResponse);
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
                client.BaseAddress = new Uri("http://localhost:11884/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Designations/" + id.ToString());
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
