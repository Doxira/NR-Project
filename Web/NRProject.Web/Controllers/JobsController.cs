using Microsoft.AspNetCore.Mvc;

namespace NRProject.Web.Controllers
{
    public class JobsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
