using LYF_BLOG.ControllerAuthorize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LYF_BLOG.Areas.BlogAdmin.Controllers
{
    [AdministratorAuthorize]
    public class BoardController : Controller
    {
        // GET: BlogAdmin/Board
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogAdmin/Board/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogAdmin/Board/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogAdmin/Board/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogAdmin/Board/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogAdmin/Board/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogAdmin/Board/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogAdmin/Board/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
