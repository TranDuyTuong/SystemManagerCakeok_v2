using Library.ServiceAdmin.ServiceAdminInjection.Account;
using Library.ServiceAdmin.ServiceAdminInjection.City;
using Library.ServiceAdmin.ServiceAdminInjection.Country;
using Library.ServiceAdmin.ServiceAdminInjection.District;
using Library.ServiceAdmin.ServiceAdminInjection.Gender;
using Library.ServiceAdmin.ServiceAdminInjection.Marriage;
using Library.ServiceAdmin.ServiceAdminInjection.Role;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceAdmin
{
    public static class ServiceAdminDependency
    {
        public static IServiceCollection AddSerivceAdmin(this IServiceCollection services)
        {
            services.AddTransient<ICitys, Citys>();
            services.AddTransient<IDistrict, District>();
            services.AddTransient<ICountry, Country>();
            services.AddTransient<IGender, Gender>();
            services.AddTransient<Imarriage, Marriage>();
            services.AddTransient<Iroles, Roles>();
            services.AddTransient<IAccount, Account>();
            return services;
        }
    }
}
