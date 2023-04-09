using Library.ViewModel.Admin.V_Marriage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Marriage
{
    public interface Imarriage
    {
        //get all marriage
        List<GetAllMarriage> GetAllMarriages();

        //create marriage
        NotificationMarriage CreateMarriage(CreateMarriage request);
    }
}
