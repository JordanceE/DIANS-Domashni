using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ВиноХармони.Models
{
    public class Winery
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string InternationalPhoneNumber { get; set; }
        public string OpeningHours { get; set; }
        public string Website { get; set; }
        public float Rating { get; set; }
        public int TotalReviews { get; set; }
        public string GoogleMapsURL { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}