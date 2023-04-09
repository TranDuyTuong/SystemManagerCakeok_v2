using Library.DataTable.TableBanner;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Banner_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class ImageBannerWebRepository : GenericRepository<T_ImageBannerWeb>, IimageBannerWebRepository
    {
        public ImageBannerWebRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
