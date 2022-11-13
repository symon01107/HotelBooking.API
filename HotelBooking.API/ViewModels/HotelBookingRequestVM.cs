namespace HotelBooking.API.ViewModels
{
    public class HotelBookingRequestVM
    {
        public int HotelId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public int NumberOfPerson { get; set; }

    }
}
