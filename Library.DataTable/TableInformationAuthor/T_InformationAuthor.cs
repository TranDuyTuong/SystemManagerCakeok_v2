using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataTable.TableInformationAuthor
{
    public class T_InformationAuthor
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] ContentImage { get; set; }
        public string NameImage { get; set; }
        public string MimeType { get; set; }
        public string TypeFile { get; set; }

        public int IDPosition { get; set; }
        public T_Position t_Position { get; set; }
    }
}
