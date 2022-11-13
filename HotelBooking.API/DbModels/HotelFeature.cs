using HotelBooking.API.Utilities;

namespace HotelBooking.API.DbModels
{
    public class HotelFacility : UserLog
    {
        public int Id { get; set; }
        public int HotelInformationId { get; set; }
        public int FacilityId { get; set; }

        public virtual HotelInformation HotelInformation { get; set; }
        public virtual Facility Feature { get; set; }
    }
}
