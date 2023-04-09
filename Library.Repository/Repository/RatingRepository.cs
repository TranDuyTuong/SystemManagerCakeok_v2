using Library.DataTable.TableRating;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Rating_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class RatingRepository : GenericRepository<T_Rating>, IRatingRepository
    {
        public RatingRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
