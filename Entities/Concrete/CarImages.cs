using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImages:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public int Date { get; set; }
        public string ImageCount { get; set; }
    }
}
