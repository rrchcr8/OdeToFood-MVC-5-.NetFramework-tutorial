﻿using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingsController : Controller
    {
        // GET: Greetings
        public ActionResult Index(string name)
        {
            var model = new GreetingsViewModel();
            model.Name = name ?? "No name";
            //var name = HttpContext.Request.QueryString["name"];
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}