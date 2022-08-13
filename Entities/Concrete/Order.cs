﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderID { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime orderDate{ get; set; }
        public string ShipCity { get; set; }    

    }
}
