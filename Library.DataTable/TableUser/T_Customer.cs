using Library.DataTable.TableCakeCustom;
using Library.DataTable.TableComment;
using Library.DataTable.TableOrder;
using Library.DataTable.TableRating;
using Library.DataTable.TableRotationLuck;
using Library.DataTable.TableVocher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableUser
{
    public class T_Customer
    {
        public Guid IDUser { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public byte[] ContentFile { get; set; }
        public string MimeFile { get; set; }
        public string TypeFile { get; set; }
        public string FileName { get; set; }

        public int IDCity { get; set; }
        public T_City t_City { get; set; }

        public int IDDistrict { get; set; }
        public T_District t_District { get; set; }

        public int IDGender { get; set; }
        public T_Gender t_Gender { get; set; }

        public int IDCountry { get; set; }
        public T_Country t_Country { get; set; }

        public int IDCustomerOrStaff { get; set; }
        public T_CustomerOrStaff t_CustomerOrStaff { get; set; }

        public Guid IDAccount { get; set; }
        public T_User t_User { get; set; }



        public List<T_CakeCustomIdea> t_CakeCustomIdeas { get; set; }
        public List<T_CustomCake> t_CustomCakes { get; set; }
        public List<T_NotificationCustomCake> t_NotificationCustomCakes { get; set; }
        public List<T_Comment> t_Comments { get; set; }
        public List<T_AddressUserDefaul> t_AddressUserDefauls { get; set; }
        public List<T_CartUser> t_CartUsers { get; set; }
        public List<T_Order> t_Orders { get; set; }
        public List<T_Rating> t_Ratings { get; set; }
        public List<T_RatingWebsite> t_RatingWebsites { get; set; }
        public List<T_HistorySeachUser> t_HistorySeachUsers { get; set; }
        public List<T_ViewerCakeUser> t_ViewerCakeUsers { get; set; }
        public List<T_HistoryUserGetVocher> t_HistoryUserGetVochers { get; set; }
        public List<T_HistoryUseVocher> t_HistoryUseVochers { get; set; }
        public List<T_HistoryGetGiftUserRotaionLuck> t_HistoryGetGiftUserRotaionLucks { get; set; }
        public List<T_HistoryTurnRotaionLuck> t_HistoryTurnRotaionLucks { get; set; }
        public List<T_TakeTurnsRotaionLuck> t_TakeTurnsRotaionLucks { get; set; }
    }
}
