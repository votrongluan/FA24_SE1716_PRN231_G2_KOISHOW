﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KoiShow.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    BirthDay = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompetitionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Participants = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShapePointPercent = table.Column<int>(type: "int", nullable: true),
                    ColorPointPercent = table.Column<int>(type: "int", nullable: true),
                    PatternPointPercent = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varieties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varieties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HtmlContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewCount = table.Column<int>(type: "int", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Accounts_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContestResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestId = table.Column<int>(type: "int", nullable: true),
                    ContestResultName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContestResultDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalScore = table.Column<double>(type: "float", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFinalized = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prize = table.Column<int>(type: "int", nullable: true),
                    PrizeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContestResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContestResults_Contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarietyId = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImgLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeathStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Accounts_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animals_Varieties_VarietyId",
                        column: x => x.VarietyId,
                        principalTable: "Varieties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RegisterForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContestId = table.Column<int>(type: "int", nullable: true),
                    AnimalId = table.Column<int>(type: "int", nullable: true),
                    EntryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckinStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pattern = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisterForms_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegisterForms_Contests_ContestId",
                        column: x => x.ContestId,
                        principalTable: "Contests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisterFormId = table.Column<int>(type: "int", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<double>(type: "float", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vatrate = table.Column<double>(type: "float", nullable: true),
                    ActualCost = table.Column<double>(type: "float", nullable: true),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true),
                    FinalAmount = table.Column<double>(type: "float", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_RegisterForms_RegisterFormId",
                        column: x => x.RegisterFormId,
                        principalTable: "RegisterForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Points",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShapePoint = table.Column<int>(type: "int", nullable: true),
                    ColorPoint = table.Column<int>(type: "int", nullable: true),
                    PatternPoint = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JuryId = table.Column<int>(type: "int", nullable: true),
                    RegisterFormId = table.Column<int>(type: "int", nullable: true),
                    PointStatus = table.Column<int>(type: "int", nullable: true),
                    JudgeRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Penalties = table.Column<int>(type: "int", nullable: true),
                    TotalScore = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Points", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Points_Accounts_JuryId",
                        column: x => x.JuryId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Points_RegisterForms_RegisterFormId",
                        column: x => x.RegisterFormId,
                        principalTable: "RegisterForms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Email", "FullName", "LastUpdatedBy", "LastUpdatedTime", "Password", "Phone", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, "1773 đường Kiếm Lai, phường Tu Tiên, quận Hội Châu, thành phố Long Hoàng", new DateOnly(2003, 1, 1), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1327), null, null, "admin@koi.show", "Quản Trị Viên", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1329), "123", "0971781353", 0, null, "admin" },
                    { 2, "983 đường Kiếm Lai, phường Tu Tiên, quận Hội Châu, thành phố Long Hoàng", new DateOnly(2003, 1, 1), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1336), null, null, "staff@koi.show", "Quản Nhân Viên", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1337), "123", "0971781351", 1, null, "staff" },
                    { 3, "179 đường Kiếm Lai, phường Tu Tiên, quận Hội Châu, thành phố Long Hoàng", new DateOnly(2003, 1, 1), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1340), null, null, "customer1@koi.show", "Quản Khách Hàng 1", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1341), "123", "0971781352", 2, null, "customer" },
                    { 4, "1 đường Kiếm Lai, phường Tu Tiên, quận Hội Châu, thành phố Long Hoàng", new DateOnly(2003, 1, 1), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1344), null, null, "customer2@koi.show", "Quản Khách Hàng 2", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1345), "123", "0971781354", 2, null, "customer" },
                    { 5, "2 đường Kiếm Lai, phường Tu Tiên, quận Hội Châu, thành phố Long Hoàng", new DateOnly(2003, 1, 1), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1348), null, null, "customer3@koi.show", "Quản Khách Hàng 3", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1348), "123", "0971781355", 2, null, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Contests",
                columns: new[] { "Id", "ColorPointPercent", "CompetitionType", "ContactInfo", "ContestName", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "EndDate", "Image", "LastUpdatedBy", "LastUpdatedTime", "Location", "Participants", "PatternPointPercent", "ShapePointPercent", "StartDate", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 35, "Beauty", "info@koicontest.com", "Koi Beauty Contest", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1541), null, null, "Thi đấu để chọn ra những chú cá Koi đẹp nhất về màu sắc và hình dáng.", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/koi_beauty_contest.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1542), "Hồ Chí Minh", 50, 25, 40, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cuộc thi sắc đẹp cá Koi" },
                    { 2, 40, "Performance", "contact@koicontest.com", "Koi Performance Contest", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1548), null, null, "Cuộc thi các màn trình diễn cá Koi độc đáo.", new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/koi_performance_contest.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1549), "Hà Nội", 40, 30, 30, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cuộc thi trình diễn cá Koi" },
                    { 3, 35, "Exhibition", "support@koicontest.com", "International Koi Show", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1553), null, null, "Sự kiện triển lãm cá Koi quốc tế với nhiều loại cá đẹp từ các quốc gia.", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/international_koi_show.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1553), "Đà Nẵng", 100, 30, 35, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Triển lãm cá Koi quốc tế" },
                    { 4, 45, "Breeding", "breeding@koicontest.com", "Koi Breeding Contest", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1558), null, null, "Cuộc thi chọn ra những giống cá Koi khỏe mạnh nhất.", new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/koi_breeding_contest.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1559), "Hồ Chí Minh", 30, 30, 25, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cuộc thi sinh sản cá Koi" },
                    { 5, 50, "Speed", "swim@koicontest.com", "Koi Swimming Contest", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1563), null, null, "Cuộc thi tốc độ bơi lội của các giống cá Koi.", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/koi_swimming_contest.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1563), "Hải Phòng", 25, 30, 20, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cuộc thi bơi lội cá Koi" },
                    { 6, 40, "National", "national@koicontest.com", "National Koi Competition", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1568), null, null, "Cuộc thi cá Koi lớn nhất toàn quốc.", new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/national_koi_competition.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1569), "Huế", 80, 30, 30, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cuộc thi cá Koi toàn quốc" },
                    { 7, 35, "Regional", "regional@koicontest.com", "Regional Koi Championship", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1573), null, null, "Giải vô địch cá Koi với sự tham gia của các giống cá Koi nổi tiếng.", new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/regional_koi_championship.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1573), "Nha Trang", 60, 30, 35, new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Giải vô địch cá Koi khu vực" },
                    { 8, 30, "Art", "art@koicontest.com", "Koi Art Exhibition", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1578), null, null, "Triển lãm nghệ thuật về cá Koi, tập trung vào vẻ đẹp tự nhiên của loài cá này.", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/koi_art_exhibition.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1579), "Đà Lạt", 70, 30, 40, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Triển lãm nghệ thuật cá Koi" },
                    { 9, 40, "Innovation", "innovation@koicontest.com", "Koi Innovation Contest", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1583), null, null, "Cuộc thi sáng tạo mới về kỹ thuật chăm sóc và lai tạo cá Koi.", new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/koi_innovation_contest.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1583), "Vũng Tàu", 55, 30, 30, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cuộc thi sáng tạo cá Koi" }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "LastUpdatedBy", "LastUpdatedTime", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1396), null, null, "Cá Koi với các đốm màu đỏ trên nền trắng.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1396), "Kohaku" },
                    { 2, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1399), null, null, "Cá Koi với các đốm đỏ và đen trên nền trắng.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1400), "Taisho Sanke" },
                    { 3, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1402), null, null, "Cá Koi với các đốm đen và đỏ trên nền trắng, thường có màu đen trên đầu.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1402), "Showa Sanshoku" },
                    { 4, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1404), null, null, "Cá Koi đen với các đốm trắng xen kẽ.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1405), "Shiro Utsuri" },
                    { 5, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1414), null, null, "Cá Koi đen với các đốm đỏ tươi.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1415), "Hi Utsuri" },
                    { 6, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1418), null, null, "Cá Koi đen với các đốm vàng.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1418), "Ki Utsuri" },
                    { 7, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1420), null, null, "Cá Koi với vảy màu xanh nhạt trên lưng và bụng màu đỏ.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1420), "Asagi" },
                    { 8, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1422), null, null, "Loại cá Koi da trơn với các vảy lớn chạy dọc theo lưng, có màu xanh nhạt và đỏ.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1423), "Shusui" },
                    { 9, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1424), null, null, "Cá Koi có màu trắng, đỏ hoặc vàng với các đốm đen.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1425), "Bekko" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalName", "BirthDate", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "Gender", "HeathStatus", "ImgLink", "LastUpdatedBy", "LastUpdatedTime", "OwnerId", "Size", "VarietyId", "Weight" },
                values: new object[,]
                {
                    { 1, "Koi Kohaku 01", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1471), null, null, "Cá Koi Kohaku với màu đỏ trắng đẹp mắt.", 1, "Healthy", "https://example.com/koi_kohaku_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1472), 1, 30, 1, 3 },
                    { 2, "Koi Sanke 01", new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1477), null, null, "Cá Koi Sanke với đốm đen và đỏ trên nền trắng.", 2, "Healthy", "https://example.com/koi_sanke_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1478), 2, 35, 2, 4 },
                    { 3, "Koi Showa 01", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1482), null, null, "Cá Koi Showa với các đốm đen đỏ nổi bật.", 1, "Sick", "https://example.com/koi_showa_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1483), 3, 32, 3, 3 },
                    { 4, "Koi Shiro Utsuri 01", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1486), null, null, "Cá Koi Shiro Utsuri với màu đen trắng.", 2, "Healthy", "https://example.com/koi_shiro_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1486), 1, 40, 4, 5 },
                    { 5, "Koi Hi Utsuri 01", new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1490), null, null, "Cá Koi Hi Utsuri với đốm đỏ tươi trên nền đen.", 1, "Healthy", "https://example.com/koi_hi_utsuri_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1490), 2, 37, 5, 4 },
                    { 6, "Koi Ki Utsuri 01", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1494), null, null, "Cá Koi Ki Utsuri với đốm vàng trên nền đen.", 2, "Sick", "https://example.com/koi_ki_utsuri_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1495), 3, 42, 6, 6 },
                    { 7, "Koi Asagi 01", new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1498), null, null, "Cá Koi Asagi với màu xanh và đỏ nhạt.", 1, "Healthy", "https://example.com/koi_asagi_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1499), 1, 38, 7, 3 },
                    { 8, "Koi Shusui 01", new DateTime(2020, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1502), null, null, "Cá Koi Shusui với các vảy lớn và màu sắc đẹp.", 2, "Healthy", "https://example.com/koi_shusui_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1503), 2, 36, 8, 4 },
                    { 9, "Koi Bekko 01", new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1507), null, null, "Cá Koi Bekko với các đốm đen trên nền trắng.", 1, "Sick", "https://example.com/koi_bekko_01.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1507), 3, 34, 9, 4 }
                });

            migrationBuilder.InsertData(
                table: "ContestResults",
                columns: new[] { "Id", "Category", "Comments", "ContestId", "ContestResultDescription", "ContestResultName", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "IsFinalized", "IsPublished", "LastUpdatedBy", "LastUpdatedTime", "Prize", "PrizeDescription", "Rank", "Status", "TotalScore" },
                values: new object[,]
                {
                    { 1, "Màu sắc", "Hình dáng hoàn hảo, màu sắc rực rỡ.", 1, "Giải nhất cho Koi có màu sắc và hình dáng xuất sắc.", "Kết quả cuộc thi Koi Đẹp Nhất", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1782), null, null, "Yes", "Yes", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1782), 1000, "Cúp vàng và 1000 USD", 1, "Final", 290.5 },
                    { 2, "Hình dáng", "Hình dáng tốt nhưng cần cải thiện về màu sắc.", 1, "Giải nhì cho Koi có hình dáng cân đối.", "Kết quả cuộc thi Koi Cân Đối Nhất", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1787), null, null, "Yes", "Yes", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1788), 500, "Cúp bạc và 500 USD", 2, "Final", 275.0 },
                    { 3, "Sáng tạo", "Koi có sự sáng tạo tuyệt vời về họa tiết và màu sắc.", 2, "Giải nhất cho Koi có sự kết hợp màu sắc độc đáo.", "Kết quả cuộc thi Koi Sáng Tạo", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1792), null, null, "Yes", "Yes", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1793), 1200, "Cúp vàng và 1200 USD", 1, "Final", 288.0 },
                    { 4, "Họa tiết", "Họa tiết ấn tượng nhưng cần cải thiện về màu sắc.", 2, "Giải nhì cho Koi có họa tiết độc đáo.", "Kết quả cuộc thi Koi Độc Đáo", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1796), null, null, "Yes", "No", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1797), 600, "Cúp bạc và 600 USD", 2, "Pending", 270.0 },
                    { 5, "Koi nhỏ", "Koi nhỏ nhưng rất hoàn thiện về mọi mặt.", 3, "Giải nhất cho Koi nhỏ có hình dáng và màu sắc hoàn hảo.", "Kết quả cuộc thi Koi Nhỏ Đẹp Nhất", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1800), null, null, "Yes", "Yes", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1801), 1500, "Cúp vàng và 1500 USD", 1, "Final", 295.5 },
                    { 6, "Độc lạ", "Có nhiều đặc điểm độc đáo nhưng màu sắc chưa đồng đều.", 3, "Giải nhì cho Koi có đặc điểm khác biệt.", "Kết quả cuộc thi Koi Độc Lạ", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1805), null, null, "Yes", "No", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1805), 800, "Cúp bạc và 800 USD", 2, "Pending", 282.0 },
                    { 7, "Hoàn hảo", "Koi gần như hoàn hảo, không có khuyết điểm nào đáng kể.", 4, "Giải nhất cho Koi hoàn thiện về cả màu sắc và hình dáng.", "Kết quả cuộc thi Koi Hoàn Hảo", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1808), null, null, "Yes", "Yes", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1809), 2000, "Cúp vàng và 2000 USD", 1, "Final", 299.0 },
                    { 8, "Màu sắc", "Màu sắc đồng đều nhưng hình dáng chưa hoàn thiện.", 4, "Giải nhì cho Koi có màu sắc đồng đều.", "Kết quả cuộc thi Koi Màu Sắc Tốt", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1813), null, null, "Yes", "No", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1814), 1000, "Cúp bạc và 1000 USD", 2, "Pending", 285.5 },
                    { 9, "Cân đối", "Hình dáng hoàn hảo, nhưng cần cải thiện họa tiết.", 5, "Giải nhất cho Koi cân đối về hình dáng.", "Kết quả cuộc thi Koi Cân Đối Nhất", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1817), null, null, "Yes", "Yes", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1818), 1700, "Cúp vàng và 1700 USD", 1, "Final", 293.0 }
                });

            migrationBuilder.InsertData(
                table: "RegisterForms",
                columns: new[] { "Id", "AnimalId", "ApprovalStatus", "CheckinStatus", "Color", "ContestId", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "EntryTitle", "HealthStatus", "Image", "LastUpdatedBy", "LastUpdatedTime", "Notes", "Pattern", "RegistrationDate", "Shape", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Approved", "Checked In", "Red", 1, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1628), null, null, "Koi Sắc Màu Đỏ", "Good", "https://example.com/koi_red.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1629), "Cá khỏe mạnh, nổi bật với màu sắc đỏ rực.", "Solid", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Round", "Active" },
                    { 2, 2, "Pending", "Checked In", "Black and White", 1, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1634), null, null, "Koi Trắng Đen", "Fair", "https://example.com/koi_black_white.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1635), "Cá có màu sắc hài hòa giữa trắng và đen.", "Mixed", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", "Active" },
                    { 3, 3, "Approved", "Checked In", "Yellow", 2, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1638), null, null, "Koi Vàng Óng", "Excellent", "https://example.com/koi_yellow.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1639), "Màu vàng óng ánh, thân hình cân đối.", "Solid", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slim", "Active" },
                    { 4, 4, "Pending", "Pending", "Orange", 2, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1643), null, null, "Koi Cam Nổi Bật", "Good", "https://example.com/koi_orange.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1644), "Cá Koi cam rực rỡ, độc đáo.", "Mixed", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Short", "Pending" },
                    { 5, 5, "Approved", "Checked In", "Black", 3, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1647), null, null, "Koi Đen Bóng", "Excellent", "https://example.com/koi_black.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1647), "Cá Koi với màu đen bóng khỏe mạnh.", "Solid", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Round", "Active" },
                    { 6, 6, "Approved", "Checked In", "Blue", 3, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1652), null, null, "Koi Xanh Biển", "Fair", "https://example.com/koi_blue.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1652), "Cá Koi có màu xanh biển đậm.", "Mixed", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slim", "Active" },
                    { 7, 7, "Pending", "Pending", "Gray", 4, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1656), null, null, "Koi Xám Khói", "Good", "https://example.com/koi_gray.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1656), "Màu xám khói độc đáo, cá có sức sống tốt.", "Solid", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long", "Pending" },
                    { 8, 8, "Approved", "Checked In", "Pink", 4, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1660), null, null, "Koi Hồng Nhẹ Nhàng", "Excellent", "https://example.com/koi_pink.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1660), "Cá Koi màu hồng phớt nhẹ nhàng.", "Mixed", new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Short", "Active" },
                    { 9, 9, "Approved", "Checked In", "Purple", 5, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1663), null, null, "Koi Tím Thủy Chung", "Fair", "https://example.com/koi_purple.jpg", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1664), "Màu tím độc đáo, thân hình cân đối.", "Solid", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Round", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "ActualCost", "CreatedBy", "CreatedTime", "Currency", "DeletedBy", "DeletedTime", "Description", "DiscountAmount", "FinalAmount", "LastUpdatedBy", "LastUpdatedTime", "PaymentAmount", "PaymentDate", "PaymentStatus", "RegisterFormId", "TransactionId", "Vatrate" },
                values: new object[,]
                {
                    { 1, 90.450000000000003, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1858), "USD", null, null, "Payment for registration form 1", 10.050000000000001, 100.5, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1858), 100.5, new DateTime(2024, 9, 22, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1849), "Completed", 1, "TXN123456789", 0.10000000000000001 },
                    { 2, 138.69, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1864), "USD", null, null, "Payment for registration form 2", 12.06, 150.75, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1865), 150.75, new DateTime(2024, 9, 24, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1862), "Pending", 2, "TXN123456790", 0.080000000000000002 },
                    { 3, 190.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1869), "USD", null, null, "Payment for registration form 3", 10.0, 200.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1870), 200.0, new DateTime(2024, 9, 26, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1867), "Completed", 3, "TXN123456791", 0.050000000000000003 },
                    { 4, 232.72999999999999, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1874), "USD", null, null, "Payment for registration form 4", 17.52, 250.25, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1875), 250.25, new DateTime(2024, 9, 28, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1872), "Failed", 4, "TXN123456792", 0.070000000000000007 },
                    { 5, 264.66000000000003, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1879), "USD", null, null, "Payment for registration form 5", 36.090000000000003, 300.75, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1879), 300.75, new DateTime(2024, 9, 30, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1877), "Completed", 5, "TXN123456793", 0.12 },
                    { 6, 315.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1884), "USD", null, null, "Payment for registration form 6", 35.0, 350.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1885), 350.0, new DateTime(2024, 10, 1, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1882), "Pending", 6, "TXN123456794", 0.10000000000000001 },
                    { 7, 340.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1889), "USD", null, null, "Payment for registration form 7", 60.0, 400.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1889), 400.0, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1887), "Completed", 7, "TXN123456795", 0.14999999999999999 },
                    { 8, 409.95999999999998, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1893), "USD", null, null, "Payment for registration form 8", 40.539999999999999, 450.5, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1894), 450.5, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1891), "Failed", 8, "TXN123456796", 0.089999999999999997 },
                    { 9, 400.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1898), "USD", null, null, "Payment for registration form 9", 100.0, 500.0, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1898), 500.0, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1896), "Completed", 9, "TXN123456797", 0.20000000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "ColorPoint", "Comment", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "JudgeRank", "JuryId", "LastUpdatedBy", "LastUpdatedTime", "PatternPoint", "Penalties", "PointStatus", "RegisterFormId", "ShapePoint", "TotalScore" },
                values: new object[,]
                {
                    { 1, 90, "Hình dáng cân đối, màu sắc nổi bật.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1693), null, null, "Expert", 1, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1693), 88, 0, 1, 1, 85, 263 },
                    { 2, 85, "Hình dáng ổn định, màu sắc hài hòa.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1698), null, null, "Intermediate", 2, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1699), 82, 1, 1, 2, 80, 246 },
                    { 3, 95, "Xuất sắc trong mọi khía cạnh.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1702), null, null, "Master", 3, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1702), 94, 0, 1, 3, 92, 281 },
                    { 4, 75, "Hình dáng tốt nhưng màu sắc cần cải thiện.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1706), null, null, "Novice", 4, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1706), 78, 2, 1, 4, 70, 221 },
                    { 5, 90, "Hình dáng và màu sắc đẹp, có vài khuyết điểm nhỏ.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1709), null, null, "Expert", 1, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1710), 85, 0, 1, 5, 88, 263 },
                    { 6, 88, "Màu sắc đẹp nhưng hình dáng còn chưa đồng đều.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1715), null, null, "Intermediate", 2, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1715), 86, 1, 1, 6, 83, 257 },
                    { 7, 97, "Hoàn hảo trong tất cả các yếu tố.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1719), null, null, "Master", 3, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1719), 96, 0, 1, 7, 95, 288 },
                    { 8, 80, "Hình dáng và màu sắc trung bình, cần cải thiện.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1722), null, null, "Novice", 4, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1723), 82, 3, 1, 8, 75, 234 },
                    { 9, 92, "Rất tốt, hình dáng và màu sắc gần như hoàn hảo.", null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1726), null, null, "Expert", 1, null, new DateTime(2024, 10, 2, 8, 48, 13, 411, DateTimeKind.Local).AddTicks(1727), 91, 0, 1, 9, 90, 273 }
                });

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "Accounts",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "Animals",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_OwnerId",
                table: "Animals",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_VarietyId",
                table: "Animals",
                column: "VarietyId");

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "ContestResults",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContestResults_ContestId",
                table: "ContestResults",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "Contests",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "News",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "Payments",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RegisterFormId",
                table: "Payments",
                column: "RegisterFormId");

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "Points",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Points_JuryId",
                table: "Points",
                column: "JuryId");

            migrationBuilder.CreateIndex(
                name: "IX_Points_RegisterFormId",
                table: "Points",
                column: "RegisterFormId");

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "RegisterForms",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegisterForms_AnimalId",
                table: "RegisterForms",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterForms_ContestId",
                table: "RegisterForms",
                column: "ContestId");

            migrationBuilder.CreateIndex(
                name: "Index_Id",
                table: "Varieties",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContestResults");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Points");

            migrationBuilder.DropTable(
                name: "RegisterForms");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Contests");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Varieties");
        }
    }
}
