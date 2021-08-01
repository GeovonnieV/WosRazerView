using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WosRazerView.Controllers
    {
        public class RazerViewController : Controller
        {
            [HttpGet("")]
            public ViewResult Index()
                {
                    return View();
                }


        }

    }