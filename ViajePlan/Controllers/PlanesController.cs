using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViajePlan.Models;
using ViajePlan.Models.ViewModels;

namespace ViajePlan.Controllers
{
    public class PlanesController : Controller
    {
        // GET: Planes
        public ActionResult Index()
        {
            List<PlanesViewModel> planes;
            using (ViajesEntities1 dbContext = new ViajesEntities1())
            {
                planes = dbContext.Planes.AsEnumerable().Select(pv => new PlanesViewModel(pv)).ToList();

            }

            return View(planes);
            
        }
    }
}