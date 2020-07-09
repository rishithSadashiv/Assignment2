using Assignment2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Assignment2.Repositories
{
    public class CustomerRepositories
    {
        public List<Customer> GetCustomers()
        {
            using (CustomerContext db = new CustomerContext())
            {
                return db.Customer.ToList() ;
                // return db.Employees.Where(i => i.Salary == 10000).ToList(); return multiple employees using salary
            }

        }

        public Customer GetCustomerById(int id)
        {
            using (CustomerContext db  = new CustomerContext())
            {
                return db.Customer.Find(id);
                //  return db.Employees.SingleOrDefault(i => i.Eid == eid); //search with any column
            }

        }

        public void Add(Customer c)
        {
            using (CustomerContext db = new CustomerContext())
            {
                db.Customer.Add(c);
                db.SaveChanges();
            }
        }

        public void Delete(Customer c)
        {
            using (CustomerContext db = new CustomerContext())
            {
                db.Customer.Remove(c);
                db.SaveChanges();
            }

        }

        public void Update(Customer c)
        {
            using (CustomerContext db = new CustomerContext())
            {
                db.Customer.Update(c);
                db.SaveChanges();
            }
        }
    }
}
