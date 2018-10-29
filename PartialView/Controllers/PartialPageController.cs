using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartialView.Controllers
{
    public class PartialPageController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}