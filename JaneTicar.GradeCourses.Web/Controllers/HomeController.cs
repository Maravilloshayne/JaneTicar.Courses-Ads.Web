﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JaneTicar.GradeCourses.Web.Models;
using JaneTicar.GradeCourses.Web.Infrastructures.Data.Helpers;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using JaneTicar.GradeCourses.Web.ViewModels.Courses;
using Newtonsoft.Json;
using JaneTicar.GradeCourses.Web.Infrastructures.Data.Models;

namespace JaneTicar.GradeCourses.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly DefaultDbContext _context;
        private IHostingEnvironment _env;


        public HomeController(DefaultDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }



        [HttpGet, Route("")]
        [HttpGet, Route("home")]
        [HttpGet, Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("home/initialize")]
        public IActionResult Init()
        {
            var course = this._context.Courses.FirstOrDefault();

            if (course == null)
            {

                using (StreamReader r = new StreamReader(_env.WebRootPath + "\\data.json"))
                {
                    string json = r.ReadToEnd();
                    List<CoursesImportViewModel> items = JsonConvert.DeserializeObject<List<CoursesImportViewModel>>(json);
                    int ctr = 0;

                    foreach (var item in items)
                    {
                        this._context.Courses.Add(new Course()
                        {
                            Id = Guid.Parse(item.Content),
                            Timestamp = DateTime.UtcNow.AddHours(ctr),
                            PostExpiry = DateTime.UtcNow.AddDays(ctr),
                            IsPublished = true,
                            TemplateName = "faq1",
                            Title = item.Title,
                            Description = item.Description,
                            Content = item.Content.Replace("'", @"\'")
                        });
                        ctr = ctr + 1;
                    }
                }

                this._context.SaveChanges();
            }

            var user = this._context.Users.FirstOrDefault();

            if (user == null)
            {
                var admin = new User()
                {
                    Id = Guid.Parse("b2e5a4fc-ca4e-4d3f-b9ac-d8a088cd6401"),
                    EmailAddress = "louhangregorio@gmail.com",
                    FirstName = "louhan",
                    LastName = "Gregorio",
                    Gender = Infrastructures.Data.Enums.Gender.Male,
                    LoginStatus = Infrastructures.Data.Enums.LoginStatus.Active,
                    LoginTrials = 0,
                    RegistrationCode = RandomString(6),
                    Password = BCrypt.BCryptHelper.HashPassword("Taiwan09132012", BCrypt.BCryptHelper.GenerateSalt(8))
                };

                this._context.Users.Add(admin);
                this._context.SaveChanges();

                this._context.UserRoles.Add(new UserRole()
                {
                    Id = Guid.Parse("b2e5a4fc-ca4e-4d3f-b9ac-d8a088cd6401"),
                    Role = Infrastructures.Data.Enums.Role.Admins,
                    UserId = admin.Id
                });

                this._context.SaveChanges();
            }

            return RedirectToAction("index");

            //return RedirectPermanent("~/posts/index");
        }

        private Random random = new Random();
        private string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpGet, Route("home/about")]
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

