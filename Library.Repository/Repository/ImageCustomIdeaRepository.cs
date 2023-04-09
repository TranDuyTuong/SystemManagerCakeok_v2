using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class ImageCustomIdeaRepository : GenericRepository<T_ImageCustomIdea>, IimageCustomIdeaRepository
    {
        public ImageCustomIdeaRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
