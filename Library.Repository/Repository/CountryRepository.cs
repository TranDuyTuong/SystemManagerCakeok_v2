using Library.DataTable.TableUser;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.User_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class CountryRepository : GenericRepository<T_Country>, ICountryRepository
    {
        public CountryRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
