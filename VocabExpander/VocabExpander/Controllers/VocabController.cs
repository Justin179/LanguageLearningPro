using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VocabExpander.Context;

namespace VocabExpander.Controllers
{

    public class VocabController : Controller
    {
        private VocabContext dbContext = new VocabContext();

        //
        // GET: /Vocab/
        public ActionResult Index()
        {

            return View(dbContext.Vocabs.ToList());
        }

        //
        // GET: /Vocab/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vocab/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vocab/Create
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

        //
        // GET: /Vocab/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vocab/Edit/5
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

        //
        // GET: /Vocab/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vocab/Delete/5
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
