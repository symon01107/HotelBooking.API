using HotelBooking.API.DbModels;
using HotelBooking.API.ViewModels;

namespace HotelBooking.API.Services.Interface
{
    public interface IHotelInformationService
    {
        Task<HotelInfoVM> GetHotelById(int hotelId);
        Task<PagedHotelInformation> GetHotels(HotelSearch hotelSearch);
    }
}
