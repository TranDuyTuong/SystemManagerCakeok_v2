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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.InterfaceRepository.IUnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IimageBannerWebRepository ImageBannerWebRepo { get; }
        IBranchRepository branchRepo { get; }
        IRegionsRepository regionsRepo { get; }

        //--------------------------------------------
        ICakeElementRepository cakeElementRepo { get; }
        ICakeGiftRepository cakeGiftRepo { get; }
        ICakeImageRepository cakeImageRepo { get; }
        ICakePriceRepository cakePriceRepo { get; }
        ICakeRepository cakeRepo { get; }
        IDiscountCakeRepository discountCakeRepo { get; }
        IGiftRepository giftRepo { get; }
        IKindCakeRepository kindCakeRepo { get; }
        INewCakeRepository newCakeRepo { get; }
        ISmellCakeRepository smellCakeRepo { get; }
        IStatusCakeRepository statusCakeRepo { get; }
        ITypeCakeRepository typeCakeRepo { get; }

        //--------------------------------------------
        IBillCakeCustomRepository billCakeCustomRepo { get; }
        ICakeCustomIdeaRepository cakeCustomIdeaRepo { get; }
        ICustomCakePriceRepository customCakePriceRepo { get; }
        ICustomCakeRepository customCakeRepo { get; }
        IimageCustomIdeaRepository imageCustomIdeaRepo { get; }
        INotificationCustomCakeRepository notificationCustomCakeRepo { get; }
        IPayCustomCakeRepository payCustomCakeRepo { get; }
        ISizeCakeRepository sizeCakeRepo { get; }
        IStatusCustomCakeRepository statusCustomCakeRepo { get; }
        IStatusIdeaRepository statusIdeaRepo { get; }
        ITypePayCustomCakeRepository typePayCustomCakeRepo { get; }
        IUrlManagerCustomCakeRepository urlManagerCustomCakeRepo { get; }

        //--------------------------------------------
        IChefCakeRepository chefCakeRepo { get; }
        IChefRepository chefRepo { get; }

        //--------------------------------------------
        ICommentRepository commentRepo { get; }

        //--------------------------------------------
        IinformationAuthorRepository informationAuthorRepo { get; }
        IPositionRepository positionRepo { get; }

        //--------------------------------------------
        IAddressUserDefaulRepository addressUserDefaulRepo { get; }
        ICancelOrderRepository cancelOrderRepo { get; }
        ICartUserRepository cartUserRepo { get; }
        IinfomationOrderRepository infomationOrderRepo { get; }
        IOrderDetailRepository orderDetailRepo { get; }
        IOrderRepository orderRepo { get; }
        IStatusOrderRepository statusOrderRepo { get; }
        ITypeAddressRepository typeAddressRepo { get; }
        ITypePayRepository typePayRepo { get; }

        //--------------------------------------------
        IRatingRepository ratingRepo { get; }
        IRatingWebsiteRepository ratingWebsiteRepo { get; }

        //--------------------------------------------
        IRoleRepository roleRepo { get; }
        IUserRoleRepository userRoleRepo { get; }

        //--------------------------------------------
        IBannerRotationLuckRepository bannerRotationLuckRepo { get; }
        IGiftLuckRepository giftLuckRepo { get; }
        IHistoryGetGiftUserRotaionLuckRepository historyGetGiftUserRotaionLuckRepo { get; }
        IHistoryTurnRotaionLuckRepository historyTurnRotaionLuckRepo { get; }
        IRotationLuckRepository rotationLuckRepo { get; }
        ITakeTurnsRotaionLuckRepository takeTurnsRotaionLuckRepo { get; }

        //--------------------------------------------
        IStaffOrChefRepository staffOrChefRepo { get; }
        IStaffRepository staffRepo { get; }

        //--------------------------------------------
        IChangePasswordRepository changePasswordRepo { get; }
        ICityRepository cityRepo { get; }
        ICountryRepository countryRepo { get; }
        ICustomerOrStaffRepository customerOrStaffRepo { get; }
        ICustomerRepository customerRepo { get; }
        IDistrictRepository districtRepo { get; }
        IGenderRepository genderRepo { get; }
        IHistorySeachUserRepository historySeachUserRepo { get; }
        IMarriageRepository marriageRepo { get; }
        IUserRepository userRepo { get; }
        IViewerCakeUserRepository viewerCakeUserRepo { get; }
        ITokenLoginRepository tokenLoginRepo { get; }
        ICheckLoginLogoutRepository checkLoginLogoutRepo { get; }

        //--------------------------------------------
        IHistoryUserGetVocherRepository historyUserGetVocherRepo { get; }
        IHistoryUseVocherRepository historyUseVocherRepo { get; }
        IVocherRepository vocherRepo { get; }

        int Complete();
        void Commit();
    }
}
