using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDAL _carDal;

        public CarManager(ICarDAL carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (!(car.Description.Length < 2 && car.DailyPrice <= 0))
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Bilgileri kontrol ediniz");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetCarById(int id)
        {
            return _carDal.Get(car => car.Id == id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(car => car.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        IResult ICarService.Add(Car car)
        {
            throw new NotImplementedException();
        }

        IResult ICarService.Delete(Car car)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Car> ICarService.GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        IResult ICarService.Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
