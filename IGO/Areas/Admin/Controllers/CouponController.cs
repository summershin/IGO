﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IGO.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class CouponController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
