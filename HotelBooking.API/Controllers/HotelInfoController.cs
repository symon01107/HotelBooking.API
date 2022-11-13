using HotelBooking.API.Services.Interface;
using HotelBooking.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class HotelInfoController : ControllerBase
    {
        private readonly IHotelInformationService hotelInformationService;

        public HotelInfoController(IHotelInformationService hotelInformationService)
        {
            this.hotelInformationService = hotelInformationService;
        }

        [HttpGet(Name = "SerchHotels")]
        public async Task<IActionResult> SerchHotels([FromQuery]HotelSearch hotelSearch)
        {
            var data = await hotelInformationService.GetHotels(hotelSearch);
            return Ok(data);
        }

        [HttpGet(Name = "GetHotelById")]
        public async Task<IActionResult> GetHotelById(int hotelId)
        {
            var data = await hotelInformationService.GetHotelById(hotelId);
            return Ok(data);
        }
    }
}
