using Library.DataTable.TableRotationLuck;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.RotationLuck_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class GiftLuckRepository : GenericRepository<T_GiftLuck>, IGiftLuckRepository
    {
        public GiftLuckRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
