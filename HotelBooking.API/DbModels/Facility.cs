namespace HotelBooking.API.DbModels
{
    public class Facility
    {
        public int Id { get; set; }
        public string? FeatureName { get; set; }
        public string? FeatureImage { get; set; } // Blob storage or local file  

        public virtual ICollection<HotelFacility> HotelFeatures { get; set; }

        public Facility()
        {
            HotelFeatures = new List<HotelFacility>();
        }
    }
}
