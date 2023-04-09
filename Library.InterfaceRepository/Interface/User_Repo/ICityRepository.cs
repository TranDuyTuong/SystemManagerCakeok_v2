using Library.DataTable.TableUser;
using Library.InterfaceRepository.IGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.InterfaceRepository.Interface.User_Repo
{
    public interface ICityRepository: IGenericRepository<T_City>
    {
        Task<List<T_District>> GetAllDistrictByCityID(int IdCity);
    }
}
