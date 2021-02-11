using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.Concrete
{
    public class Rentals:IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public decimal RentDate { get; set; }
        public decimal ReturnDate { get; set; }
    }
}
