using Library.DataTable.TableVocher;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.Vocher_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class HistoryUserGetVocherRepository : GenericRepository<T_HistoryUserGetVocher>, IHistoryUserGetVocherRepository
    {
        public HistoryUserGetVocherRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
