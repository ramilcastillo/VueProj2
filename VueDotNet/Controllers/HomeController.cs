using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VueDotNet.DTO;
using VueDotNet.Models;
using VueDotNet.Services;

namespace VueDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonalInformationBusinessLogic _bl;
        public HomeController(IPersonalInformationBusinessLogic businessLogic)
        {
            _bl = businessLogic;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SubmitedForm([FromBody] PersonalInformationViewModel form)
        {
            string message = "";

            await _bl.Save(form);
            message = "Success";
            return Json(new { message });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
