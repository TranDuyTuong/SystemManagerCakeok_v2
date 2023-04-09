using Library.DataTable.TableRotationLuck;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class HistoryGetGiftUserRotaionLuckRepository : GenericRepository<T_HistoryGetGiftUserRotaionLuck>, IHistoryGetGiftUserRotaionLuckRepository
    {
        public HistoryGetGiftUserRotaionLuckRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
