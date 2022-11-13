using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class HotelbookingDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostPerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelInformationId = table.Column<int>(type: "int", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelFeatures_Features_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelFeatures_HotelInformation_HotelInformationId",
                        column: x => x.HotelInformationId,
                        principalTable: "HotelInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelInformationId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRatings_HotelInformation_HotelInformationId",
                        column: x => x.HotelInformationId,
                        principalTable: "HotelInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelInformationId = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelReviews_HotelInformation_HotelInformationId",
                        column: x => x.HotelInformationId,
                        principalTable: "HotelInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomInformation_HotelInformation_HotelInformationId",
                        column: x => x.HotelInformationId,
                        principalTable: "HotelInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelBookingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostPerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomInfoId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelBookingInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelBookingInfo_RoomInformation_RoomInfoId",
                        column: x => x.RoomInfoId,
                        principalTable: "RoomInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "FeatureImage", "FeatureName" },
                values: new object[,]
                {
                    { 1, "", "Breakfast" },
                    { 2, "", "Wifi" },
                    { 3, "", "Parking" },
                    { 4, "", "Spa" }
                });

            migrationBuilder.InsertData(
                table: "HotelInformation",
                columns: new[] { "Id", "Address", "CostPerNight", "CreatedBy", "CreatedDate", "Description", "HotelName", "Latitude", "Longitude", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "address 1", 1m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3703), "Description 1", "Name1", 0m, 0m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3721) },
                    { 2, "address 1", 1m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3725), "Description 2", "Name2", 0m, 0m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3726) },
                    { 3, "address 3", 1m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3728), "Description 3", "Name 3", 0m, 0m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3728) },
                    { 4, "address 3", 1m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3730), "Description 4", "Name 4", 0m, 0m, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3731) }
                });

            migrationBuilder.InsertData(
                table: "HotelFeatures",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FacilityId", "HotelInformationId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3900), 1, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(3901) },
                    { 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4010), 2, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4011) },
                    { 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4012), 3, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4013) },
                    { 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4014), 4, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4015) },
                    { 5, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4016), 1, 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4016) },
                    { 6, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4017), 2, 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4018) },
                    { 7, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4019), 3, 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4019) },
                    { 8, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4020), 4, 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4021) },
                    { 9, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4022), 1, 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4023) },
                    { 10, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4023), 2, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4024) },
                    { 11, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4025), 3, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4026) },
                    { 12, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4027), 4, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4027) }
                });

            migrationBuilder.InsertData(
                table: "HotelRatings",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "HotelInformationId", "Rating", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4051), 1, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4052) },
                    { 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4053), 1, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4054) },
                    { 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4055), 1, 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4055) },
                    { 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4056), 1, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4057) },
                    { 5, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4058), 2, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4058) },
                    { 6, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4059), 2, 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4060) },
                    { 7, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4061), 2, 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4062) },
                    { 8, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4062), 2, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4063) },
                    { 9, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4064), 3, 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4065) },
                    { 10, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4066), 4, 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4066) },
                    { 11, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4067), 4, 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4068) },
                    { 12, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4069), 1, 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4069) }
                });

            migrationBuilder.InsertData(
                table: "HotelReviews",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "HotelInformationId", "Review", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4088), 1, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4089) },
                    { 2, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4090), 1, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4091) },
                    { 3, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4092), 1, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4092) },
                    { 4, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4093), 1, "Happy to be here!", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4094) },
                    { 5, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4095), 2, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4095) },
                    { 6, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4096), 2, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4098) },
                    { 7, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4098), 2, "Nice", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4099) },
                    { 8, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4100), 2, "Very good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4101) },
                    { 9, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4102), 3, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4102) },
                    { 10, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4103), 4, "Misc", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4104) },
                    { 11, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4105), 4, "Bad", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4106) },
                    { 12, "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4106), 1, "Good", "", new DateTime(2022, 11, 13, 11, 13, 14, 426, DateTimeKind.Local).AddTicks(4107) }
                });

            migrationBuilder.InsertData(
                table: "RoomInformation",
                columns: new[] { "Id", "HotelInformationId", "RoomNo" },
                values: new object[,]
                {
                    { 1, 1, "1" },
                    { 2, 1, "2" },
                    { 3, 1, "3" },
                    { 4, 1, "4" },
                    { 5, 2, "1" },
                    { 6, 2, "2" },
                    { 7, 2, "3" },
                    { 8, 2, "4" },
                    { 9, 3, "1" },
                    { 10, 4, "2" },
                    { 11, 4, "3" },
                    { 12, 4, "4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelBookingInfo_RoomInfoId",
                table: "HotelBookingInfo",
                column: "RoomInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelFeatures_FacilityId",
                table: "HotelFeatures",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelFeatures_HotelInformationId",
                table: "HotelFeatures",
                column: "HotelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatings_HotelInformationId",
                table: "HotelRatings",
                column: "HotelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelReviews_HotelInformationId",
                table: "HotelReviews",
                column: "HotelInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomInformation_HotelInformationId",
                table: "RoomInformation",
                column: "HotelInformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelBookingInfo");

            migrationBuilder.DropTable(
                name: "HotelFeatures");

            migrationBuilder.DropTable(
                name: "HotelRatings");

            migrationBuilder.DropTable(
                name: "HotelReviews");

            migrationBuilder.DropTable(
                name: "RoomInformation");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "HotelInformation");
        }
    }
}
