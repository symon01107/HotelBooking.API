using HotelBooking.API.Services.Interface;
using HotelBooking.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService bookingService;

        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        [HttpPost(Name = "BookHotel")]
        public async Task<IActionResult> BookHotelRoom(HotelBookingRequestVM hotelBookingRequest)
        {
            var success = await bookingService.BookHotelRoom(hotelBookingRequest);
            return Ok(new { Message = success ? "Booked Successfully" : "No room available" });
        }
    }
}
