﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Areas.Control.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Control/Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Control/Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Control/Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Control/Home/Create

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
        // GET: /Control/Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Control/Home/Edit/5

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
        // GET: /Control/Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Control/Home/Delete/5

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