using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalService _rentalsService;
        public void Add(Rentals rentals)
        {
            if (rentals.RentDate>=rentals.ReturnDate)
            {
                Console.WriteLine("Araba kiralandı");
                _rentalsService.Add(rentals);
            }
            else
            {
                Console.WriteLine("Araba daha teslim edilmemiş");
            }
        }

        public void Returned(Rentals rentals)
        {
            Console.WriteLine("Araba teslim alındı");
            _rentalsService.Returned(rentals);
        }

        public void Update(Rentals rentals)
        {
            Console.WriteLine("Kontrat güncellendi");
            _rentalsService.Update(rentals);
        }
    }
}
