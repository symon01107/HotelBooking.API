using HotelBooking.API.Repositories.Interfaces;
using HotelBooking.API.Services.Interface;
using HotelBooking.API.ViewModels;

namespace HotelBooking.API.Services
{
    public class BookingService : IBookingService
    {
        private readonly IHotelBookingRepository hotelBookingRepository;

        public BookingService(IHotelBookingRepository hotelBookingRepository)
        {
            this.hotelBookingRepository = hotelBookingRepository;
        }

        public async Task<bool> BookHotelRoom(HotelBookingRequestVM hotelBookingRequest)
        {
            return await hotelBookingRepository.BookRoom(hotelBookingRequest);
        }
    }
}
