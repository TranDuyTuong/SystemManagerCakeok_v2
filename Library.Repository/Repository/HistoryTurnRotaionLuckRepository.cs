using Library.DataTable.TableRotationLuck;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class HistoryTurnRotaionLuckRepository : GenericRepository<T_HistoryTurnRotaionLuck>, IHistoryTurnRotaionLuckRepository
    {
        public HistoryTurnRotaionLuckRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
