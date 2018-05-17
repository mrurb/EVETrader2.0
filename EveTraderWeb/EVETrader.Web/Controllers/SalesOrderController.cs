using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EVETrader.Web.Models;

namespace EVETrader.Web.Controllers
{
    public class SalesOrderController : Controller
    {
        // GET: SalesOrder
        public ActionResult Index()
        {
			var salesOrders = new List<SalesOrder>();
            return View(salesOrders);
        }

        // GET: SalesOrder/Details/5
        public ActionResult Details(int id)
        {
			var sleaOder = new SalesOrder();
            return View();
        }

        // GET: SalesOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesOrder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalesOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalesOrder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalesOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalesOrder/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}