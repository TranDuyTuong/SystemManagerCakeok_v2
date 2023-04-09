using Library.ConfigurationData.ConfigurationBanner;
using Library.ConfigurationData.ConfigurationBranch;
using Library.ConfigurationData.ConfigurationCake;
using Library.ConfigurationData.ConfigurationCakeCustom;
using Library.ConfigurationData.ConfigurationChef;
using Library.ConfigurationData.ConfigurationComment;
using Library.ConfigurationData.ConfigurationInfomationAuthor;
using Library.ConfigurationData.ConfigurationOrder;
using Library.ConfigurationData.ConfigurationRating;
using Library.ConfigurationData.ConfigurationRole;
using Library.ConfigurationData.ConfigurationRotaionLuck;
using Library.ConfigurationData.ConfigurationStaff;
using Library.ConfigurationData.ConfigurationUser;
using Library.ConfigurationData.ConfigurationVocher;
using Library.DataTable.TableBanner;
using Library.DataTable.TableBranch;
using Library.DataTable.TableCake;
using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableChef;
using Library.DataTable.TableComment;
using Library.DataTable.TableInformationAuthor;
using Library.DataTable.TableOrder;
using Library.DataTable.TableRating;
using Library.DataTable.TableRole;
using Library.DataTable.TableRotationLuck;
using Library.DataTable.TableStaff;
using Library.DataTable.TableUser;
using Library.DataTable.TableVocher;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.DataEF
{
    public class ContextDBCakeOk: IdentityDbContext<T_User, T_Role, Guid>
    {
        public ContextDBCakeOk(DbContextOptions<ContextDBCakeOk> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationBannerWeb());
            modelBuilder.ApplyConfiguration(new ConfigurationBranch());
            modelBuilder.ApplyConfiguration(new ConfigurationRegions());

            modelBuilder.ApplyConfiguration(new ConfigurationCake());
            modelBuilder.ApplyConfiguration(new ConfigurationCakeElement());
            modelBuilder.ApplyConfiguration(new ConfigurationCakeGift());
            modelBuilder.ApplyConfiguration(new ConfigurationCakeImage());
            modelBuilder.ApplyConfiguration(new ConfigurationCakePrice());
            modelBuilder.ApplyConfiguration(new ConfigurationDiscountCake());
            modelBuilder.ApplyConfiguration(new ConfigurationGift());
            modelBuilder.ApplyConfiguration(new ConfigurationKindCake());
            modelBuilder.ApplyConfiguration(new ConfigurationNewCake());
            modelBuilder.ApplyConfiguration(new ConfigurationSmellCake());
            modelBuilder.ApplyConfiguration(new ConfigurationStatusCake());
            modelBuilder.ApplyConfiguration(new ConfigurationTypeCake());

            modelBuilder.ApplyConfiguration(new ConfigurationBillCakeCustom());
            modelBuilder.ApplyConfiguration(new ConfigurationCakeCustomIdea());
            modelBuilder.ApplyConfiguration(new ConfigurationCustomCake());
            modelBuilder.ApplyConfiguration(new ConfigurationCustomCakePrice());
            modelBuilder.ApplyConfiguration(new ConfigurationImageCustomIdea());
            modelBuilder.ApplyConfiguration(new ConfigurationNotificationCustomCake());
            modelBuilder.ApplyConfiguration(new ConfigurationPayCustomCake());
            modelBuilder.ApplyConfiguration(new ConfigurationSizeCake());
            modelBuilder.ApplyConfiguration(new ConfigurationStatusCustomCake());
            modelBuilder.ApplyConfiguration(new ConfigurationStatusIdea());
            modelBuilder.ApplyConfiguration(new ConfigurationTypePayCustomCake());
            modelBuilder.ApplyConfiguration(new ConfigurationUrlManagerCustomCake());

            modelBuilder.ApplyConfiguration(new ConfigurationChef());
            modelBuilder.ApplyConfiguration(new ConfigurationChefCake());

            modelBuilder.ApplyConfiguration(new ConfigurationComment());

            modelBuilder.ApplyConfiguration(new ConfigurationInformationAuthor());
            modelBuilder.ApplyConfiguration(new ConfigurationPosition());

            modelBuilder.ApplyConfiguration(new ConfigurationAddressUserDefaul());
            modelBuilder.ApplyConfiguration(new ConfigurationCancelOrder());
            modelBuilder.ApplyConfiguration(new ConfigurationCartUser());
            modelBuilder.ApplyConfiguration(new ConfigurationInfomationOrder());
            modelBuilder.ApplyConfiguration(new ConfigurationOrder());
            modelBuilder.ApplyConfiguration(new ConfigurationOrderDetail());
            modelBuilder.ApplyConfiguration(new ConfigurationStatusOrder());
            modelBuilder.ApplyConfiguration(new ConfigurationTypeAddress());
            modelBuilder.ApplyConfiguration(new ConfigurationTypePay());

            modelBuilder.ApplyConfiguration(new ConfigurationRating());
            modelBuilder.ApplyConfiguration(new ConfigurationRatingWebsite());

            modelBuilder.ApplyConfiguration(new ConfigurationRole());
            modelBuilder.ApplyConfiguration(new ConfigurationUserRole());

            modelBuilder.ApplyConfiguration(new ConfigurationBannerRotationLuck());
            modelBuilder.ApplyConfiguration(new ConfigurationGiftLuck());
            modelBuilder.ApplyConfiguration(new ConfigurationHistoryGetGiftUserRotaionLuck());
            modelBuilder.ApplyConfiguration(new ConfigurationHistoryTurnRotaionLuck());
            modelBuilder.ApplyConfiguration(new ConfigurationRotationLuck());
            modelBuilder.ApplyConfiguration(new ConfigurationTakeTurnsRotaionLuck());

            modelBuilder.ApplyConfiguration(new ConfigurationStaff());
            modelBuilder.ApplyConfiguration(new ConfigurationStaffOrChef());
            modelBuilder.ApplyConfiguration(new ConfigurationTokenLogin());
            modelBuilder.ApplyConfiguration(new ConfigurationCheckLoginLogout());

            modelBuilder.ApplyConfiguration(new ConfigurationChangePassword());
            modelBuilder.ApplyConfiguration(new ConfigurationCity());
            modelBuilder.ApplyConfiguration(new ConfigurationCountry());
            modelBuilder.ApplyConfiguration(new ConfigurationCustomer());
            modelBuilder.ApplyConfiguration(new ConfigurationCustomerOrStaff());
            modelBuilder.ApplyConfiguration(new ConfigurationDistrict());
            modelBuilder.ApplyConfiguration(new ConfigurationGender());
            modelBuilder.ApplyConfiguration(new ConfigurationHistorySeachUser());
            modelBuilder.ApplyConfiguration(new ConfigurationMarriage());
            modelBuilder.ApplyConfiguration(new ConfigurationUser());
            modelBuilder.ApplyConfiguration(new ConfigurationViewerCakeUser());

            modelBuilder.ApplyConfiguration(new ConfigurationHistoryUserGetVocher());
            modelBuilder.ApplyConfiguration(new ConfigurationHistoryUseVocher());
            modelBuilder.ApplyConfiguration(new ConfigurationVocher());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
        }

        public DbSet<T_ImageBannerWeb> t_ImageBannerWebs { get; set; }
        public DbSet<T_Branch> t_Branches { get; set; }
        public DbSet<T_Regions> t_Regions { get; set; }
        public DbSet<T_Cake> t_Cakes { get; set; }
        public DbSet<T_CakeElement> t_CakeElements { get; set; }
        public DbSet<T_CakeGift> t_CakeGifts { get; set; }
        public DbSet<T_CakeImage> t_CakeImages { get; set; }
        public DbSet<T_CakePrice> t_CakePrices { get; set; }
        public DbSet<T_DiscountCake> t_DiscountCakes { get; set; }
        public DbSet<T_Gift> t_Gifts { get; set; }
        public DbSet<T_KindCake> t_KindCakes { get; set; }
        public DbSet<T_NewCake> t_NewCakes { get; set; }
        public DbSet<T_SmellCake> t_SmellCakes { get; set; }
        public DbSet<T_StatusCake> t_StatusCakes { get; set; }
        public DbSet<T_TypeCake> t_TypeCakes { get; set; }
        public DbSet<T_BillCakeCustom> t_BillCakeCustoms { get; set; }
        public DbSet<T_CakeCustomIdea> t_CakeCustomIdeas { get; set; }
        public DbSet<T_CustomCake> t_CustomCakes { get; set; }
        public DbSet<T_CustomCakePrice> t_CustomCakePrices { get; set; }
        public DbSet<T_ImageCustomIdea> t_ImageCustomIdeas { get; set; }
        public DbSet<T_NotificationCustomCake> t_NotificationCustomCakes { get; set; }
        public DbSet<T_PayCustomCake> t_PayCustomCakes { get; set; }
        public DbSet<T_SizeCake> t_SizeCakes { get; set; }
        public DbSet<T_StatusCustomCake> t_StatusCustomCakes { get; set; }
        public DbSet<T_StatusIdea> t_StatusIdeas { get; set; }
        public DbSet<T_TypePayCustomCake> t_TypePayCustomCakes { get; set; }
        public DbSet<T_UrlManagerCustomCake> t_UrlManagerCustomCakes { get; set; }
        public DbSet<T_Chef> t_Chefs { get; set; }
        public DbSet<T_ChefCake> t_ChefCakes { get; set; }
        public DbSet<T_Comment> t_Comments { get; set; }
        public DbSet<T_InformationAuthor> t_InformationAuthors { get; set; }
        public DbSet<T_Position> t_Positions { get; set; }
        public DbSet<T_AddressUserDefaul> t_AddressUserDefauls { get; set; }
        public DbSet<T_CancelOrder> t_CancelOrders { get; set; }
        public DbSet<T_CartUser> t_CartUsers { get; set; }
        public DbSet<T_InfomationOrder> t_InfomationOrders { get; set; }
        public DbSet<T_Order> t_Orders { get; set; }
        public DbSet<T_OrderDetail> t_OrderDetails { get; set; }
        public DbSet<T_StatusOrder> t_StatusOrders { get; set; }
        public DbSet<T_TypeAddress> t_TypeAddresses { get; set; }
        public DbSet<T_TypePay> t_TypePays { get; set; }
        public DbSet<T_Rating> t_Ratings { get; set; }
        public DbSet<T_RatingWebsite> t_RatingWebsites{ get; set; }
        public DbSet<T_Role> t_Roles { get; set; }
        public DbSet<T_UserRole> t_UserRoles { get; set; }
        public DbSet<T_BannerRotationLuck> t_BannerRotationLucks { get; set; }
        public DbSet<T_GiftLuck> t_GiftLucks{ get; set; }
        public DbSet<T_HistoryGetGiftUserRotaionLuck> t_HistoryGetGiftUserRotaionLucks { get; set; }
        public DbSet<T_HistoryTurnRotaionLuck> t_HistoryTurnRotaionLucks { get; set; }
        public DbSet<T_RotationLuck> t_RotationLucks{ get; set; }
        public DbSet<T_TakeTurnsRotaionLuck> t_TakeTurnsRotaionLucks{ get; set; }
        public DbSet<T_Staff> t_Staffs{ get; set; }
        public DbSet<T_StaffOrChef> t_StaffOrChefs { get; set; }
        public DbSet<T_ChangePassword> t_ChangePasswords { get; set; }
        public DbSet<T_City> t_Cities { get; set; }
        public DbSet<T_Country> t_Countries{ get; set; }
        public DbSet<T_Customer> t_Customers { get; set; }
        public DbSet<T_CustomerOrStaff> t_CustomerOrStaffs{ get; set; }
        public DbSet<T_District> t_Districts { get; set; }
        public DbSet<T_Gender> t_Genders { get; set; }
        public DbSet<T_HistorySeachUser> t_HistorySeachUsers { get; set; }
        public DbSet<T_Marriage> t_Marriages { get; set; }
        public DbSet<T_User> t_Users{ get; set; }
        public DbSet<T_ViewerCakeUser> t_ViewerCakeUsers { get; set; }
        public DbSet<T_HistoryUserGetVocher> t_HistoryUserGetVochers { get; set; }
        public DbSet<T_HistoryUseVocher> t_HistoryUseVochers{ get; set; }
        public DbSet<T_Vocher> t_Vochers { get; set; }
        public DbSet<T_TokenLogin> t_TokenLogins { get; set; }
        public DbSet<T_CheckLoginLogout> t_CheckLoginLogouts { get; set; }

    }
}
