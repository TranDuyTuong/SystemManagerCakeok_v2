using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableRotationLuck
{
    public class T_RotationLuck
    {
        public Guid IDRotation { get; set; }
        public DateTime CreateDate { get; set; }
        public double PercentPage { get; set; }

        public Guid IDLuck { get; set; }
        public T_GiftLuck t_GiftLuck { get; set; }
    }
}
