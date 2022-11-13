using HotelBooking.API.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace HotelBooking.API.Repositories
{
    public class HotelBookingDBContext : DbContext
    {
        public DbSet<HotelInformation> Hotels { get; set; }
        public DbSet<HotelBookingInfo> HotelBookings { get; set; }
        public DbSet<Facility> Features { get; set; }
        public DbSet<HotelFacility> HotelFeatures { get; set; }
        public DbSet<HotelRating> HotelRatings { get; set; }
        public DbSet<HotelReview> HotelReviews { get; set; }
        public DbSet<RoomInfo> RoomInfos { get; set; }

        public HotelBookingDBContext(DbContextOptions<HotelBookingDBContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelInformation>().ToTable("HotelInformation");
            modelBuilder.Entity<Facility>().ToTable("Features");
            modelBuilder.Entity<HotelFacility>().ToTable("HotelFeatures");
            modelBuilder.Entity<HotelReview>().ToTable("HotelReviews");
            modelBuilder.Entity<HotelRating>().ToTable("HotelRatings");
            modelBuilder.Entity<HotelBookingInfo>().ToTable("HotelBookingInfo");
            modelBuilder.Entity<RoomInfo>().ToTable("RoomInformation");

            modelBuilder.Entity<HotelInformation>().HasData(
                new HotelInformation
                {
                    Id = 1,
                    HotelName = "Name1",
                    Description = "Description 1",
                    Address= "address 1",
                    CreatedDate = DateTime.Now,
                    CostPerNight = 1,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelInformation
                {
                    Id = 2,
                    HotelName = "Name2",
                    Description = "Description 2",
                    Address = "address 1",
                    CreatedDate = DateTime.Now,
                    CostPerNight = 1,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelInformation
                {
                    Id = 3,
                    HotelName = "Name 3",
                    Description = "Description 3",
                    Address = "address 3",
                    CreatedDate = DateTime.Now,
                    CostPerNight = 1,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelInformation
                {
                    Id = 4,
                    HotelName = "Name 4",
                    Description = "Description 4",
                    Address = "address 3",
                    CreatedDate = DateTime.Now,
                    CostPerNight = 1,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                }
                );

            modelBuilder.Entity<Facility>().HasData(
                new Facility
                {
                    Id = 1,
                    FeatureImage = "",
                    FeatureName = "Breakfast",
                },
                new Facility
                {
                    Id = 2,
                    FeatureImage = "",
                    FeatureName = "Wifi",
                },
                new Facility
                {
                    Id = 3,
                    FeatureImage = "",
                    FeatureName = "Parking",
                },
                new Facility
                {
                    Id = 4,
                    FeatureImage = "",
                    FeatureName = "Spa",
                }
                );

            modelBuilder.Entity<HotelFacility>().HasData(
                new HotelFacility
                {
                    Id = 1,
                    HotelInformationId = 1,
                    FacilityId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 2,
                    HotelInformationId = 1,
                    FacilityId = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 3,
                    HotelInformationId = 1,
                    FacilityId = 3,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 4,
                    HotelInformationId = 1,
                    FacilityId = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 5,
                    HotelInformationId = 2,
                    FacilityId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 6,
                    HotelInformationId = 2,
                    FacilityId = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 7,
                    HotelInformationId = 2,
                    FacilityId = 3,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 8,
                    HotelInformationId = 2,
                    FacilityId = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },

                new HotelFacility
                {
                    Id = 9,
                    HotelInformationId = 3,
                    FacilityId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 10,
                    HotelInformationId = 4,
                    FacilityId = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 11,
                    HotelInformationId = 4,
                    FacilityId = 3,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelFacility
                {
                    Id = 12,
                    HotelInformationId = 1,
                    FacilityId = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                }
                );

            modelBuilder.Entity<HotelRating>().HasData(
                new HotelRating
                {
                    Id = 1,
                    HotelInformationId = 1,
                    Rating = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 2,
                    HotelInformationId = 1,
                    Rating = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 3,
                    HotelInformationId = 1,
                    Rating = 3,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 4,
                    HotelInformationId = 1,
                    Rating = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 5,
                    HotelInformationId = 2,
                    Rating = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 6,
                    HotelInformationId = 2,
                    Rating = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 7,
                    HotelInformationId = 2,
                    Rating = 3,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 8,
                    HotelInformationId = 2,
                    Rating = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },

                new HotelRating
                {
                    Id = 9,
                    HotelInformationId = 3,
                    Rating = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 10,
                    HotelInformationId = 4,
                    Rating = 2,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 11,
                    HotelInformationId = 4,
                    Rating = 3,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelRating
                {
                    Id = 12,
                    HotelInformationId = 1,
                    Rating = 4,
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                }
                );


            modelBuilder.Entity<HotelReview>().HasData(
                new HotelReview
                {
                    Id = 1,
                    HotelInformationId = 1,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,

                },
                new HotelReview
                {
                    Id = 2,
                    HotelInformationId = 1,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 3,
                    HotelInformationId = 1,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 4,
                    HotelInformationId = 1,
                    Review = "Happy to be here!",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 5,
                    HotelInformationId = 2,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 6,
                    HotelInformationId = 2,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 7,
                    HotelInformationId = 2,
                    Review = "Nice",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 8,
                    HotelInformationId = 2,
                    Review = "Very good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },

                new HotelReview
                {
                    Id = 9,
                    HotelInformationId = 3,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 10,
                    HotelInformationId = 4,
                    Review = "Misc",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 11,
                    HotelInformationId = 4,
                    Review = "Bad",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                },
                new HotelReview
                {
                    Id = 12,
                    HotelInformationId = 1,
                    Review = "Good",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "",
                    UpdatedBy = "",
                    UpdatedDate = DateTime.Now,
                });

            modelBuilder.Entity<RoomInfo>().HasData(
                new RoomInfo
                {
                    Id = 1,
                    HotelInformationId = 1,
                    RoomNo = "1",

                },
                new RoomInfo
                {
                    Id = 2,
                    HotelInformationId = 1,
                    RoomNo = "2",
                },
                new RoomInfo
                {
                    Id = 3,
                    HotelInformationId = 1,
                    RoomNo = "3",
                },
                new RoomInfo
                {
                    Id = 4,
                    HotelInformationId = 1,
                    RoomNo = "4",
                },
                new RoomInfo
                {
                    Id = 5,
                    HotelInformationId = 2,
                    RoomNo = "1",
                },
                new RoomInfo
                {
                    Id = 6,
                    HotelInformationId = 2,
                    RoomNo = "2",
                },
                new RoomInfo
                {
                    Id = 7,
                    HotelInformationId = 2,
                    RoomNo = "3",
                },
                new RoomInfo
                {
                    Id = 8,
                    HotelInformationId = 2,
                    RoomNo = "4",
                },

                new RoomInfo
                {
                    Id = 9,
                    HotelInformationId = 3,
                    RoomNo = "1",
                },
                new RoomInfo
                {
                    Id = 10,
                    HotelInformationId = 4,
                    RoomNo = "2",
                },
                new RoomInfo
                {
                    Id = 11,
                    HotelInformationId = 4,
                    RoomNo = "3",
                },
                new RoomInfo
                {
                    Id = 12,
                    HotelInformationId = 4,
                    RoomNo = "4",
                }
                );
        }

    }
}
