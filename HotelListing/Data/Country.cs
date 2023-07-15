using System.Collections.Generic;

namespace HotelListing.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int CountryCode { get; set; }
        public string CountryDescription { get; set; }
        public string CourntryShortName { get; set; }
        //public List<Hotel> Hotels { get; set; }
    }
}
