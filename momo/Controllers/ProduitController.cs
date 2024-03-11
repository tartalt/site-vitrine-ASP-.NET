using BLL;
using DAL.Entity;
using DAL.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace App.Controllers
{
    [Authorize]

    public class ProduitController : Controller
    {

       
        public IActionResult Index()
        {
            ProduitService service = new ProduitService();
            return View(service.Listservices());
        }
        public IActionResult Categories(int id)
        {
            ProduitService service = new ProduitService();
            return View(service.ListCategory(id));
        }
    }
}
        
    
