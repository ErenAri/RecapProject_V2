using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.Concrete
{
    public class Customers:IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
