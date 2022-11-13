using HotelBooking.API.DbModels;

namespace HotelBooking.API.ViewModels
{
    public class PagedHotelInformation
    {
        public IEnumerable<HotelInfoVM> HotelInfo { get; set; }
        public PaginInfoVM PagingInfo { get; set; }
    }

    public class HotelInfoVM
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public double HotelRating { get; set; }
        public int ReviewCount { get; set; }
        public string Description { get; set; }
        public ICollection<HotelFacilitiesVM> Facilities { get; set; }

        public decimal CostPerNight { get; set; }
    }

    public class HotelFacilitiesVM
    {
        public string ImageName { get; set; }
        public string FacilityName { get; set; }
    }

    public class PaginInfoVM
    {
        public int RecordCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
