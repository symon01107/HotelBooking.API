using HotelBooking.API.Utilities;

namespace HotelBooking.API.DbModels
{
    public class HotelRating : UserLog
    {
        public int Id { get; set; }
        public int HotelInformationId { get; set; }
        public int Rating { get; set; }
        public virtual HotelInformation HotelInformation { get; set; }
    }
}
