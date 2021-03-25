﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IstanbulNsApp.Libs;
using IstanbulNsApp.Models;
using IstanbulNsApp.Repositories;
using IstanbulNsApp.Resources.DTO;
using IstanbulNsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;

namespace IstanbulNsApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly HttpClient _fc;
        private readonly IConfiguration _configuration;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public HomeController(IHttpClientFactory fc, IConfiguration config, IStringLocalizer<SharedResource> localizer)
        {
            _fc = fc.CreateClient(name: "ApiRequests");
            _configuration = config;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Services()
        {
            var client = new ServiceNodeAsync<object, List<ServiceDTO>>(_fc);
            var services = await client.GetClientAsync("/api/services/services/1");
            return View(services.Data);
        }
        public IActionResult Doctors([FromQuery] int page =0)
        {
            int pagecount = page;
            var services = new ServiceNode<object, DoctorViewModel>(_fc).GetClient("/api/doctors/all/admin/" + pagecount);
            return View("Doctors", services.Data);         
        }
    }
}
