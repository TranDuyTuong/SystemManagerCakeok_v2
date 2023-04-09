using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.DataEF
{
    public class ContextDBFactoryCakeOk : IDesignTimeDbContextFactory<ContextDBCakeOk>
    {
        public ContextDBCakeOk CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionstring = configuration.GetConnectionString("DB_CakeOk");
            var optionBuilder = new DbContextOptionsBuilder<ContextDBCakeOk>();
            optionBuilder.UseSqlServer(connectionstring);
            return new ContextDBCakeOk(optionBuilder.Options);
        }
    }
}
