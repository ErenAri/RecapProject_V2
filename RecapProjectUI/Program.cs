using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using Entities.Concrete;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            BrandTest();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customers
            {
                UserId = 1,
                CompanyName = "SpaceX"
            });

            RentalManager rentalManager = new RentalManager();
            rentalManager.Add(new Rentals
            {
                RentalId = 1,
                CarId = 1,
                CustomerId = 1,
                RentDate = 2021,
                ReturnDate = 2021
            });



            Console.ReadLine();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brands in brandManager.GetAll())
            {
                Console.WriteLine(brands.BrandName);
            }
        }

        private static void CarTest()
        {
            ICarService carService = new CarManager(new EfCarDal());
            carService.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 0,
                ModelYear = 1919,
                Description = "Transformer"
            });

            //foreach (var car in carService.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine("Bilgiler;");
            //    Console.WriteLine("******************************");
            //    Console.WriteLine("Arabanın Marka ve Modeli: {0} Arabanın Yılı: {1} Günlük Ücret: {2}", car.Description,
            //        car.ModelYear, car.DailyPrice);
            //    Console.WriteLine("******************************");
            //    Console.WriteLine("Kapatmak için enter'a basın");
            //}
        }
    }
}
