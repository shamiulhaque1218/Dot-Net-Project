using Restuarant_Managment_System.RS;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.Mvc;



namespace Restuarant_Managment_System.Controllers

{

    public class Feedback4Controller : Controller

    {

        // GET: Feedback4 

        RMSEntities dbbobje = new RMSEntities();

        public ActionResult FeedbackF()

        {

            return View();

        }

        [HttpPost]



        public ActionResult AddFeedbackF(Feedback F)

        {

            Feedback ob2 = new Feedback();

            ob2.Id = F.Id;

            ob2.Feedb = F.Feedb;





            dbbobje.Feedbacks.Add(ob2);

            dbbobje.SaveChanges();



            return View("FeedbackF");

        }
        public ActionResult FeedbackList()

        {
            var res2 = dbbobje.Feedbacks.ToList();

            return View(res2);

        }

    }

}