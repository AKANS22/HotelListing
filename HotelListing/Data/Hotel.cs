using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set;}
        public string HotelDescription { get; set;} = string.Empty;
         public string HotelAddress { get; set;}
        public string Rating { get; set;}
        [ForeignKey(nameof(Country))]
        public Country Country { get; set;}
        public int CountryId { get; set; }

    }
}
