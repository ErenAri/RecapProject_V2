using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            ICarService carService = new CarManager(new EfCarDal());
            carService.Add(new Car
            {
                BrandId = 2,
                ColorId = 4,
                DailyPrice = 0,
                ModelYear = 1925,
                Description = "Classic"
            });
            foreach (var car in carService.GetCarsByBrandId(2))
            {
                Console.WriteLine("Araba bilgileri");
                Console.WriteLine("Arabanın Marka ve Modeli: {0} Arabanın Yılı: {1} Günlük Ücret: {2}", car.Description, car.ModelYear, car.DailyPrice);
                Console.WriteLine("**********************************************************************************");
                Console.WriteLine("Devam etmek için enter'i tuşlayınız...");
            }

            Console.ReadLine();
        }
    }
}
