using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using promact.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace promact.Controllers
{
    public class ShowController : Controller
    {
        private readonly IPostappRepository _postapprepository;

        public ShowController(IPostappRepository postapprepository)
        {
            _postapprepository = postapprepository;

        }
        public IActionResult Index()
        {
            return View(_postapprepository.AllMessage);
        }
    }
}
