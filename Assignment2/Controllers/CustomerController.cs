using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Entities;

namespace Assignment2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepositories _repo = new CustomerRepositories();
        // GET: CustomerController1
        public ActionResult Index()
        {
            List<Customer> list = _repo.GetCustomers();
            return View(list);
        }

        // GET: CustomerController1/Details/5
        public ActionResult Details(int id)
        {
            Customer c = _repo.GetCustomerById(id);
            return View(c);
        }

        // GET: CustomerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Add(c);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Edit/5
        public ActionResult Edit(int id)
        {
            Customer c = _repo.GetCustomerById(id);
            return View(c);
        }

        // POST: CustomerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)
        {
            try
            {
                _repo.Update(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c = _repo.GetCustomerById(id);
            return View(c);
        }

        // POST: CustomerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer c)
        {
            try
            {
                _repo.Delete(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
