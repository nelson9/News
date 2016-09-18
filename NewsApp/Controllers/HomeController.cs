using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public HomeController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Publish()
        {
            ViewBag.Title = "Publish";
            return View();
        }
        public ActionResult News()
        {
            ViewBag.Title = "Latest News";
            return View();
        }

        public ActionResult Article()
        {
            ViewBag.Title = "Latest News";
            return View();
        }
        //public ActionResult Delete()
        //{
        //    ViewBag.Title = "Delete";
        //    return View();
        //}
        //public ActionResult Edit()
        //{
        //    ViewBag.Title = "Edit";
        //    return View();
        //}
    }
}
