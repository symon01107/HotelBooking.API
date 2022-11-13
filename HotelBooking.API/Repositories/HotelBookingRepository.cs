using HotelBooking.API.DbModels;
using HotelBooking.API.Repositories.Interfaces;
using HotelBooking.API.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace HotelBooking.API.Repositories
{
    public class HotelBookingRepository : IHotelBookingRepository
    {
        private readonly HotelBookingDBContext context;

        public HotelBookingRepository(HotelBookingDBContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> BookRoom(HotelBookingRequestVM hotelBookingRequest)
        {
            var emptyRooms = await context.RoomInfos
                            .Include(w=>w.HotelInformation)
                            .Include(w => w.HotelBookingInfos)
                            .Where(w => w.HotelInformationId==hotelBookingRequest.HotelId && !w.HotelBookingInfos
                                        .Any(s => (hotelBookingRequest.CheckInDate >= s.CheckInDate && hotelBookingRequest.CheckoutDate<=s.CheckOutDate)
                                               //&& (hotelBookingRequest.CheckoutDate >= s.CheckInDate && hotelBookingRequest.CheckoutDate <= s.CheckOutDate) 
                                                   )) 
                            .ToListAsync();

            if (emptyRooms.Any())
            {

                var hotelBooking = new HotelBookingInfo
                {
                    BookingDate = DateTime.UtcNow,
                    CheckInDate = hotelBookingRequest.CheckInDate,
                    CheckOutDate = hotelBookingRequest.CheckoutDate,
                    CostPerNight = emptyRooms.FirstOrDefault().HotelInformation.CostPerNight,
                    CreatedBy="Get UserId from Token",
                    CreatedDate=DateTime.UtcNow,
                    UpdatedBy= "Get UserId from Token",
                    RoomInfoId = emptyRooms.FirstOrDefault().Id,
                    UpdatedDate=DateTime.UtcNow
                };

                await context.HotelBookings.AddAsync(hotelBooking);
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
