using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using calculator.Models;
namespace SimpleCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calculator()
        {
            return View(new CalculatorModel());
        }
        // GET: Calculator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calculator/Create
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

        // GET: Calculator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculator(CalculatorModel model)
        {
            switch (model.Operation)
            {
                case "Add": model.Result = model.Num1 + model.Num2; break;
                case "Subtract": model.Result = model.Num1 - model.Num2; break;
                case "Multiply": model.Result = model.Num1 * model.Num2; break;
                case "Divide": model.Result = model.Num2 != 0 ? (double)model.Num1 / model.Num2 : 0; break;
            }
            return View(model);
        }

        // POST: Calculator/Edit/5
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

        // GET: Calculator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calculator/Delete/5
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
