using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using USER404.Models;

namespace USER404.Controllers {
    public class RoomsController : Controller
    {
        public IActionResult Home(){
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Rooms roomForm){
            RoomsRepository rr =  new RoomsRepository();
            rr.insert(roomForm);

            return RedirectToAction("Room", "Questions");
        }
        public IActionResult About(){
            return View();
        }

    }
}