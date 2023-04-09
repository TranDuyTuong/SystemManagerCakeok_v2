using Library.DataTable.TableCakeCustom;
using Library.DomainData.DataEF;
using Library.InterfaceRepository.Interface.CakeCustom_Repo;
using Library.Repository.Generic;

namespace Library.Repository.Repository
{
    public class NotificationCustomCakeRepository : GenericRepository<T_NotificationCustomCake>, INotificationCustomCakeRepository
    {
        public NotificationCustomCakeRepository(ContextDBCakeOk context) : base(context)
        {

        }
    }
}
