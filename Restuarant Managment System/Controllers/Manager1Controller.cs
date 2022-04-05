using Restuarant_Managment_System.RS;

using System;

using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Web;

using System.Web.Mvc;



namespace Restuarant_Managment_System.Controllers

{

    public class Manager1Controller : Controller

    {

        // GET: Manager 

        RMSEntities dbObj = new RMSEntities();



        public ActionResult ManagerC(Manager obj)

        {
             
                 return View(obj);

        }

        [HttpPost]



        public ActionResult AddManagerC(Manager M, int Id)

        {

            Manager obj = new Manager();

            obj.Id = M.Id;

            obj.Uname = M.Uname;

            obj.Email = M.Email;

            obj.Phone = M.Phone;

            obj.Pasword = M.Pasword;


            
            if (Id == 0)
            {
                dbObj.Managers.Add(obj);

                dbObj.SaveChanges();
            }
            else
            {
                dbObj.Entry(obj).State = EntityState.Modified;
                dbObj.SaveChanges();
            }


            return View("ManagerC");

        }

        public ActionResult ManagerList()

        {
            var res1 = dbObj.Managers.ToList();

            return View(res1);

        }

        public ActionResult Delete(int Id)

        {
            var res1 = dbObj.Managers.Where(x => x.Id == Id).First();
            dbObj.Managers.Remove(res1);
            dbObj.SaveChanges();
            var list = dbObj.Managers.ToList();

            return View("ManagerList", list);

        }
    }

}