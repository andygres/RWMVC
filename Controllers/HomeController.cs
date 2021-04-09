using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RWMVC.Models;

namespace RWMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoUpload(Document doc)
        {
            ViewBag.thing = doc.FileNumber;

            return View();


            //if (doc.HasFile && fileNumValid)
            //{
            //    try
            //    {
            //        uploadDoc(lblFileID.Text, fuDocument.FileBytes, fuDocument.FileName.ToString(), Convert.ToInt32(ddlDocType.SelectedValue), txtDescription.Text);
            //        uploadSuccess = true;
            //    }
            //    catch (AggregateException)
            //    {
            //        lblComplete.Text = "Something went wrong. Please try again later.";
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("File number" + lblFileID + " invalid");
            //}
        }
    }
}
