using HotelBooking.API.ViewModels;

namespace HotelBooking.API.Repositories.Interfaces
{
    public interface IHotelBookingRepository
    {
        Task<bool> BookRoom(HotelBookingRequestVM hotelBookingRequest);
    }
}
