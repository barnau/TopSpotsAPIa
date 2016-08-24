using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TopSpotsAPI.Models
{
    public class TopSpot
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public double[] Location { get; set; }

        //public TopSpot(string name, string description, double[] location)
        //{
        //    Name = name;
        //    Description = description;
        //    Location = location;
        //}
       
    }
}