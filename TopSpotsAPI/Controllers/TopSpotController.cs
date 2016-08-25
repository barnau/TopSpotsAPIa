using Newtonsoft.Json;

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
        public void Post([FromBody]TopSpot[] topspots)
        {
            string text = JsonConvert.SerializeObject(topspots);

            File.WriteAllText(@"C:\dev\13-TopSpotsAPI\TopSpotsAPI\JSON\sandiego.json", text);
        }

        public List<TopSpot> Delete(int id)
        {
            List<TopSpot> topspots = JsonConvert.DeserializeObject<List<TopSpot>>(File.ReadAllText(@"C:\dev\13-TopSpotsAPI\TopSpotsAPI\JSON\sandiego.json"));

            topspots.RemoveAt(id);

            string text = JsonConvert.SerializeObject(topspots);
            File.WriteAllText(@"C:\dev\13-TopSpotsAPI\TopSpotsAPI\JSON\sandiego.json", text);

            return topspots;
            
        }





    }
}