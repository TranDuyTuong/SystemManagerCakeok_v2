using Library.DataTable.TableRotationLuck;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class BannerRotationLuckRepository : GenericRepository<T_BannerRotationLuck>, IBannerRotationLuckRepository
    {
        public BannerRotationLuckRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
