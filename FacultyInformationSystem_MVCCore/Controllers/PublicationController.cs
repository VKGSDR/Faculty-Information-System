using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using FacultyInformationSystem_MVCCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class PublicationController : Controller
    {
        // GET: PublicationController
        public async Task<ActionResult> Index()
        {
            List<Publication> publications = new List<Publication>();
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:11884/api/Publications");

            string apiResponse = await response.Content.ReadAsStringAsync();
            publications = JsonConvert.DeserializeObject<List<Publication>>(apiResponse);
            return View(publications);
        }

        public async Task<IActionResult> PublicationData()
        {
            List<Publication> publications = new List<Publication>();
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:11884/api/Publications");

            string apiResponse = await response.Content.ReadAsStringAsync();
            publications = JsonConvert.DeserializeObject<List<Publication>>(apiResponse);
            return View(publications);
        }

        // GET: PublicationController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Publication publicationObj = new Publication();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Publications/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    publicationObj = JsonConvert.DeserializeObject<Publication>(apiResponse);
                }
            }
            return View(publicationObj);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsbyFaculty(int id)
        {
            List<Publication> publications = new List<Publication>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:11884/api/Publications/FacultyPublication?id="+id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    publications = JsonConvert.DeserializeObject<List<Publication>>(apiResponse);
                }
            }
            return View(publications);
        }

        [HttpGet]
        // GET: PublicationController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Publication pubObj)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(pubObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Publications", content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Publication>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Record Created Successfully..";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: PublicationController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            Publication pObj = new Publication();



            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(" http://localhost:11884/api/Publications/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    pObj = JsonConvert.DeserializeObject<Publication>(apiResponse);
                }
            }
            return View(pObj);
        }

        // POST: PublicationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Publication pObj)
        {
            Publication publicationObj = new Publication();



            using (HttpClient httpClient = new HttpClient())
            {
                StringContent Content = new StringContent(JsonConvert.SerializeObject(pObj), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:11884/api/Publications/" + id, Content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        publicationObj = JsonConvert.DeserializeObject<Publication>(apiResponse);
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

        // GET: PublicationController/Delete/5
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:11884/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("Publications/" + id.ToString());
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
