using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvcTest2;
using AspMvcTest2.Controllers;
using System.Data.Entity;

namespace AspMvcTest2.Controllers
{
    public class UserTableController : Controller
    {
        Context context = new Context();
        // GET: UserTable
        public ActionResult Index()
        {
            //Context context = new Context();
            //var query = (from users in context.Users select users).ToList();
            var query = context.Users.Include(q => q.Role);
            return View(query.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Users user = context.Users.Find(id);
            if (user != null)
            {
                SelectList roles = new SelectList(context.Roles, "Id", "RoleName", user.Id);
                ViewBag.Roles = roles;
                return View(user);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Users users)
        {
            var query = (from u in context.Users where u.IdUser == users.IdUser select u).Include(q => q.Role).First();
            query.FirstName = users.FirstName;
            query.LastName = users.LastName;
            query.Id = users.Id;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Users user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create() 
        {
            SelectList roles = new SelectList(context.Roles, "Id", "RoleName");
            ViewBag.Roles = roles;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Users user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}