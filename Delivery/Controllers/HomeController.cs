using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delivery.Data.Repository;
using Delivery = Delivery.Data.Models.Delivery;

namespace Delivery.Controllers
{
    public class HomeController : Controller
    {
        private readonly DeliveryRepository deliveryRepository;
        public HomeController(DeliveryRepository deliveryRepository)
        {
            this.deliveryRepository = deliveryRepository;
        }



        public IActionResult Index()
        {
            var model = deliveryRepository.AllDeliveries();
            return View(model);
        }

        [Route("/Add")]
        public IActionResult Add()
        {
            Data.Models.Delivery model = new Data.Models.Delivery();
            
            return View(model);
        }

        [HttpPost]
        [Route("/Add")]
        public IActionResult Add(Data.Models.Delivery model)
        {
            if (ModelState.IsValid)
            {
               deliveryRepository.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);

        
        }
    }
}
