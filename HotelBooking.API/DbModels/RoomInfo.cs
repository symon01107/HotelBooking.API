namespace HotelBooking.API.DbModels
{
    public class RoomInfo
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }

        public int HotelInformationId { get; set; }
        public virtual HotelInformation HotelInformation { get; set; }

        public virtual ICollection<HotelBookingInfo> HotelBookingInfos { get; set; }

        public RoomInfo()
        {
            HotelBookingInfos = new List<HotelBookingInfo>();
        }
    }
}
