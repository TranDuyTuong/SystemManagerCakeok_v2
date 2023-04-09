using Library.DataTable.TableUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRotationLuck
{
    public class T_TakeTurnsRotaionLuck
    {
        public int IDTurns { get; set; }
        public int AmountTakeTurn { get; set; }

        public Guid IDUser { get; set; }
        public T_Customer t_Customer { get; set; }
    }
}
