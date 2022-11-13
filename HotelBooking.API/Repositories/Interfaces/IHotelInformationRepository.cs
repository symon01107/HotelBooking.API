using HotelBooking.API.DbModels;
using HotelBooking.API.ViewModels;

namespace HotelBooking.API.Repositories.Interfaces
{
    public interface IHotelInformationRepository
    {
        Task<HotelInfoVM> GetHotelById(int hotelId);
        Task<PagedHotelInformation> GetHotels(HotelSearch hotelSearch);
    }
}
