using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
        [Route("/index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/packageCost")]
        public ActionResult packageCost(int weight, int length, int width)
        {
            
            Parcel myParcel = new Parcel(weight, length, width);
            return View(myParcel);
            
        }        
    }
}