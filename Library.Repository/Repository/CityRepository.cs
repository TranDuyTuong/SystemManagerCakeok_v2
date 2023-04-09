using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repository.Repository
{
    public class CityRepository : GenericRepository<T_City>, ICityRepository
    {
        public CityRepository(ContextDBCakeOk context) : base(context)
        {

        }

        public async Task<List<T_District>> GetAllDistrictByCityID(int IdCity)
        {
            var QueryDistrict = await context.t_Districts.Where(x => x.IDCity == IdCity).ToListAsync();
            return QueryDistrict;
        }
    }
}
