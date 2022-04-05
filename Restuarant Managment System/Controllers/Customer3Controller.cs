using Restuarant_Managment_System.RS;

using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Web;

using System.Web.Mvc;





namespace Restuarant_Managment_System.Controllers

{

    public class Customer3Controller : Controller

    {

        // GET: Customer3 



        RMSEntities dbbobj = new RMSEntities();

        public ActionResult CustomerC()

        {

            return View();

        }

        [HttpPost]



        public ActionResult AddCustomerC(Customer O, int Id)

        {

            Customer ob1 = new Customer();

            ob1.Id = O.Id;

            ob1.Name = O.Name;

            ob1.Address = O.Address;

            ob1.Phone = O.Phone;

            ob1.Password = O.Password;



            dbbobj.Customers.Add(ob1);

            dbbobj.SaveChanges();



            if (Id == 0)
            {
                dbbobj.Customers.Add(ob1);

                dbbobj.SaveChanges();
            }
            else
            {
                dbbobj.Entry(ob1).State = EntityState.Modified;
                dbbobj.SaveChanges();
            }


            return View("CustomerC");

        }
        public ActionResult CustomerList()

        {
            var res1 = dbbobj.Customers.ToList();

            return View(res1);

        }

        public ActionResult Delete(int Id)

        {
            var res1 = dbbobj.Customers.Where(x => x.Id == Id).First();
            dbbobj.Customers.Remove(res1);
            dbbobj.SaveChanges();
            var list = dbbobj.Customers.ToList();

            return View("CustomerList", list);

        }



    }
}