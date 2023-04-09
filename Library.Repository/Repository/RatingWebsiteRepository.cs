using Library.DataTable.TableRating;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Rating_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class RatingWebsiteRepository : GenericRepository<T_RatingWebsite>, IRatingWebsiteRepository
    {
        public RatingWebsiteRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
