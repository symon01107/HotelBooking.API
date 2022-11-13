using HotelBooking.API.DbModels;
using HotelBooking.API.Repositories.Interfaces;
using HotelBooking.API.Services.Interface;
using HotelBooking.API.ViewModels;

namespace HotelBooking.API.Services
{
    public class HotelInformationService : IHotelInformationService
    {
        private readonly IHotelInformationRepository hotelInformationRepository;

        public HotelInformationService(IHotelInformationRepository hotelInformationRepository)
        {
            this.hotelInformationRepository = hotelInformationRepository;
        }

        public async Task<HotelInfoVM> GetHotelById(int hotelId)
        {
            return await hotelInformationRepository.GetHotelById(hotelId);
        }

        public async Task<PagedHotelInformation> GetHotels(HotelSearch hotelSearch)
        {
            return await hotelInformationRepository.GetHotels(hotelSearch);
        }
    }
}
