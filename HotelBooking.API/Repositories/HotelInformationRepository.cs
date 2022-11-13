using HotelBooking.API.DbModels;
using HotelBooking.API.Repositories.Interfaces;
using HotelBooking.API.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.API.Repositories
{
    public class HotelInformationRepository : IHotelInformationRepository
    {
        private readonly HotelBookingDBContext context;

        public HotelInformationRepository(HotelBookingDBContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<HotelInfoVM> GetHotelById(int hotelId)
        {
            return await (from w in context.Hotels
                    .Include(w => w.HotelFacilities).ThenInclude(s => s.Feature)
                                             .Include(w => w.HotelRatings)
                                             .Include(w => w.HotelReviews)
                          select new HotelInfoVM
                          {
                              HotelId = w.Id,
                              Description = w.Description,
                              HotelName = w.HotelName,
                              HotelRating = Math.Ceiling(w.HotelRatings.Select(s => s.Rating).Average()),
                              ReviewCount = w.HotelReviews.Count(),
                              CostPerNight = w.CostPerNight,
                              Facilities = w.HotelFacilities.Select(s => new HotelFacilitiesVM { FacilityName = s.Feature.FeatureName, ImageName = s.Feature.FeatureImage }).ToList(),
                          }).SingleOrDefaultAsync(w => w.HotelId == hotelId);
        }


        public async Task<PagedHotelInformation> GetHotels(HotelSearch hotelSearch)
        {
            var data = (from w in context.Hotels.Include(w => w.HotelFacilities).ThenInclude(s => s.Feature)
                                            .Include(w => w.HotelRatings)
                                            .Include(w => w.HotelReviews)


                        select new HotelInfoVM
                        {
                            HotelId = w.Id,
                            Description = w.Description,
                            HotelName = w.HotelName,
                            HotelRating = Math.Ceiling(w.HotelRatings.Select(s => s.Rating).Average()),
                            ReviewCount = w.HotelReviews.Count(),
                            CostPerNight = w.CostPerNight,
                            Facilities = w.HotelFacilities.Select(s => new HotelFacilitiesVM { FacilityName = s.Feature.FeatureName, ImageName = s.Feature.FeatureImage }).ToList(),
                        }).AsNoTracking().AsQueryable();


            if (!string.IsNullOrEmpty(hotelSearch.SearchText) && hotelSearch.CheckInDate.HasValue && hotelSearch.CheckoutDate.HasValue)
            {
                data = from w in data.Where(w => w.HotelName.Contains(hotelSearch.SearchText))
                           //from booking in context.HotelBookings.Where(b => b.HotelInformationId == w.HotelId).DefaultIfEmpty()
                           // where hotelSearch.CheckInDate.Value > booking.CheckInDate
                       select w;

            }

            return new PagedHotelInformation
            {
                hotelInfoVMs = data.OrderByDescending(w => w.HotelRating).Skip((hotelSearch.PageNumber - 1) * hotelSearch.PageSize),
                PagingInfo = new PaginInfoVM
                {
                    PageNumber = hotelSearch.PageNumber,
                    PageSize = hotelSearch.PageSize,
                    RecordCount = data.Count()
                }
            };
        }
    }
}

