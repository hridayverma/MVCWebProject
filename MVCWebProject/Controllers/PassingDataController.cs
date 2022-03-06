using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebProject.Models;
namespace MVCWebProject.Controllers
{
    public class PassingDataController : Controller
    {
        // GET: PassingData
        public ActionResult Index()
        {
            return View();
        }
        
        //using parameters
        [HttpPost]
        public string Index(string fname,string lname)
        {
            return "Data using parameters:" + fname + "&nbsp;" + lname;
        }

        //Using Request

        [HttpPost]
        public string PostUsingRequest()
        {
            return "Data using Request:" + Request["fname"] + "&nbsp;" + Request["lname"];
        }

        //Using FormCollection
        [HttpPost]
        public string PostUsingForm(FormCollection form)
        {
            return "Data using FormCollection:" + form["fname"] + "&nbsp;" + form["lname"];
        }


        // GET: PassingData
        public ViewResult RegisterStudent() {
            
            return View();
        }

        //Post using Model 
        //[HttpPost]
        //public string RegisterStudent(Student student)
        //{

        //    return $"Data using Model:ID:{student.Id} " +
        //           $"Name:{student.Name}Address:{student.Address}Mark:{student.Mark}";
        //}

        [HttpPost]
        public ViewResult RegisterStudent(Student student)
        {

            return View("Details", student);
        }






    }
}