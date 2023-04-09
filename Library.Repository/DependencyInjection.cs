using Library.InterfaceRepository.Interface.Banner_Repo;
using Library.InterfaceRepository.Interface.Branch_Repo;
using Library.InterfaceRepository.Interface.Cake_Repo;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.InterfaceRepository.Interface.Chef_Repo;
using Library.InterfaceRepository.Interface.Comment_Repo;
using Library.InterfaceRepository.Interface.InformationAuthor_Repo;
using Library.InterfaceRepository.Interface.Order_Repo;
using Library.InterfaceRepository.Interface.Rating_Repo;
using Library.InterfaceRepository.Interface.Role_Repo;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.InterfaceRepository.Interface.Staff_Repo;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.InterfaceRepository.Interface.Vocher_Repo;
using Library.InterfaceRepository.IUnitOfWork;
using Library.Repository.Repository;
using Library.Repository.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IimageBannerWebRepository, ImageBannerWebRepository>();

            services.AddScoped<IBranchRepository, BranchRepository>(); 
            services.AddScoped<IRegionsRepository, RegionsRepository>();

            services.AddScoped<ICakeElementRepository, CakeElementRepository>();
            services.AddScoped<ICakeGiftRepository, CakeGiftRepository>();
            services.AddScoped<ICakeImageRepository, CakeImageRepository>();
            services.AddScoped<ICakePriceRepository, CakePriceRepository>();
            services.AddScoped<ICakeRepository, CakeRepository>();
            services.AddScoped<IDiscountCakeRepository, DiscountCakeRepository>();
            services.AddScoped<IGiftRepository, GiftRepository>();
            services.AddScoped<IKindCakeRepository, KindCakeRepository>();
            services.AddScoped<INewCakeRepository, NewCakeRepository>();
            services.AddScoped<ISmellCakeRepository, SmellCakeRepository>();
            services.AddScoped<IStatusCakeRepository, StatusCakeRepository>();
            services.AddScoped<ITypeCakeRepository, TypeCakeRepository>();

            services.AddScoped<IBillCakeCustomRepository, BillCakeCustomRepository>();
            services.AddScoped<ICakeCustomIdeaRepository, CakeCustomIdeaRepository>();
            services.AddScoped<ICustomCakePriceRepository, CustomCakePriceRepository>();
            services.AddScoped<ICustomCakeRepository, CustomCakeRepository>();
            services.AddScoped<IimageCustomIdeaRepository, ImageCustomIdeaRepository>();
            services.AddScoped<INotificationCustomCakeRepository, NotificationCustomCakeRepository>();
            services.AddScoped<IPayCustomCakeRepository, PayCustomCakeRepository>();
            services.AddScoped<ISizeCakeRepository, SizeCakeRepository>();
            services.AddScoped<IStatusCustomCakeRepository, StatusCustomCakeRepository>();
            services.AddScoped<IStatusIdeaRepository, StatusIdeaRepository>();
            services.AddScoped<ITypePayCustomCakeRepository, TypePayCustomCakeRepository>();
            services.AddScoped<IUrlManagerCustomCakeRepository, UrlManagerCustomCakeRepository>();

            services.AddScoped<IChefCakeRepository, ChefCakeRepository>();
            services.AddScoped<IChefRepository, ChefRepository>();

            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IinformationAuthorRepository, InformationAuthorRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();

            services.AddScoped<IAddressUserDefaulRepository, AddressUserDefaulRepository>();
            services.AddScoped<ICancelOrderRepository, CancelOrderRepository>();
            services.AddScoped<ICartUserRepository, CartUserRepository>();
            services.AddScoped<IinfomationOrderRepository, InfomationOrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IStatusOrderRepository, StatusOrderRepository>();
            services.AddScoped<ITypeAddressRepository, TypeAddressRepository>();
            services.AddScoped<ITypePayRepository, TypePayRepository>();

            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddScoped<IRatingWebsiteRepository, RatingWebsiteRepository>();

            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();

            services.AddScoped<IBannerRotationLuckRepository, BannerRotationLuckRepository>();
            services.AddScoped<IGiftLuckRepository, GiftLuckRepository>();
            services.AddScoped<IHistoryGetGiftUserRotaionLuckRepository, HistoryGetGiftUserRotaionLuckRepository>();
            services.AddScoped<IHistoryTurnRotaionLuckRepository, HistoryTurnRotaionLuckRepository>();
            services.AddScoped<IRotationLuckRepository, RotationLuckRepository>();
            services.AddScoped<ITakeTurnsRotaionLuckRepository, TakeTurnsRotaionLuckRepository>();

            services.AddScoped<IStaffOrChefRepository, StaffOrChefRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();

            services.AddScoped<IChangePasswordRepository, ChangePasswordRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICustomerOrStaffRepository, CustomerOrStaffRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IHistorySeachUserRepository, HistorySeachUserRepository>();
            services.AddScoped<IMarriageRepository, MarriageRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IViewerCakeUserRepository, ViewerCakeUserRepository>();
            services.AddScoped<ICheckLoginLogoutRepository, CheckLoginLogoutRepository>();
            services.AddScoped<ITokenLoginRepository, TokenLoginRepository>();

            services.AddScoped<IHistoryUserGetVocherRepository, HistoryUserGetVocherRepository>();
            services.AddScoped<IHistoryUseVocherRepository, HistoryUseVocherRepository>();
            services.AddScoped<IVocherRepository, VocherRepository>();

            //-----------------------------------------------

            return services;
        }
    }
}
