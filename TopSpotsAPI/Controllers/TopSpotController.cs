using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    public class TopSpotController : ApiController
    {
        // get /api/values
        public IEnumerable<TopSpot> Get()
        {
            TopSpot[] topspots = JsonConvert.DeserializeObject<TopSpot[]>(File.ReadAllText(@"C:\dev\13-TopSpotsAPI\TopSpotsAPI\JSON\sandiego.json"));


            return topspots;
            
        }

        //Post /api/vehicles
        //public TopSpot Post([FromBody]TopSpot topspot)
        //{
        //    return topspot;
        //}

    }
}
