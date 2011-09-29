using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ODataReferences.Web.Models;
using ODataReferences.Web.Proxies;

namespace ODataReferences.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var blogDataProxy = new BlogDataProxy();

            var model = new BlogPostsModel
                            {
                                Posts = blogDataProxy.Posts.ToArray()
                            };

            return View(model);
        }

    }
}
