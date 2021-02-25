using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDAl : ICarDAL
    {
        private List<Car> _cars;

        public InMemoryCarDAl()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 2,
                    ModelYear = 1918,
                    DailyPrice = 1200,
                    Description = "Classic",
                },
                new Car
                {
                    Id = 2,
                    BrandId = 3,
                    ColorId = 1,
                    ModelYear = 1922,
                    DailyPrice = 1150,
                    Description = "Classic",
                },
                new Car
                {
                Id = 3,
                BrandId = 2,
                ColorId = 3,
                ModelYear = 1939,
                DailyPrice = 940,
                Description = "Classic Sport",
                },
                new Car
                {
                    Id = 4,
                    BrandId = 4,
                    ColorId = 4,
                    ModelYear = 2023,
                    DailyPrice = 2000,
                    Description = "Super Sport",
                }
            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
            Console.WriteLine(entity.BrandId+" Id'li araba eklendi");
        }

        public void AddImage(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            Car deleteCar = _cars.SingleOrDefault(car => car.Id == car.Id);
            _cars.Remove(deleteCar);
            Console.WriteLine(entity.BrandId + " Id'li Araba silindi");
        }

        public void DeleteImage(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car updateCar = _cars.SingleOrDefault(car => car.Id == car.Id);
            updateCar.BrandId = entity.BrandId;
            updateCar.ColorId = entity.ColorId;
            updateCar.ModelYear = entity.ModelYear;
            updateCar.DailyPrice = entity.DailyPrice;
            updateCar.Description = entity.Description;
            Console.WriteLine(entity.BrandId+" Id'li Araba güncellendi");


        }

        public void UpdateImage(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
