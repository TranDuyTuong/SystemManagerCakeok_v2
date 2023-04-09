using Library.ViewModel.Admin.V_Gender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin.ServiceAdminInjection.Gender
{
    public interface IGender
    {
        //get all gender
        List<GetAllGender> GetAllGender();

        //create gender
        NotificationGender CreateGender(CreateGender request);
    }
}
