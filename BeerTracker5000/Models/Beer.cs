using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeerTracker5000.Models
{
    // Beer Data Model Class --- Defines properties of data stored in database
    // Use [Display] to set the display name of the property in the View
    public class Beer
    {
        public int ID { get; set; }
        [Display(Name = "Beer Name")]
        public string BeerName { get; set; }
        [Display(Name = "Brewery Name")]
        public string BreweryName { get; set; }
        public string Style { get; set; }
        public decimal Abv { get; set; }
        public int Ibu { get; set; }
        public int Rating { get; set; }
        public string Notes { get; set; }
    }
}
