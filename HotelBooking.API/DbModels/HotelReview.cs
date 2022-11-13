using HotelBooking.API.Utilities;

namespace HotelBooking.API.DbModels
{
    public class HotelReview : UserLog
    {
        public int Id { get; set; }
        public int HotelInformationId { get; set; }
        public string Review { get; set; }
        
        public virtual HotelInformation HotelInformation { get; set; }
    }
}
