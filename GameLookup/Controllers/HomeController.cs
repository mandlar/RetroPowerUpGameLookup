using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GameLookup.Models;
using Newtonsoft.Json;
using unirest_net.http;

namespace GameLookup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(SearchModel model)
        {
            if(!string.IsNullOrEmpty(model.Query))
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation("X-Mashape-Key", "INSERT_API_KEY_HERE");
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                    var json = client.GetStringAsync("https://igdbcom-internet-game-database-v1.p.mashape.com/games/?fields=*&limit=10&offset=0&search=" + model.Query);
                    
                    model.Games = JsonConvert.DeserializeObject<List<Game>>(json.Result);
                }
            }

            return View(model);
        }
    }
}