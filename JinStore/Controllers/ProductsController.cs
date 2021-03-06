﻿using Google.Apis.QPXExpress.v1;
using Google.Apis.QPXExpress.v1.Data;
using Google.Apis.Services;
using JinStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
 using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JinStore.Controllers
{
    public class ProductsController : Controller
    {
      

        public ActionResult SearchResult()
        {
            Product model = new Product();
            return View(model);
        }

        [Authorize(Roles = "Admin,ProductAdmin")]
        public ActionResult RoundTripSearch()
        {
            return View();
        }


    }
}
