using FacultyInformationSystem_MVCCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FacultyInformationSystem_MVCCore.Models;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace FacultyInformationSystem_MVCCore.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult ShowMe()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentSection()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult AdminProfile()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<ActionResult> Login(Login LObj)
        {

            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(LObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Authenticate/login", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            var jsonData = JsonConvert.DeserializeObject<LoginGet>(apiResponse);
            if (jsonData != null)
            {
                HttpContext.Session.SetString("JWToken", jsonData.Token);
                var stream = jsonData.Token;
                int id = jsonData.Id;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(stream);
                var tokenS = jsonToken as JwtSecurityToken;

                var jti = tokenS.Claims.Where(claim => claim.Type == "jti").ToList();

                var role = tokenS.Claims.First(claim => claim.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").ToString();
                
                Faculty fObj = new Faculty();
                fObj.FacultyId = id;

                if (role == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role: Admin")
                {
                    TempData["AlertMessage"] = "Login Successful..";
                    return View("AdminProfile");
                }
                else
                {
                    TempData["AlertMessage"] = "Login Successful..";
                    return View("FacultyProfile",fObj);
                }
            }
            else
            {
                return View();
            }

        }

       
        public IActionResult SignUpAsAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignUpAsAdmin(RegisterModel RObj)
        {
            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(RObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Authenticate/register-admin", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<RegisterModel>(apiResponse) != null)
            {
                //return View();
                return View("AddDetails");
            }
            else
            {
                return View();
            }
        }

        public IActionResult SignUpAsFaculty()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignUpAsFaculty(RegisterModel RObj)
        {
            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(RObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Authenticate/register-faculty", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<RegisterModel>(apiResponse) != null)
            {
                return View("AddDetails");
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public ActionResult AddDetails()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddDetails(Faculty rObj)
        {
            HttpClient httpClient = new HttpClient();
            StringContent Content = new StringContent(JsonConvert.SerializeObject(rObj), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("http://localhost:11884/api/Faculties", Content);
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (JsonConvert.DeserializeObject<Faculty>(apiResponse) != null)
            {
                TempData["AlertMessage"] = "Account Created Successfully..";
                return RedirectToAction("Login");
            }
            else
            { 
                return View("Index","Auth");
            }

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            TempData["AlertMessage"] = "Logout Successful..";
            return View("Login");

        }



    }
}
