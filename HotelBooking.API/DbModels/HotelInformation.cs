using HotelBooking.API.Utilities;

namespace HotelBooking.API.DbModels
{
    public class HotelInformation : UserLog
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Description { get; set; }
        public decimal CostPerNight { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


        public virtual ICollection<HotelFacility> HotelFacilities { get; set; }

        public virtual ICollection<HotelRating> HotelRatings { get; set; }
        public virtual ICollection<HotelReview> HotelReviews { get; set; }
        public virtual ICollection<RoomInfo> Rooms { get; set; }

        public HotelInformation()
        {
            HotelFacilities = new List<HotelFacility>();
            HotelRatings = new List<HotelRating>();
            HotelReviews = new List<HotelReview>();
            Rooms = new List<RoomInfo>();

        }

    }
}
