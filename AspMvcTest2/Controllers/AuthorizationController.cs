using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcTest2.Controllers
{
    public class AuthorizationController : Controller
    {
        // GET: Authorization
        Context context = new Context();
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public string Index(Users User)
        {
            var query = context.Users.Where(u => u.FirstName == User.FirstName).Where(u => u.LastName == User.LastName).Select(u => new { u }).FirstOrDefault();
            if (query != null)
            {
                return query.u.LastName;
            }
            else 
            {
                return "Логин или пароль неверный";
            }
            //return View();
        }
    }
}