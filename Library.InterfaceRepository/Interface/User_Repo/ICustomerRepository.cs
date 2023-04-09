﻿using Library.DataTable.TableUser;
using Library.InterfaceRepository.IGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.InterfaceRepository.Interface.User_Repo
{
    public interface ICustomerRepository : IGenericRepository<T_Customer>
    {
    }
}
