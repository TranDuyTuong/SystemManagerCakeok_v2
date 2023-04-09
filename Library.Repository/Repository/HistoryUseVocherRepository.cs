using Library.DataTable.TableVocher;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Vocher_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class HistoryUseVocherRepository : GenericRepository<T_HistoryUseVocher>, IHistoryUseVocherRepository
    {
        public HistoryUseVocherRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
