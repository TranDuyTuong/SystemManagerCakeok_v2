using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Repository
{
    public class CheckLoginLogoutRepository: GenericRepository<T_CheckLoginLogout>, ICheckLoginLogoutRepository
    {
        public CheckLoginLogoutRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
