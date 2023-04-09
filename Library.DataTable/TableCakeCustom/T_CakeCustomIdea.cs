using Library.DataTable.TableCake;
using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableCakeCustom
{
    public class T_CakeCustomIdea
    {
        public int IDIdea { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }

        public Guid IDTypeCake { get; set; }
        public T_TypeCake t_TypeCake { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }

        public int IDSize { get; set; }
        public T_SizeCake t_SizeCake { get; set; }

        public int IDStatusIdea { get; set; }
        public T_StatusIdea t_StatusIdea { get; set; }


        //
        public List<T_CustomCake> t_CustomCakes { get; set; }
        public List<T_ImageCustomIdea> t_ImageCustomIdeas { get; set; }
        public List<T_NotificationCustomCake> t_NotificationCustomCakes { get; set; }
    }
}
