using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        void Add(Rentals rentals);
        void Update(Rentals rentals);
        void Returned(Rentals rentals);
    }
}
