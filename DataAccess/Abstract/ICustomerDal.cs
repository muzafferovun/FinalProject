﻿using Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    internal interface ICustomerDal : IEntityRepository<Customer>
    {

    }
}
