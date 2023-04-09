using Library.DataTable.TableVocher;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Vocher_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class VocherRepository : GenericRepository<T_Vocher>, IVocherRepository
    {
        public VocherRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
