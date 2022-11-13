using HotelBooking.API.ViewModels;

namespace HotelBooking.API.Services.Interface
{
    public interface IBookingService
    {
        Task<bool> BookHotelRoom(HotelBookingRequestVM hotelBookingRequest);
    }
}
