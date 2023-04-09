using Library.ViewModel.Admin.V_Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Country
{
    public interface ICountry
    {
        //get all countrys
        List<GetAllCountry> GetAllCountry();

        //cretae country
        NotificationCountry CreateCountry(CreateCountry request);

        //create muplite Coutry
        NotificationCountry CreateMupliteCountry(List<CreateCountry> request);

        //get ten country
        List<GetAllCountry> GetTenCountry();
    }
}
