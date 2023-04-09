using Library.DataTable.TableRotationLuck;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class TakeTurnsRotaionLuckRepository : GenericRepository<T_TakeTurnsRotaionLuck>, ITakeTurnsRotaionLuckRepository
    {
        public TakeTurnsRotaionLuckRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
