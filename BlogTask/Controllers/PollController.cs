﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Entities.Polls;
using Blog.Entities.Polls.ViewModels;

namespace BlogTask.Controllers
{
    public class PollController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}