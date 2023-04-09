using Library.DataTable.TableRotationLuck;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class RotationLuckRepository : GenericRepository<T_RotationLuck>, IRotationLuckRepository
    {
        public RotationLuckRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
