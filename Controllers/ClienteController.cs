using Microsoft.AspNetCore.Mvc;
using Trabalho.get.MVC.Context;
using Trabalho.get.MVC.Models;

namespace Trabalho.get.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly DataContext _dataContext;
        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult ClienteList()
        {
            var clientes = _dataContext.Clientes.ToList();
            return View(clientes);
        }
       
    }
}
