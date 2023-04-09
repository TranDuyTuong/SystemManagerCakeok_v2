using Library.DomainData.DataEF;
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
using System;

namespace Library.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ContextDBCakeOk Context;
        public UnitOfWork(ContextDBCakeOk _context)
        {
            this.Context = _context;
        }

        private IimageBannerWebRepository _ImageBannerWeb;
        private IBranchRepository _branch;
        private IRegionsRepository _regions;
        private ICakeElementRepository _cakeElement;
        private ICakeGiftRepository _cakeGift;
        private ICakeImageRepository _cakeImage;
        private ICakePriceRepository _cakePrice;
        private ICakeRepository _cake;
        private IDiscountCakeRepository _discountCake;
        private IGiftRepository _gift;
        private IKindCakeRepository _kindCake;
        private INewCakeRepository _newCake;
        private ISmellCakeRepository _smellCake;
        private IStatusCakeRepository _statusCake;
        private ITypeCakeRepository _typeCake;
        private IBillCakeCustomRepository _billCakeCustom;
        private ICakeCustomIdeaRepository _cakeCustomIdea;
        private ICustomCakePriceRepository _customCakePrice;
        private ICustomCakeRepository _customCake;
        private IimageCustomIdeaRepository _imageCustomIdea;
        private INotificationCustomCakeRepository _notificationCustomCake;
        private IPayCustomCakeRepository _payCustomCake;
        private ISizeCakeRepository _sizeCake;
        private IStatusCustomCakeRepository _statusCustomCake;
        private IStatusIdeaRepository _statusIdea;
        private ITypePayCustomCakeRepository _typePayCustomCake;
        private IUrlManagerCustomCakeRepository _urlManagerCustomCake;
        private IChefCakeRepository _chefCake;
        private IChefRepository _chef;
        private ICommentRepository _comment;
        private IinformationAuthorRepository _informationAuthor;
        private IPositionRepository _position;
        private IAddressUserDefaulRepository _addressUserDefaul;
        private ICancelOrderRepository _cancelOrder;
        private ICartUserRepository _cartUser;
        private IinfomationOrderRepository _infomationOrder;
        private IOrderDetailRepository _orderDetail;
        private IOrderRepository _order;
        private IStatusOrderRepository _statusOrder;
        private ITypeAddressRepository _typeAddress;
        private ITypePayRepository _typePay;
        private IRatingRepository _rating;
        private IRatingWebsiteRepository _ratingWebsite;
        private IRoleRepository _role;
        private IUserRoleRepository _userRole;
        private IBannerRotationLuckRepository _bannerRotationLuck;
        private IGiftLuckRepository _giftLuck;
        private IHistoryGetGiftUserRotaionLuckRepository _historyGetGiftUserRotaionLuck;
        private IHistoryTurnRotaionLuckRepository _historyTurnRotaionLuck;
        private IRotationLuckRepository _rotationLuck;
        private ITakeTurnsRotaionLuckRepository _takeTurnsRotaionLuck;
        private IStaffOrChefRepository _staffOrChef;
        private IStaffRepository _staff;
        private IChangePasswordRepository _changePassword;
        private ICityRepository _city;
        private ICountryRepository _country;
        private ICustomerOrStaffRepository _customerOrStaff;
        private ICustomerRepository _customer;
        private IDistrictRepository _district;
        private IGenderRepository _gender;
        private IHistorySeachUserRepository _historySeachUser;
        private IMarriageRepository _marriage;
        private IUserRepository _user;
        private IViewerCakeUserRepository _viewerCakeUser;
        private IHistoryUserGetVocherRepository _historyUserGetVocher;
        private IHistoryUseVocherRepository _historyUseVocher;
        private IVocherRepository _vocher;
        private ITokenLoginRepository _tokenLogin;
        private ICheckLoginLogoutRepository _checkLoginLogout;

        public IStatusCustomCakeRepository statusCustomCakeRepo => _statusCustomCake ?? (_statusCustomCake = new StatusCustomCakeRepository(Context));
        public ISizeCakeRepository sizeCakeRepo => _sizeCake ?? (_sizeCake = new SizeCakeRepository(Context));
        public IPayCustomCakeRepository payCustomCakeRepo => _payCustomCake ?? (_payCustomCake = new PayCustomCakeRepository(Context));
        public INotificationCustomCakeRepository notificationCustomCakeRepo => _notificationCustomCake ?? (_notificationCustomCake = new NotificationCustomCakeRepository(Context));
        public IimageCustomIdeaRepository imageCustomIdeaRepo => _imageCustomIdea ?? (_imageCustomIdea = new ImageCustomIdeaRepository(Context));
        public ICustomCakeRepository customCakeRepo => _customCake ?? (_customCake = new CustomCakeRepository(Context));
        public ICustomCakePriceRepository customCakePriceRepo => _customCakePrice ?? (_customCakePrice = new CustomCakePriceRepository(Context));
        public ICakeCustomIdeaRepository cakeCustomIdeaRepo => _cakeCustomIdea ?? (_cakeCustomIdea = new CakeCustomIdeaRepository(Context));
        public IBillCakeCustomRepository billCakeCustomRepo => _billCakeCustom ?? (_billCakeCustom = new BillCakeCustomRepository(Context));
        public ITypeCakeRepository typeCakeRepo => _typeCake ?? (_typeCake = new TypeCakeRepository(Context));
        public IStatusCakeRepository statusCakeRepo => _statusCake ?? (_statusCake = new StatusCakeRepository(Context));
        public ISmellCakeRepository smellCakeRepo => _smellCake ?? (_smellCake = new SmellCakeRepository(Context));
        public INewCakeRepository newCakeRepo => _newCake ?? (_newCake = new NewCakeRepository(Context));
        public IKindCakeRepository kindCakeRepo => _kindCake ?? (_kindCake = new KindCakeRepository(Context));
        public IGiftRepository giftRepo => _gift ?? (_gift = new GiftRepository(Context));
        public IDiscountCakeRepository discountCakeRepo => _discountCake ?? (_discountCake = new DiscountCakeRepository(Context));
        public ICakeRepository cakeRepo => _cake ?? (_cake = new CakeRepository(Context));
        public ICakePriceRepository cakePriceRepo => _cakePrice ?? (_cakePrice = new CakePriceRepository(Context));
        public ICakeImageRepository cakeImageRepo => _cakeImage ?? (_cakeImage = new CakeImageRepository(Context));
        public ICakeGiftRepository cakeGiftRepo => _cakeGift ?? (_cakeGift = new CakeGiftRepository(Context));
        public ICakeElementRepository cakeElementRepo => _cakeElement ?? (_cakeElement = new CakeElementRepository(Context));
        public IRegionsRepository regionsRepo => _regions ?? (_regions = new RegionsRepository(Context));
        public IBranchRepository branchRepo => _branch ?? (_branch = new BranchRepository(Context));
        public IUserRoleRepository userRoleRepo => _userRole ?? (_userRole = new UserRoleRepository(Context));
        public IRoleRepository roleRepo => _role ?? (_role = new RoleRepository(Context));
        public IRatingWebsiteRepository ratingWebsiteRepo => _ratingWebsite ?? (_ratingWebsite = new RatingWebsiteRepository(Context));
        public IRatingRepository ratingRepo => _rating ?? (_rating = new RatingRepository(Context));
        public ITypePayRepository typePayRepo => _typePay ?? (_typePay = new TypePayRepository(Context));
        public ITypeAddressRepository typeAddressRepo => _typeAddress ?? (_typeAddress = new TypeAddressRepository(Context));
        public IStatusOrderRepository statusOrderRepo => _statusOrder ?? (_statusOrder = new StatusOrderRepository(Context));
        public IOrderRepository orderRepo => _order ?? (_order = new OrderRepository(Context));
        public IOrderDetailRepository orderDetailRepo => _orderDetail ?? (_orderDetail = new OrderDetailRepository(Context));
        public IinfomationOrderRepository infomationOrderRepo => _infomationOrder ?? (_infomationOrder = new InfomationOrderRepository(Context));
        public ICartUserRepository cartUserRepo => _cartUser ?? (_cartUser = new CartUserRepository(Context));
        public ICancelOrderRepository cancelOrderRepo => _cancelOrder ?? (_cancelOrder = new CancelOrderRepository(Context));
        public IAddressUserDefaulRepository addressUserDefaulRepo => _addressUserDefaul ?? (_addressUserDefaul = new AddressUserDefaulRepository(Context));
        public IPositionRepository positionRepo => _position ?? (_position = new PositionRepository(Context));
        public IinformationAuthorRepository informationAuthorRepo => _informationAuthor ?? (_informationAuthor = new InformationAuthorRepository(Context));
        public ICommentRepository commentRepo => _comment ?? (_comment = new CommentRepository(Context));
        public IChefRepository chefRepo => _chef ?? (_chef = new ChefRepository(Context));
        public IChefCakeRepository chefCakeRepo => _chefCake ?? (_chefCake = new ChefCakeRepository(Context));
        public IUrlManagerCustomCakeRepository urlManagerCustomCakeRepo => _urlManagerCustomCake ?? (_urlManagerCustomCake = new UrlManagerCustomCakeRepository(Context));
        public ITypePayCustomCakeRepository typePayCustomCakeRepo => _typePayCustomCake ?? (_typePayCustomCake = new TypePayCustomCakeRepository(Context));
        public IStatusIdeaRepository statusIdeaRepo => _statusIdea ?? (_statusIdea = new StatusIdeaRepository(Context));

        public IGenderRepository genderRepo => _gender ?? (_gender = new GenderRepository(Context));
        public IDistrictRepository districtRepo => _district ?? (_district = new DistrictRepository(Context));
        public ICustomerRepository customerRepo => _customer ?? (_customer = new CustomerRepository(Context));
        public ICustomerOrStaffRepository customerOrStaffRepo => _customerOrStaff ?? (_customerOrStaff = new CustomerOrStaffRepository(Context));
        public ICountryRepository countryRepo => _country ?? (_country = new CountryRepository(Context));
        public ICityRepository cityRepo => _city ?? (_city = new CityRepository(Context));
        public IChangePasswordRepository changePasswordRepo => _changePassword ?? (_changePassword = new ChangePasswordRepository(Context));
        public IStaffRepository staffRepo => _staff ?? (_staff = new StaffRepository(Context));
        public IStaffOrChefRepository staffOrChefRepo => _staffOrChef ?? (_staffOrChef = new StaffOrChefRepository(Context));
        public ITakeTurnsRotaionLuckRepository takeTurnsRotaionLuckRepo => _takeTurnsRotaionLuck ?? (_takeTurnsRotaionLuck = new TakeTurnsRotaionLuckRepository(Context));
        public IRotationLuckRepository rotationLuckRepo => _rotationLuck ?? (_rotationLuck = new RotationLuckRepository(Context));
        public IHistoryTurnRotaionLuckRepository historyTurnRotaionLuckRepo => _historyTurnRotaionLuck ?? (_historyTurnRotaionLuck = new HistoryTurnRotaionLuckRepository(Context));
        public IHistoryGetGiftUserRotaionLuckRepository historyGetGiftUserRotaionLuckRepo => _historyGetGiftUserRotaionLuck ?? (_historyGetGiftUserRotaionLuck = new HistoryGetGiftUserRotaionLuckRepository(Context));
        public IGiftLuckRepository giftLuckRepo => _giftLuck ?? (_giftLuck = new GiftLuckRepository(Context));
        public IBannerRotationLuckRepository bannerRotationLuckRepo => _bannerRotationLuck ?? (_bannerRotationLuck = new BannerRotationLuckRepository(Context));

        public IHistorySeachUserRepository historySeachUserRepo => _historySeachUser ?? (_historySeachUser = new HistorySeachUserRepository(Context));
        public IMarriageRepository marriageRepo => _marriage ?? (_marriage = new MarriageRepository(Context));
        public IUserRepository userRepo => _user ?? (_user = new UserRepository(Context));
        public IViewerCakeUserRepository viewerCakeUserRepo => _viewerCakeUser ?? (_viewerCakeUser = new ViewerCakeUserRepository(Context));
        public IHistoryUserGetVocherRepository historyUserGetVocherRepo => _historyUserGetVocher ?? (_historyUserGetVocher = new HistoryUserGetVocherRepository(Context));
        public IHistoryUseVocherRepository historyUseVocherRepo => _historyUseVocher ?? (_historyUseVocher = new HistoryUseVocherRepository(Context));
        public IVocherRepository vocherRepo => _vocher ?? (_vocher = new VocherRepository(Context));
        public IimageBannerWebRepository ImageBannerWebRepo => _ImageBannerWeb ?? (_ImageBannerWeb = new ImageBannerWebRepository(Context));

        public ITokenLoginRepository tokenLoginRepo => _tokenLogin ?? (_tokenLogin = new TokenLoginRepository(Context));

        public ICheckLoginLogoutRepository checkLoginLogoutRepo => _checkLoginLogout ?? (_checkLoginLogout = new CheckLoginLogoutRepository(Context));

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (Context == null) return;
            Context.Dispose();

        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
