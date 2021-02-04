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

            ICarService carService = new CarManager(new EfCarDal());
            carService.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 0,
                ModelYear = 1919,
                Description = "Transformer"
            });
            foreach (var car in carService.GetCarsByBrandId(2))
            {
                Console.WriteLine("Bilgiler;");
                Console.WriteLine("******************************");
                Console.WriteLine("Arabanın Marka ve Modeli: {0} Arabanın Yılı: {1} Günlük Ücret: {2}", car.Description, car.ModelYear, car.DailyPrice);
                Console.WriteLine("******************************");
                Console.WriteLine("Kapatmak için enter'a basın");
            }

            Console.ReadLine();


        }
    }
}
