using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using USER404.Models;

namespace USER404.Controllers {
    public class RoomController : Controller
    {
        public IActionResult Home(){
            return View();
        }
        public IActionResult About(){
            return View();
        }
        public IActionResult Room(){
            return View();
        }
    }
}