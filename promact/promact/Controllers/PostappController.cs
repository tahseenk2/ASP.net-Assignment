using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using promact.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace promact.Controllers
{
    public class PostappController : Controller
    {
        private readonly AppDbContext _mcontext;

        public PostappController(AppDbContext context)
        {
            _mcontext = context;
        }

        public IActionResult Postmsg()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Postmsg(Postapp dm)
        {
            _mcontext.Add(dm);
            _mcontext.SaveChanges();
            return View();
        }


       

        public IActionResult PostComment()
        {
            return View();
        }

        public IActionResult ShareMessage()
        {
            return View();
        }


        /* public IActionResult PostComment(Postapp cm)
         {

             _mcontext.Add(cm);
             _mcontext.SaveChanges();
             return View();
         }*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult PostComment(int id, Postapp cm)
        {
            int temp = id;
            _mcontext.Add(cm);
            _mcontext.SaveChanges();
            cm.commentID = temp;
            _mcontext.SaveChanges();
            return RedirectToAction("PostComment", "Postapp", new { area = "" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult ShareMessage(int id, Postapp cm)
        {
            int temp = id;
            _mcontext.Add(cm);
            _mcontext.SaveChanges();
            cm.shareID = temp;
            _mcontext.SaveChanges();
            return RedirectToAction("ShareMessage", "Postapp", new { area = "" });
        }


        public RedirectToActionResult Like(int id)
        {
            var x = _mcontext.Message.Find(id);
            x.likes = x.likes + 1;
            _mcontext.SaveChanges();
            return RedirectToAction("Index", "Show", new { area ="" });
        }
        
    }
}
