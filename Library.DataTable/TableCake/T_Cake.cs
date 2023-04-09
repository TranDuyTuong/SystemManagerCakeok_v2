using Library.DataTable.TableChef;
using Library.DataTable.TableComment;
using Library.DataTable.TableOrder;
using Library.DataTable.TableRating;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCake
{
    public class T_Cake
    {
        public Guid IDCake { get; set; }
        public string NoCake { get; set; }
        public string NameCake { get; set; }
        public DateTime CreateDate { get; set; }
        public int View { get; set; }
        public int Buy { get; set; }
        public int Amount { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        //key
        public Guid IDKindCake { get; set; }
        public T_KindCake t_KindCake { get; set; }

        public int IDStatus { get; set; }
        public T_StatusCake t_StatusCake { get; set; }

        public int IDNewCake { get; set; }
        public T_NewCake t_NewCake { get; set; }

        public Guid IDPrice { get; set; }
        public T_CakePrice t_CakePrice { get; set; }

        public Guid IDTypeCake { get; set; }       
        public T_TypeCake t_TypeCake { get; set; }

        public int IDDiscount { get; set; }
        public T_DiscountCake t_DiscountCake { get; set; }

        public int IDElement { get; set; }
        public T_CakeElement t_CakeElement { get; set; }

        public int IDSmell { get; set; }
        public T_SmellCake t_SmellCake { get; set; }

        //list forigrkey
        public List<T_CakeGift> t_CakeGifts { get; set; }
        public List<T_CakeImage> t_CakeImages { get; set; }
        public List<T_ChefCake> t_ChefCakes { get; set; }
        public List<T_Comment> t_Comments { get; set; }
        public List<T_CartUser> t_CartUsers { get; set; }
        public List<T_OrderDetail> t_OrderDetails { get; set; }
        public List<T_Rating> t_Ratings { get; set; }
        public List<T_ViewerCakeUser> t_ViewerCakeUsers { get; set; }
    } 
}
