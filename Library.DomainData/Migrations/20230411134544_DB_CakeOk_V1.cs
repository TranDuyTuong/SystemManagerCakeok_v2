using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DomainData.Migrations
{
    public partial class DB_CakeOk_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "T_BannerRotationLucks",
                columns: table => new
                {
                    IDBackRound = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeFile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BannerRotationLucks", x => x.IDBackRound);
                });

            migrationBuilder.CreateTable(
                name: "T_CakeElements",
                columns: table => new
                {
                    IDElement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flour = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sugar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Egg = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fruit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ElementOther = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CakeElements", x => x.IDElement);
                });

            migrationBuilder.CreateTable(
                name: "T_CakePrices",
                columns: table => new
                {
                    IDPrice = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PriceDiscount = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CakePrices", x => x.IDPrice);
                });

            migrationBuilder.CreateTable(
                name: "T_ChangePasswords",
                columns: table => new
                {
                    IDChange = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailRequest = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateRequest = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ChangePasswords", x => x.IDChange);
                });

            migrationBuilder.CreateTable(
                name: "T_CheckLoginLogouts",
                columns: table => new
                {
                    WorkingStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourWoking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CheckLoginLogouts", x => x.WorkingStart);
                });

            migrationBuilder.CreateTable(
                name: "T_Citys",
                columns: table => new
                {
                    IDCity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Citys", x => x.IDCity);
                });

            migrationBuilder.CreateTable(
                name: "T_Countrys",
                columns: table => new
                {
                    IDCountry = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Countrys", x => x.IDCountry);
                });

            migrationBuilder.CreateTable(
                name: "T_CustomerOrStaffs",
                columns: table => new
                {
                    IDCustomerOrStaff = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CustomerOrStaffs", x => x.IDCustomerOrStaff);
                });

            migrationBuilder.CreateTable(
                name: "T_DiscountCakes",
                columns: table => new
                {
                    IDDiscount = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PercentReduction = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    NameDiscount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DiscountCakes", x => x.IDDiscount);
                });

            migrationBuilder.CreateTable(
                name: "T_Genders",
                columns: table => new
                {
                    IDGender = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Genders", x => x.IDGender);
                });

            migrationBuilder.CreateTable(
                name: "T_GiftLucks",
                columns: table => new
                {
                    IDLuck = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameGift = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContentImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeFile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_GiftLucks", x => x.IDLuck);
                });

            migrationBuilder.CreateTable(
                name: "T_Gifts",
                columns: table => new
                {
                    IDGift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeFile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Gifts", x => x.IDGift);
                });

            migrationBuilder.CreateTable(
                name: "T_ImageBannerWebs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContentFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeImage = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ImageBannerWebs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_KindCakes",
                columns: table => new
                {
                    IDKindCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_KindCakes", x => x.IDKindCake);
                });

            migrationBuilder.CreateTable(
                name: "T_Marriages",
                columns: table => new
                {
                    IDMarriage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Marriages", x => x.IDMarriage);
                });

            migrationBuilder.CreateTable(
                name: "T_NewCakes",
                columns: table => new
                {
                    IDNewCake = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_NewCakes", x => x.IDNewCake);
                });

            migrationBuilder.CreateTable(
                name: "T_PayCustomCakes",
                columns: table => new
                {
                    IDPay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PayCustomCakes", x => x.IDPay);
                });

            migrationBuilder.CreateTable(
                name: "T_Positions",
                columns: table => new
                {
                    IDPosition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Positions", x => x.IDPosition);
                });

            migrationBuilder.CreateTable(
                name: "T_Regiones",
                columns: table => new
                {
                    IDRegion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Regiones", x => x.IDRegion);
                });

            migrationBuilder.CreateTable(
                name: "T_Roles",
                columns: table => new
                {
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameRole = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Discripttion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Roles", x => x.IDRole);
                });

            migrationBuilder.CreateTable(
                name: "T_SizeCakes",
                columns: table => new
                {
                    IDSize = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSize = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SizeCakes", x => x.IDSize);
                });

            migrationBuilder.CreateTable(
                name: "T_SmellCakes",
                columns: table => new
                {
                    IDSmell = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_SmellCakes", x => x.IDSmell);
                });

            migrationBuilder.CreateTable(
                name: "T_StaffOrChefs",
                columns: table => new
                {
                    IDStaffOrChef = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_StaffOrChefs", x => x.IDStaffOrChef);
                });

            migrationBuilder.CreateTable(
                name: "T_StatusCakes",
                columns: table => new
                {
                    IDStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_StatusCakes", x => x.IDStatus);
                });

            migrationBuilder.CreateTable(
                name: "T_StatusCustomCakes",
                columns: table => new
                {
                    IDStatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_StatusCustomCakes", x => x.IDStatus);
                });

            migrationBuilder.CreateTable(
                name: "T_StatusIdeas",
                columns: table => new
                {
                    IDStatusIdea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_StatusIdeas", x => x.IDStatusIdea);
                });

            migrationBuilder.CreateTable(
                name: "T_StatusOrders",
                columns: table => new
                {
                    IDStatusOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PesentProgess = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_StatusOrders", x => x.IDStatusOrder);
                });

            migrationBuilder.CreateTable(
                name: "T_TokenLogins",
                columns: table => new
                {
                    IDToken = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailLogin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TokenLogins", x => x.IDToken);
                });

            migrationBuilder.CreateTable(
                name: "T_TypeAddreses",
                columns: table => new
                {
                    IDTypeAddress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TypeAddreses", x => x.IDTypeAddress);
                });

            migrationBuilder.CreateTable(
                name: "T_TypeCakes",
                columns: table => new
                {
                    IDTypeCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TypeCakes", x => x.IDTypeCake);
                });

            migrationBuilder.CreateTable(
                name: "T_TypePayCustomCakes",
                columns: table => new
                {
                    IDTypePay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TypePayCustomCakes", x => x.IDTypePay);
                });

            migrationBuilder.CreateTable(
                name: "T_TypePays",
                columns: table => new
                {
                    IDPay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamePay = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TypePays", x => x.IDPay);
                });

            migrationBuilder.CreateTable(
                name: "T_UrlManagerCustomCakes",
                columns: table => new
                {
                    IDUrl = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_UrlManagerCustomCakes", x => x.IDUrl);
                });

            migrationBuilder.CreateTable(
                name: "T_Vochers",
                columns: table => new
                {
                    IDVocher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameVocher = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PercenReduction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Vochers", x => x.IDVocher);
                });

            migrationBuilder.CreateTable(
                name: "T_Districts",
                columns: table => new
                {
                    IDDistrict = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDCity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Districts", x => x.IDDistrict);
                    table.ForeignKey(
                        name: "FK_T_Districts_T_Citys_IDCity",
                        column: x => x.IDCity,
                        principalTable: "T_Citys",
                        principalColumn: "IDCity");
                });

            migrationBuilder.CreateTable(
                name: "T_Users",
                columns: table => new
                {
                    IDAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PassWord = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDCustomerOrStaff = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Users", x => x.IDAccount);
                    table.ForeignKey(
                        name: "FK_T_Users_T_CustomerOrStaffs_IDCustomerOrStaff",
                        column: x => x.IDCustomerOrStaff,
                        principalTable: "T_CustomerOrStaffs",
                        principalColumn: "IDCustomerOrStaff");
                });

            migrationBuilder.CreateTable(
                name: "T_RotationLucks",
                columns: table => new
                {
                    IDRotation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PercentPage = table.Column<double>(type: "float", nullable: false),
                    IDLuck = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_RotationLucks", x => x.IDRotation);
                    table.ForeignKey(
                        name: "FK_T_RotationLucks_T_GiftLucks_IDLuck",
                        column: x => x.IDLuck,
                        principalTable: "T_GiftLucks",
                        principalColumn: "IDLuck");
                });

            migrationBuilder.CreateTable(
                name: "T_InformationAuthors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContentImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    NameImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeFile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IDPosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_InformationAuthors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_InformationAuthors_T_Positions_IDPosition",
                        column: x => x.IDPosition,
                        principalTable: "T_Positions",
                        principalColumn: "IDPosition");
                });

            migrationBuilder.CreateTable(
                name: "T_Cakes",
                columns: table => new
                {
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoCake = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NameCake = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    View = table.Column<int>(type: "int", nullable: false),
                    Buy = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    IDKindCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDStatus = table.Column<int>(type: "int", nullable: false),
                    IDNewCake = table.Column<int>(type: "int", nullable: false),
                    IDPrice = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDTypeCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDDiscount = table.Column<int>(type: "int", nullable: false),
                    IDElement = table.Column<int>(type: "int", nullable: false),
                    IDSmell = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cakes", x => x.IDCake);
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_CakeElements_IDElement",
                        column: x => x.IDElement,
                        principalTable: "T_CakeElements",
                        principalColumn: "IDElement");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_CakePrices_IDPrice",
                        column: x => x.IDPrice,
                        principalTable: "T_CakePrices",
                        principalColumn: "IDPrice");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_DiscountCakes_IDDiscount",
                        column: x => x.IDDiscount,
                        principalTable: "T_DiscountCakes",
                        principalColumn: "IDDiscount");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_KindCakes_IDKindCake",
                        column: x => x.IDKindCake,
                        principalTable: "T_KindCakes",
                        principalColumn: "IDKindCake");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_NewCakes_IDNewCake",
                        column: x => x.IDNewCake,
                        principalTable: "T_NewCakes",
                        principalColumn: "IDNewCake");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_SmellCakes_IDSmell",
                        column: x => x.IDSmell,
                        principalTable: "T_SmellCakes",
                        principalColumn: "IDSmell");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_StatusCakes_IDStatus",
                        column: x => x.IDStatus,
                        principalTable: "T_StatusCakes",
                        principalColumn: "IDStatus");
                    table.ForeignKey(
                        name: "FK_T_Cakes_T_TypeCakes_IDTypeCake",
                        column: x => x.IDTypeCake,
                        principalTable: "T_TypeCakes",
                        principalColumn: "IDTypeCake");
                });

            migrationBuilder.CreateTable(
                name: "T_Branchs",
                columns: table => new
                {
                    IDBrach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TimeWorking = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IDRegion = table.Column<int>(type: "int", nullable: false),
                    IDCity = table.Column<int>(type: "int", nullable: false),
                    IDDistrict = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Branchs", x => x.IDBrach);
                    table.ForeignKey(
                        name: "FK_T_Branchs_T_Citys_IDCity",
                        column: x => x.IDCity,
                        principalTable: "T_Citys",
                        principalColumn: "IDCity");
                    table.ForeignKey(
                        name: "FK_T_Branchs_T_Districts_IDDistrict",
                        column: x => x.IDDistrict,
                        principalTable: "T_Districts",
                        principalColumn: "IDDistrict");
                    table.ForeignKey(
                        name: "FK_T_Branchs_T_Regiones_IDRegion",
                        column: x => x.IDRegion,
                        principalTable: "T_Regiones",
                        principalColumn: "IDRegion");
                });

            migrationBuilder.CreateTable(
                name: "T_Customers",
                columns: table => new
                {
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContentFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MimeFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeFile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDCity = table.Column<int>(type: "int", nullable: false),
                    IDDistrict = table.Column<int>(type: "int", nullable: false),
                    IDGender = table.Column<int>(type: "int", nullable: false),
                    IDCountry = table.Column<int>(type: "int", nullable: false),
                    IDCustomerOrStaff = table.Column<int>(type: "int", nullable: false),
                    IDAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Customers", x => x.IDUser);
                    table.ForeignKey(
                        name: "FK_T_Customers_T_Citys_IDCity",
                        column: x => x.IDCity,
                        principalTable: "T_Citys",
                        principalColumn: "IDCity");
                    table.ForeignKey(
                        name: "FK_T_Customers_T_Countrys_IDCountry",
                        column: x => x.IDCountry,
                        principalTable: "T_Countrys",
                        principalColumn: "IDCountry");
                    table.ForeignKey(
                        name: "FK_T_Customers_T_CustomerOrStaffs_IDCustomerOrStaff",
                        column: x => x.IDCustomerOrStaff,
                        principalTable: "T_CustomerOrStaffs",
                        principalColumn: "IDCustomerOrStaff");
                    table.ForeignKey(
                        name: "FK_T_Customers_T_Districts_IDDistrict",
                        column: x => x.IDDistrict,
                        principalTable: "T_Districts",
                        principalColumn: "IDDistrict");
                    table.ForeignKey(
                        name: "FK_T_Customers_T_Genders_IDGender",
                        column: x => x.IDGender,
                        principalTable: "T_Genders",
                        principalColumn: "IDGender");
                    table.ForeignKey(
                        name: "FK_T_Customers_T_Users_IDAccount",
                        column: x => x.IDAccount,
                        principalTable: "T_Users",
                        principalColumn: "IDAccount");
                });

            migrationBuilder.CreateTable(
                name: "T_Staffs",
                columns: table => new
                {
                    IDStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "Nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IDCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContentFile = table.Column<string>(type: "Nvarchar(MAX)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDMarriage = table.Column<int>(type: "int", nullable: false),
                    IDAccount = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCustomerOrStaff = table.Column<int>(type: "int", nullable: false),
                    IDCity = table.Column<int>(type: "int", nullable: false),
                    IDDistrict = table.Column<int>(type: "int", nullable: false),
                    IDGender = table.Column<int>(type: "int", nullable: false),
                    IDStaffOrChef = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Staffs", x => x.IDStaff);
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_Citys_IDCity",
                        column: x => x.IDCity,
                        principalTable: "T_Citys",
                        principalColumn: "IDCity");
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_CustomerOrStaffs_IDCustomerOrStaff",
                        column: x => x.IDCustomerOrStaff,
                        principalTable: "T_CustomerOrStaffs",
                        principalColumn: "IDCustomerOrStaff");
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_Districts_IDDistrict",
                        column: x => x.IDDistrict,
                        principalTable: "T_Districts",
                        principalColumn: "IDDistrict");
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_Genders_IDGender",
                        column: x => x.IDGender,
                        principalTable: "T_Genders",
                        principalColumn: "IDGender");
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_Marriages_IDMarriage",
                        column: x => x.IDMarriage,
                        principalTable: "T_Marriages",
                        principalColumn: "IDMarriage");
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_StaffOrChefs_IDStaffOrChef",
                        column: x => x.IDStaffOrChef,
                        principalTable: "T_StaffOrChefs",
                        principalColumn: "IDStaffOrChef");
                    table.ForeignKey(
                        name: "FK_T_Staffs_T_Users_IDAccount",
                        column: x => x.IDAccount,
                        principalTable: "T_Users",
                        principalColumn: "IDAccount");
                });

            migrationBuilder.CreateTable(
                name: "T_CakeGifts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CakeGifts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_CakeGifts_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_CakeGifts_T_Gifts_IDGift",
                        column: x => x.IDGift,
                        principalTable: "T_Gifts",
                        principalColumn: "IDGift");
                });

            migrationBuilder.CreateTable(
                name: "T_CakeImages",
                columns: table => new
                {
                    IDImage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeImage = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MainImage = table.Column<bool>(type: "bit", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CakeImages", x => x.IDImage);
                    table.ForeignKey(
                        name: "FK_T_CakeImages_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                });

            migrationBuilder.CreateTable(
                name: "T_InfomationOrders",
                columns: table => new
                {
                    IDInfomationOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameCustomer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailCustomer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneCustomer = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExpecteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteCustomer = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    IDCity = table.Column<int>(type: "int", nullable: false),
                    IDDistrict = table.Column<int>(type: "int", nullable: false),
                    IDBrach = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_InfomationOrders", x => x.IDInfomationOrder);
                    table.ForeignKey(
                        name: "FK_T_InfomationOrders_T_Branchs_IDBrach",
                        column: x => x.IDBrach,
                        principalTable: "T_Branchs",
                        principalColumn: "IDBrach");
                    table.ForeignKey(
                        name: "FK_T_InfomationOrders_T_Citys_IDCity",
                        column: x => x.IDCity,
                        principalTable: "T_Citys",
                        principalColumn: "IDCity");
                    table.ForeignKey(
                        name: "FK_T_InfomationOrders_T_Districts_IDDistrict",
                        column: x => x.IDDistrict,
                        principalTable: "T_Districts",
                        principalColumn: "IDDistrict");
                });

            migrationBuilder.CreateTable(
                name: "T_AddressUserDefauls",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDTypeAddress = table.Column<int>(type: "int", nullable: false),
                    IDCity = table.Column<int>(type: "int", nullable: false),
                    IDDistrict = table.Column<int>(type: "int", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_AddressUserDefauls", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_AddressUserDefauls_T_Citys_IDCity",
                        column: x => x.IDCity,
                        principalTable: "T_Citys",
                        principalColumn: "IDCity");
                    table.ForeignKey(
                        name: "FK_T_AddressUserDefauls_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_AddressUserDefauls_T_Districts_IDDistrict",
                        column: x => x.IDDistrict,
                        principalTable: "T_Districts",
                        principalColumn: "IDDistrict");
                    table.ForeignKey(
                        name: "FK_T_AddressUserDefauls_T_TypeAddreses_IDTypeAddress",
                        column: x => x.IDTypeAddress,
                        principalTable: "T_TypeAddreses",
                        principalColumn: "IDTypeAddress");
                });

            migrationBuilder.CreateTable(
                name: "T_CakeCustomIdeas",
                columns: table => new
                {
                    IDIdea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDTypeCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSize = table.Column<int>(type: "int", nullable: false),
                    IDStatusIdea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CakeCustomIdeas", x => x.IDIdea);
                    table.ForeignKey(
                        name: "FK_T_CakeCustomIdeas_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_CakeCustomIdeas_T_SizeCakes_IDSize",
                        column: x => x.IDSize,
                        principalTable: "T_SizeCakes",
                        principalColumn: "IDSize");
                    table.ForeignKey(
                        name: "FK_T_CakeCustomIdeas_T_StatusIdeas_IDStatusIdea",
                        column: x => x.IDStatusIdea,
                        principalTable: "T_StatusIdeas",
                        principalColumn: "IDStatusIdea");
                    table.ForeignKey(
                        name: "FK_T_CakeCustomIdeas_T_TypeCakes_IDTypeCake",
                        column: x => x.IDTypeCake,
                        principalTable: "T_TypeCakes",
                        principalColumn: "IDTypeCake");
                });

            migrationBuilder.CreateTable(
                name: "T_CartUsers",
                columns: table => new
                {
                    IDCart = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CartUsers", x => x.IDCart);
                    table.ForeignKey(
                        name: "FK_T_CartUsers_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_CartUsers_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_Comments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_Comments_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_Comments_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_HistoryGetGiftUserRotaionLucks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDLuck = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_HistoryGetGiftUserRotaionLucks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_HistoryGetGiftUserRotaionLucks_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_HistoryGetGiftUserRotaionLucks_T_GiftLucks_IDLuck",
                        column: x => x.IDLuck,
                        principalTable: "T_GiftLucks",
                        principalColumn: "IDLuck");
                });

            migrationBuilder.CreateTable(
                name: "T_HistorySeachUsers",
                columns: table => new
                {
                    IdSeach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeachName = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_HistorySeachUsers", x => x.IdSeach);
                    table.ForeignKey(
                        name: "FK_T_HistorySeachUsers_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_HistoryTurnRotaionLucks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    t_CustomerIDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_HistoryTurnRotaionLucks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_HistoryTurnRotaionLucks_T_Customers_t_CustomerIDUser",
                        column: x => x.t_CustomerIDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_HistoryUserGetVochers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    StatusUseVocher = table.Column<bool>(type: "bit", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVocher = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_HistoryUserGetVochers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_HistoryUserGetVochers_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_HistoryUserGetVochers_T_Vochers_IDVocher",
                        column: x => x.IDVocher,
                        principalTable: "T_Vochers",
                        principalColumn: "IDVocher");
                });

            migrationBuilder.CreateTable(
                name: "T_HistoryUseVochers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDVocher = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_HistoryUseVochers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_HistoryUseVochers_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_HistoryUseVochers_T_Vochers_IDVocher",
                        column: x => x.IDVocher,
                        principalTable: "T_Vochers",
                        principalColumn: "IDVocher");
                });

            migrationBuilder.CreateTable(
                name: "T_Ratings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Ratings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_Ratings_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_Ratings_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_RatingWebsites",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_RatingWebsites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_RatingWebsites_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_TakeTurnsRotaionLucks",
                columns: table => new
                {
                    IDTurns = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountTakeTurn = table.Column<int>(type: "int", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TakeTurnsRotaionLucks", x => x.IDTurns);
                    table.ForeignKey(
                        name: "FK_T_TakeTurnsRotaionLucks_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_ViewerCakeUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ViewerCakeUsers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_ViewerCakeUsers_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_ViewerCakeUsers_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_Chefs",
                columns: table => new
                {
                    IDChef = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoChef = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    IDStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Chefs", x => x.IDChef);
                    table.ForeignKey(
                        name: "FK_T_Chefs_T_Staffs_IDStaff",
                        column: x => x.IDStaff,
                        principalTable: "T_Staffs",
                        principalColumn: "IDStaff");
                });

            migrationBuilder.CreateTable(
                name: "T_UserRoles",
                columns: table => new
                {
                    IDUserRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IDRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_UserRoles", x => x.IDUserRole);
                    table.ForeignKey(
                        name: "FK_T_UserRoles_T_Roles_IDRole",
                        column: x => x.IDRole,
                        principalTable: "T_Roles",
                        principalColumn: "IDRole");
                    table.ForeignKey(
                        name: "FK_T_UserRoles_T_Staffs_IDStaff",
                        column: x => x.IDStaff,
                        principalTable: "T_Staffs",
                        principalColumn: "IDStaff");
                });

            migrationBuilder.CreateTable(
                name: "T_Orders",
                columns: table => new
                {
                    IDOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UseVocher = table.Column<bool>(type: "bit", nullable: false),
                    CancelOrder = table.Column<bool>(type: "bit", nullable: false),
                    PercentReduction = table.Column<int>(type: "int", nullable: true),
                    IDInfomationOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDPay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDStatusOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Orders", x => x.IDOrder);
                    table.ForeignKey(
                        name: "FK_T_Orders_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_Orders_T_InfomationOrders_IDInfomationOrder",
                        column: x => x.IDInfomationOrder,
                        principalTable: "T_InfomationOrders",
                        principalColumn: "IDInfomationOrder");
                    table.ForeignKey(
                        name: "FK_T_Orders_T_StatusOrders_IDStatusOrder",
                        column: x => x.IDStatusOrder,
                        principalTable: "T_StatusOrders",
                        principalColumn: "IDStatusOrder");
                    table.ForeignKey(
                        name: "FK_T_Orders_T_TypePays_IDPay",
                        column: x => x.IDPay,
                        principalTable: "T_TypePays",
                        principalColumn: "IDPay");
                });

            migrationBuilder.CreateTable(
                name: "T_ImageCustomIdeas",
                columns: table => new
                {
                    IDImageCustom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeImage = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDIdea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ImageCustomIdeas", x => x.IDImageCustom);
                    table.ForeignKey(
                        name: "FK_T_ImageCustomIdeas_T_CakeCustomIdeas_IDIdea",
                        column: x => x.IDIdea,
                        principalTable: "T_CakeCustomIdeas",
                        principalColumn: "IDIdea");
                });

            migrationBuilder.CreateTable(
                name: "T_NotificationCustomCakes",
                columns: table => new
                {
                    IDNotification = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDIdea = table.Column<int>(type: "int", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_NotificationCustomCakes", x => x.IDNotification);
                    table.ForeignKey(
                        name: "FK_T_NotificationCustomCakes_T_CakeCustomIdeas_IDIdea",
                        column: x => x.IDIdea,
                        principalTable: "T_CakeCustomIdeas",
                        principalColumn: "IDIdea");
                    table.ForeignKey(
                        name: "FK_T_NotificationCustomCakes_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                });

            migrationBuilder.CreateTable(
                name: "T_ChefCakes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDChef = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ChefCakes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_ChefCakes_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_ChefCakes_T_Chefs_IDChef",
                        column: x => x.IDChef,
                        principalTable: "T_Chefs",
                        principalColumn: "IDChef");
                });

            migrationBuilder.CreateTable(
                name: "T_CustomCakes",
                columns: table => new
                {
                    IDCustom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoCustom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameCustom = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IDUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDStatus = table.Column<int>(type: "int", nullable: false),
                    IDPay = table.Column<int>(type: "int", nullable: false),
                    IDIdea = table.Column<int>(type: "int", nullable: false),
                    IDChef = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CustomCakes", x => x.IDCustom);
                    table.ForeignKey(
                        name: "FK_T_CustomCakes_T_CakeCustomIdeas_IDIdea",
                        column: x => x.IDIdea,
                        principalTable: "T_CakeCustomIdeas",
                        principalColumn: "IDIdea");
                    table.ForeignKey(
                        name: "FK_T_CustomCakes_T_Chefs_IDChef",
                        column: x => x.IDChef,
                        principalTable: "T_Chefs",
                        principalColumn: "IDChef");
                    table.ForeignKey(
                        name: "FK_T_CustomCakes_T_Customers_IDUser",
                        column: x => x.IDUser,
                        principalTable: "T_Customers",
                        principalColumn: "IDUser");
                    table.ForeignKey(
                        name: "FK_T_CustomCakes_T_PayCustomCakes_IDPay",
                        column: x => x.IDPay,
                        principalTable: "T_PayCustomCakes",
                        principalColumn: "IDPay");
                    table.ForeignKey(
                        name: "FK_T_CustomCakes_T_StatusCustomCakes_IDStatus",
                        column: x => x.IDStatus,
                        principalTable: "T_StatusCustomCakes",
                        principalColumn: "IDStatus");
                });

            migrationBuilder.CreateTable(
                name: "T_CancelOrders",
                columns: table => new
                {
                    IDCancel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CancelOrders", x => x.IDCancel);
                    table.ForeignKey(
                        name: "FK_T_CancelOrders_T_Orders_IDOrder",
                        column: x => x.IDOrder,
                        principalTable: "T_Orders",
                        principalColumn: "IDOrder");
                });

            migrationBuilder.CreateTable(
                name: "T_OrderDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quatity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    IDStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDOrder = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDCake = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDGift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSmell = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_OrderDetails_T_Cakes_IDCake",
                        column: x => x.IDCake,
                        principalTable: "T_Cakes",
                        principalColumn: "IDCake");
                    table.ForeignKey(
                        name: "FK_T_OrderDetails_T_Gifts_IDGift",
                        column: x => x.IDGift,
                        principalTable: "T_Gifts",
                        principalColumn: "IDGift");
                    table.ForeignKey(
                        name: "FK_T_OrderDetails_T_Orders_IDOrder",
                        column: x => x.IDOrder,
                        principalTable: "T_Orders",
                        principalColumn: "IDOrder");
                    table.ForeignKey(
                        name: "FK_T_OrderDetails_T_SmellCakes_IDSmell",
                        column: x => x.IDSmell,
                        principalTable: "T_SmellCakes",
                        principalColumn: "IDSmell");
                    table.ForeignKey(
                        name: "FK_T_OrderDetails_T_Staffs_IDStaff",
                        column: x => x.IDStaff,
                        principalTable: "T_Staffs",
                        principalColumn: "IDStaff");
                });

            migrationBuilder.CreateTable(
                name: "T_CustomCakePrices",
                columns: table => new
                {
                    IDPriceCustom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDCustom = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CustomCakePrices", x => x.IDPriceCustom);
                    table.ForeignKey(
                        name: "FK_T_CustomCakePrices_T_CustomCakes_IDCustom",
                        column: x => x.IDCustom,
                        principalTable: "T_CustomCakes",
                        principalColumn: "IDCustom");
                });

            migrationBuilder.CreateTable(
                name: "T_BillCakeCustoms",
                columns: table => new
                {
                    IDBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AmountCake = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    IDPriceCustom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDPay = table.Column<int>(type: "int", nullable: false),
                    IDTypePay = table.Column<int>(type: "int", nullable: false),
                    IDCustom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDStaff = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BillCakeCustoms", x => x.IDBill);
                    table.ForeignKey(
                        name: "FK_T_BillCakeCustoms_T_CustomCakePrices_IDPriceCustom",
                        column: x => x.IDPriceCustom,
                        principalTable: "T_CustomCakePrices",
                        principalColumn: "IDPriceCustom");
                    table.ForeignKey(
                        name: "FK_T_BillCakeCustoms_T_CustomCakes_IDCustom",
                        column: x => x.IDCustom,
                        principalTable: "T_CustomCakes",
                        principalColumn: "IDCustom");
                    table.ForeignKey(
                        name: "FK_T_BillCakeCustoms_T_PayCustomCakes_IDPay",
                        column: x => x.IDPay,
                        principalTable: "T_PayCustomCakes",
                        principalColumn: "IDPay");
                    table.ForeignKey(
                        name: "FK_T_BillCakeCustoms_T_Staffs_IDStaff",
                        column: x => x.IDStaff,
                        principalTable: "T_Staffs",
                        principalColumn: "IDStaff");
                    table.ForeignKey(
                        name: "FK_T_BillCakeCustoms_T_TypePayCustomCakes_IDTypePay",
                        column: x => x.IDTypePay,
                        principalTable: "T_TypePayCustomCakes",
                        principalColumn: "IDTypePay");
                });

            migrationBuilder.InsertData(
                table: "T_Citys",
                columns: new[] { "IDCity", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Tp.Hcm", true },
                    { 2, "Tp.Hà Nội", true },
                    { 3, "Tp.Đà Lạt", true },
                    { 4, "Tp.Cần Thơ", true },
                    { 5, "Tp.Long Xuyên", true },
                    { 6, "Tp.Long Khánh", true },
                    { 7, "Tp.Huế", true }
                });

            migrationBuilder.InsertData(
                table: "T_Countrys",
                columns: new[] { "IDCountry", "CreateDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2769), "Việt Nam", true },
                    { 2, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2772), "Lào", true },
                    { 3, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2774), "Campuchia", true },
                    { 4, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2775), "Thái Lan", true }
                });

            migrationBuilder.InsertData(
                table: "T_CustomerOrStaffs",
                columns: new[] { "IDCustomerOrStaff", "CreateDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2888), "Khách Hàng" },
                    { 2, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2890), "Nhân Viên" }
                });

            migrationBuilder.InsertData(
                table: "T_Genders",
                columns: new[] { "IDGender", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Nam", true },
                    { 2, "Nữ", true }
                });

            migrationBuilder.InsertData(
                table: "T_Marriages",
                columns: new[] { "IDMarriage", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Độc Thân", true },
                    { 2, "Đã Kết Hôn", true },
                    { 3, "Đã Ly Hôn", true }
                });

            migrationBuilder.InsertData(
                table: "T_Roles",
                columns: new[] { "IDRole", "ConcurrencyStamp", "CreateDate", "Discripttion", "Id", "Name", "NameRole", "NormalizedName", "Symbol" },
                values: new object[] { new Guid("d6e0ac8a-7eed-4865-a6f0-3f5a8ba60bdc"), null, new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2978), "Admin Quản Lý Toàn Bộ Hệ Thống", new Guid("00000000-0000-0000-0000-000000000000"), null, "Admin", null, "AD" });

            migrationBuilder.InsertData(
                table: "T_StaffOrChefs",
                columns: new[] { "IDStaffOrChef", "CreateDate", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("b9c709e5-0ae2-4ca2-b5b1-1c6509fba56c"), new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2944), "Nhân Viên Hỗ Trợ", true },
                    { new Guid("fb0ad9bd-9be3-4557-ac8b-1001d48ec3b5"), new DateTime(2023, 4, 11, 13, 45, 43, 957, DateTimeKind.Utc).AddTicks(2945), "Đầu Bếp Làm Bánh", true }
                });

            migrationBuilder.InsertData(
                table: "T_Districts",
                columns: new[] { "IDDistrict", "IDCity", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, "Quận 1", true },
                    { 2, 1, "Quận 2", true },
                    { 3, 1, "Quận 3", true },
                    { 4, 2, "Huyện Ba Vì", true },
                    { 5, 6, "Huyện Xuân Lộc", true }
                });

            migrationBuilder.InsertData(
                table: "T_Users",
                columns: new[] { "IDAccount", "AccessFailedCount", "ConcurrencyStamp", "CreateDate", "Email", "EmailConfirmed", "IDCustomerOrStaff", "Id", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PassWord", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("723d5b79-51fa-45d1-8ed3-14c53580110f"), 0, "cbf4dc3f-f707-4ccf-9afe-8f70e63a09a1", new DateTime(2023, 4, 11, 13, 45, 44, 199, DateTimeKind.Utc).AddTicks(9315), "duytuong0503@gmail.com", true, 2, new Guid("723d5b79-51fa-45d1-8ed3-14c53580110f"), false, null, null, null, "AQAAAAIAAYagAAAAENMP2QN/QtvqWXBaX3OcRx5wKJ0mJkUW5DqAp+kNJ6PLFk4CzsyTz/Od6cWrqPAxcg==", "AQAAAAIAAYagAAAAENaw3AkEMcgtCDmM4XMa8PKlVb+wQtc9Ipc8Xjqu+BW0uGsoSyeWhDNm1cWsDJTMoA==", "0335520146", false, null, false, "duytuong0503@gmail.com" });

            migrationBuilder.InsertData(
                table: "T_Staffs",
                columns: new[] { "IDStaff", "Address", "Birthday", "ContentFile", "CreateDate", "FileName", "FullName", "IDAccount", "IDCity", "IDCode", "IDCustomerOrStaff", "IDDistrict", "IDGender", "IDMarriage", "IDStaffOrChef", "MimeType", "Phone", "TypeImage" },
                values: new object[] { new Guid("d8b14017-6271-4f1c-8c50-c06b06fcd28b"), "Khu 13, Xã Long Đức, Huyện Long Thành, Tỉnh Đồng Nai", new DateTime(2000, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 4, 11, 13, 45, 44, 199, DateTimeKind.Utc).AddTicks(9822), null, "Trần Duy Tường", new Guid("723d5b79-51fa-45d1-8ed3-14c53580110f"), 1, "ID1/1/0001 12:00:00 AM110335520146", 2, 1, 1, 1, new Guid("b9c709e5-0ae2-4ca2-b5b1-1c6509fba56c"), null, "0335520146", null });

            migrationBuilder.InsertData(
                table: "T_UserRoles",
                columns: new[] { "IDUserRole", "CreateDate", "IDRole", "IDStaff", "Status" },
                values: new object[] { 1, new DateTime(2023, 4, 11, 13, 45, 44, 199, DateTimeKind.Utc).AddTicks(9866), new Guid("d6e0ac8a-7eed-4865-a6f0-3f5a8ba60bdc"), new Guid("d8b14017-6271-4f1c-8c50-c06b06fcd28b"), true });

            migrationBuilder.CreateIndex(
                name: "IX_T_AddressUserDefauls_IDCity",
                table: "T_AddressUserDefauls",
                column: "IDCity");

            migrationBuilder.CreateIndex(
                name: "IX_T_AddressUserDefauls_IDDistrict",
                table: "T_AddressUserDefauls",
                column: "IDDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_T_AddressUserDefauls_IDTypeAddress",
                table: "T_AddressUserDefauls",
                column: "IDTypeAddress");

            migrationBuilder.CreateIndex(
                name: "IX_T_AddressUserDefauls_IDUser",
                table: "T_AddressUserDefauls",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_BillCakeCustoms_IDCustom",
                table: "T_BillCakeCustoms",
                column: "IDCustom");

            migrationBuilder.CreateIndex(
                name: "IX_T_BillCakeCustoms_IDPay",
                table: "T_BillCakeCustoms",
                column: "IDPay");

            migrationBuilder.CreateIndex(
                name: "IX_T_BillCakeCustoms_IDPriceCustom",
                table: "T_BillCakeCustoms",
                column: "IDPriceCustom");

            migrationBuilder.CreateIndex(
                name: "IX_T_BillCakeCustoms_IDStaff",
                table: "T_BillCakeCustoms",
                column: "IDStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_BillCakeCustoms_IDTypePay",
                table: "T_BillCakeCustoms",
                column: "IDTypePay");

            migrationBuilder.CreateIndex(
                name: "IX_T_Branchs_IDCity",
                table: "T_Branchs",
                column: "IDCity");

            migrationBuilder.CreateIndex(
                name: "IX_T_Branchs_IDDistrict",
                table: "T_Branchs",
                column: "IDDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_T_Branchs_IDRegion",
                table: "T_Branchs",
                column: "IDRegion");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeCustomIdeas_IDSize",
                table: "T_CakeCustomIdeas",
                column: "IDSize");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeCustomIdeas_IDStatusIdea",
                table: "T_CakeCustomIdeas",
                column: "IDStatusIdea");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeCustomIdeas_IDTypeCake",
                table: "T_CakeCustomIdeas",
                column: "IDTypeCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeCustomIdeas_IDUser",
                table: "T_CakeCustomIdeas",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeGifts_IDCake",
                table: "T_CakeGifts",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeGifts_IDGift",
                table: "T_CakeGifts",
                column: "IDGift");

            migrationBuilder.CreateIndex(
                name: "IX_T_CakeImages_IDCake",
                table: "T_CakeImages",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDDiscount",
                table: "T_Cakes",
                column: "IDDiscount");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDElement",
                table: "T_Cakes",
                column: "IDElement");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDKindCake",
                table: "T_Cakes",
                column: "IDKindCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDNewCake",
                table: "T_Cakes",
                column: "IDNewCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDPrice",
                table: "T_Cakes",
                column: "IDPrice");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDSmell",
                table: "T_Cakes",
                column: "IDSmell");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDStatus",
                table: "T_Cakes",
                column: "IDStatus");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cakes_IDTypeCake",
                table: "T_Cakes",
                column: "IDTypeCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_CancelOrders_IDOrder",
                table: "T_CancelOrders",
                column: "IDOrder");

            migrationBuilder.CreateIndex(
                name: "IX_T_CartUsers_IDCake",
                table: "T_CartUsers",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_CartUsers_IDUser",
                table: "T_CartUsers",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_ChefCakes_IDCake",
                table: "T_ChefCakes",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_ChefCakes_IDChef",
                table: "T_ChefCakes",
                column: "IDChef");

            migrationBuilder.CreateIndex(
                name: "IX_T_Chefs_IDStaff",
                table: "T_Chefs",
                column: "IDStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_Comments_IDCake",
                table: "T_Comments",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_Comments_IDUser",
                table: "T_Comments",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_CustomCakePrices_IDCustom",
                table: "T_CustomCakePrices",
                column: "IDCustom");

            migrationBuilder.CreateIndex(
                name: "IX_T_CustomCakes_IDChef",
                table: "T_CustomCakes",
                column: "IDChef");

            migrationBuilder.CreateIndex(
                name: "IX_T_CustomCakes_IDIdea",
                table: "T_CustomCakes",
                column: "IDIdea");

            migrationBuilder.CreateIndex(
                name: "IX_T_CustomCakes_IDPay",
                table: "T_CustomCakes",
                column: "IDPay");

            migrationBuilder.CreateIndex(
                name: "IX_T_CustomCakes_IDStatus",
                table: "T_CustomCakes",
                column: "IDStatus");

            migrationBuilder.CreateIndex(
                name: "IX_T_CustomCakes_IDUser",
                table: "T_CustomCakes",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_Customers_IDAccount",
                table: "T_Customers",
                column: "IDAccount");

            migrationBuilder.CreateIndex(
                name: "IX_T_Customers_IDCity",
                table: "T_Customers",
                column: "IDCity");

            migrationBuilder.CreateIndex(
                name: "IX_T_Customers_IDCountry",
                table: "T_Customers",
                column: "IDCountry");

            migrationBuilder.CreateIndex(
                name: "IX_T_Customers_IDCustomerOrStaff",
                table: "T_Customers",
                column: "IDCustomerOrStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_Customers_IDDistrict",
                table: "T_Customers",
                column: "IDDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_T_Customers_IDGender",
                table: "T_Customers",
                column: "IDGender");

            migrationBuilder.CreateIndex(
                name: "IX_T_Districts_IDCity",
                table: "T_Districts",
                column: "IDCity");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryGetGiftUserRotaionLucks_IDLuck",
                table: "T_HistoryGetGiftUserRotaionLucks",
                column: "IDLuck");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryGetGiftUserRotaionLucks_IDUser",
                table: "T_HistoryGetGiftUserRotaionLucks",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistorySeachUsers_IDUser",
                table: "T_HistorySeachUsers",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryTurnRotaionLucks_t_CustomerIDUser",
                table: "T_HistoryTurnRotaionLucks",
                column: "t_CustomerIDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryUserGetVochers_IDUser",
                table: "T_HistoryUserGetVochers",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryUserGetVochers_IDVocher",
                table: "T_HistoryUserGetVochers",
                column: "IDVocher");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryUseVochers_IDUser",
                table: "T_HistoryUseVochers",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_HistoryUseVochers_IDVocher",
                table: "T_HistoryUseVochers",
                column: "IDVocher");

            migrationBuilder.CreateIndex(
                name: "IX_T_ImageCustomIdeas_IDIdea",
                table: "T_ImageCustomIdeas",
                column: "IDIdea");

            migrationBuilder.CreateIndex(
                name: "IX_T_InfomationOrders_IDBrach",
                table: "T_InfomationOrders",
                column: "IDBrach");

            migrationBuilder.CreateIndex(
                name: "IX_T_InfomationOrders_IDCity",
                table: "T_InfomationOrders",
                column: "IDCity");

            migrationBuilder.CreateIndex(
                name: "IX_T_InfomationOrders_IDDistrict",
                table: "T_InfomationOrders",
                column: "IDDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_T_InformationAuthors_IDPosition",
                table: "T_InformationAuthors",
                column: "IDPosition");

            migrationBuilder.CreateIndex(
                name: "IX_T_NotificationCustomCakes_IDIdea",
                table: "T_NotificationCustomCakes",
                column: "IDIdea");

            migrationBuilder.CreateIndex(
                name: "IX_T_NotificationCustomCakes_IDUser",
                table: "T_NotificationCustomCakes",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrderDetails_IDCake",
                table: "T_OrderDetails",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrderDetails_IDGift",
                table: "T_OrderDetails",
                column: "IDGift");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrderDetails_IDOrder",
                table: "T_OrderDetails",
                column: "IDOrder");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrderDetails_IDSmell",
                table: "T_OrderDetails",
                column: "IDSmell");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrderDetails_IDStaff",
                table: "T_OrderDetails",
                column: "IDStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orders_IDInfomationOrder",
                table: "T_Orders",
                column: "IDInfomationOrder");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orders_IDPay",
                table: "T_Orders",
                column: "IDPay");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orders_IDStatusOrder",
                table: "T_Orders",
                column: "IDStatusOrder");

            migrationBuilder.CreateIndex(
                name: "IX_T_Orders_IDUser",
                table: "T_Orders",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_Ratings_IDCake",
                table: "T_Ratings",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_Ratings_IDUser",
                table: "T_Ratings",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_RatingWebsites_IDUser",
                table: "T_RatingWebsites",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_RotationLucks_IDLuck",
                table: "T_RotationLucks",
                column: "IDLuck");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDAccount",
                table: "T_Staffs",
                column: "IDAccount");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDCity",
                table: "T_Staffs",
                column: "IDCity");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDCustomerOrStaff",
                table: "T_Staffs",
                column: "IDCustomerOrStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDDistrict",
                table: "T_Staffs",
                column: "IDDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDGender",
                table: "T_Staffs",
                column: "IDGender");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDMarriage",
                table: "T_Staffs",
                column: "IDMarriage");

            migrationBuilder.CreateIndex(
                name: "IX_T_Staffs_IDStaffOrChef",
                table: "T_Staffs",
                column: "IDStaffOrChef");

            migrationBuilder.CreateIndex(
                name: "IX_T_TakeTurnsRotaionLucks_IDUser",
                table: "T_TakeTurnsRotaionLucks",
                column: "IDUser");

            migrationBuilder.CreateIndex(
                name: "IX_T_UserRoles_IDRole",
                table: "T_UserRoles",
                column: "IDRole");

            migrationBuilder.CreateIndex(
                name: "IX_T_UserRoles_IDStaff",
                table: "T_UserRoles",
                column: "IDStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_Users_IDCustomerOrStaff",
                table: "T_Users",
                column: "IDCustomerOrStaff");

            migrationBuilder.CreateIndex(
                name: "IX_T_ViewerCakeUsers_IDCake",
                table: "T_ViewerCakeUsers",
                column: "IDCake");

            migrationBuilder.CreateIndex(
                name: "IX_T_ViewerCakeUsers_IDUser",
                table: "T_ViewerCakeUsers",
                column: "IDUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "T_AddressUserDefauls");

            migrationBuilder.DropTable(
                name: "T_BannerRotationLucks");

            migrationBuilder.DropTable(
                name: "T_BillCakeCustoms");

            migrationBuilder.DropTable(
                name: "T_CakeGifts");

            migrationBuilder.DropTable(
                name: "T_CakeImages");

            migrationBuilder.DropTable(
                name: "T_CancelOrders");

            migrationBuilder.DropTable(
                name: "T_CartUsers");

            migrationBuilder.DropTable(
                name: "T_ChangePasswords");

            migrationBuilder.DropTable(
                name: "T_CheckLoginLogouts");

            migrationBuilder.DropTable(
                name: "T_ChefCakes");

            migrationBuilder.DropTable(
                name: "T_Comments");

            migrationBuilder.DropTable(
                name: "T_HistoryGetGiftUserRotaionLucks");

            migrationBuilder.DropTable(
                name: "T_HistorySeachUsers");

            migrationBuilder.DropTable(
                name: "T_HistoryTurnRotaionLucks");

            migrationBuilder.DropTable(
                name: "T_HistoryUserGetVochers");

            migrationBuilder.DropTable(
                name: "T_HistoryUseVochers");

            migrationBuilder.DropTable(
                name: "T_ImageBannerWebs");

            migrationBuilder.DropTable(
                name: "T_ImageCustomIdeas");

            migrationBuilder.DropTable(
                name: "T_InformationAuthors");

            migrationBuilder.DropTable(
                name: "T_NotificationCustomCakes");

            migrationBuilder.DropTable(
                name: "T_OrderDetails");

            migrationBuilder.DropTable(
                name: "T_Ratings");

            migrationBuilder.DropTable(
                name: "T_RatingWebsites");

            migrationBuilder.DropTable(
                name: "T_RotationLucks");

            migrationBuilder.DropTable(
                name: "T_TakeTurnsRotaionLucks");

            migrationBuilder.DropTable(
                name: "T_TokenLogins");

            migrationBuilder.DropTable(
                name: "T_UrlManagerCustomCakes");

            migrationBuilder.DropTable(
                name: "T_UserRoles");

            migrationBuilder.DropTable(
                name: "T_ViewerCakeUsers");

            migrationBuilder.DropTable(
                name: "T_TypeAddreses");

            migrationBuilder.DropTable(
                name: "T_CustomCakePrices");

            migrationBuilder.DropTable(
                name: "T_TypePayCustomCakes");

            migrationBuilder.DropTable(
                name: "T_Vochers");

            migrationBuilder.DropTable(
                name: "T_Positions");

            migrationBuilder.DropTable(
                name: "T_Gifts");

            migrationBuilder.DropTable(
                name: "T_Orders");

            migrationBuilder.DropTable(
                name: "T_GiftLucks");

            migrationBuilder.DropTable(
                name: "T_Roles");

            migrationBuilder.DropTable(
                name: "T_Cakes");

            migrationBuilder.DropTable(
                name: "T_CustomCakes");

            migrationBuilder.DropTable(
                name: "T_InfomationOrders");

            migrationBuilder.DropTable(
                name: "T_StatusOrders");

            migrationBuilder.DropTable(
                name: "T_TypePays");

            migrationBuilder.DropTable(
                name: "T_CakeElements");

            migrationBuilder.DropTable(
                name: "T_CakePrices");

            migrationBuilder.DropTable(
                name: "T_DiscountCakes");

            migrationBuilder.DropTable(
                name: "T_KindCakes");

            migrationBuilder.DropTable(
                name: "T_NewCakes");

            migrationBuilder.DropTable(
                name: "T_SmellCakes");

            migrationBuilder.DropTable(
                name: "T_StatusCakes");

            migrationBuilder.DropTable(
                name: "T_CakeCustomIdeas");

            migrationBuilder.DropTable(
                name: "T_Chefs");

            migrationBuilder.DropTable(
                name: "T_PayCustomCakes");

            migrationBuilder.DropTable(
                name: "T_StatusCustomCakes");

            migrationBuilder.DropTable(
                name: "T_Branchs");

            migrationBuilder.DropTable(
                name: "T_Customers");

            migrationBuilder.DropTable(
                name: "T_SizeCakes");

            migrationBuilder.DropTable(
                name: "T_StatusIdeas");

            migrationBuilder.DropTable(
                name: "T_TypeCakes");

            migrationBuilder.DropTable(
                name: "T_Staffs");

            migrationBuilder.DropTable(
                name: "T_Regiones");

            migrationBuilder.DropTable(
                name: "T_Countrys");

            migrationBuilder.DropTable(
                name: "T_Districts");

            migrationBuilder.DropTable(
                name: "T_Genders");

            migrationBuilder.DropTable(
                name: "T_Marriages");

            migrationBuilder.DropTable(
                name: "T_StaffOrChefs");

            migrationBuilder.DropTable(
                name: "T_Users");

            migrationBuilder.DropTable(
                name: "T_Citys");

            migrationBuilder.DropTable(
                name: "T_CustomerOrStaffs");
        }
    }
}
