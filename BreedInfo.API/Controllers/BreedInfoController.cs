using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreedInfo.DataStore;
using BreedInfo.StaticDataStore;
using Microsoft.AspNetCore.Mvc;

namespace BreedInfo.API.Controllers
{
    [Route("api/[controller]")]
    public class BreedInfoController : Controller
    {
        private IBreedInfoDataStore breedInfoDataStore;

        public BreedInfoController() 
        {
            this.breedInfoDataStore = new StaticBreedInfoDataStore();    
        }

        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{name}")]
        public JsonResult Get(string name)
        {
            return new JsonResult(this.breedInfoDataStore.GetBreedInfo(name));
        }
    }
}
