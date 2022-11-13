using HotelBooking.API.Utilities;

namespace HotelBooking.API.DbModels
{
    public class HotelBookingInfo : UserLog
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal CostPerNight { get; set; }
        public int RoomInfoId { get; set; }

        public virtual RoomInfo RoomInfo { get; set; }

    }
}
