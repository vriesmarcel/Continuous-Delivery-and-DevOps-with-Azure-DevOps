using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcMusicStore.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using Microsoft.ApplicationInsights;



namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {

        IMusicStoreEntities storeDB = null;
        //
        // GET: /Home/
        public HomeController()
        {
            storeDB =  new MusicStoreEntities();
        }

        public HomeController(IMusicStoreEntities dbcontext)
        {
            storeDB = dbcontext;
        }

        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);
  
            return View(albums);
        }

       

        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
     

    }

   
}