using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BranId { get; set; }
        public string BrandName { get; set; }
    }
}
