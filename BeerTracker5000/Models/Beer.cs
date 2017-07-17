using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerTracker5000.Models
{
    public class Beer
    {
        public int ID { get; set; }
        public string BeerName { get; set; }
        public string BreweryName { get; set; }
        public string Style { get; set; }
        public decimal Abv { get; set; }
        public int Ibu { get; set; }
        public int Rating { get; set; }
        public string Notes { get; set; }
    }
}
