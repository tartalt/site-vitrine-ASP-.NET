using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL.Client;

namespace App.Controllers
{
    public class ClientController : Controller
    {
        

        
        public ActionResult Detail(int id)
        {
            ClientService clientService = new ClientService();

            return View(clientService.DetailsClient(id));
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ClientCreateVM model)
        {
            if (ModelState.IsValid)
            {

                var clientCreate = new ClientService();
                clientCreate.CreateClient(model);

                return RedirectToAction("Index" , "Auth");
            }


            return View(model);
        }
        public ActionResult Edit()
        {
            
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientUpdateVM clientUpdate)
        {

            if (clientUpdate != null)
            {

                ClientService clientService = new ClientService();
                clientService.UpdateClient(clientUpdate);

                return RedirectToAction("Index", "Home");
            }
            return View(clientUpdate);
        }

      
       
        
    }
}
