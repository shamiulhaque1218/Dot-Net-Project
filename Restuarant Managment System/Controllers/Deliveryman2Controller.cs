using Restuarant_Managment_System.RS;

using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Web;

using System.Web.Mvc;



namespace Restuarant_Managment_System.Controllers

{

    public class Deliveryman2Controller : Controller

    {

        // GET: Deliveryman2 

        RMSEntities dbObj = new RMSEntities();



        public ActionResult DeliverymanD(Deliveryman obj)

        {

            return View(obj);

        }



        [HttpPost]



        public ActionResult AddDeliverymanD(Deliveryman N, int Id)

        {

            Deliveryman obj = new Deliveryman();

            obj.Id = N.Id;

            obj.Name = N.Name;

            obj.Address = N.Address;

            obj.Phone = N.Phone;

            obj.Password = N.Password;



            if (Id == 0)
            {
                dbObj.Deliverymen.Add(obj);

                dbObj.SaveChanges();
            }
            else
            {
                dbObj.Entry(obj).State = EntityState.Modified;
                dbObj.SaveChanges();
            }


            return View("DeliverymanD");

        }

        public ActionResult DeliverymanList()

        {
            var res3 = dbObj.Deliverymen.ToList();

            return View(res3);

        }

        public ActionResult Delete(int Id)

        {
            var res3 = dbObj.Deliverymen.Where(x => x.Id == Id).First();
            dbObj.Deliverymen.Remove(res3);
            dbObj.SaveChanges();
            var list = dbObj.Deliverymen.ToList();

            return View("DeliverymanList", list);

        }
    }

}