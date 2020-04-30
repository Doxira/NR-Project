using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NRProject.Web.Controllers
{
    public class PrivacyController : BaseController
    {
        public IActionResult Privacy()
        {
            return this.View();
        }
    }
}
