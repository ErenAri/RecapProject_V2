using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.Aspects.Autofac.Caching;

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

        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        [ValidationAspect(typeof(ProductValidator))]
        [ValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        IResult ICarService.Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CustomerAdded);
        }

        IResult ICarService.Delete(Car car)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            throw new NotImplementedException();
        }

        [CacheAspect]
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

        
        public IResult AddImage(Car carImages)
        {
            IResult result = BusinessRules.Run(CheckImageLimit(carImages.ImageCount));

            if (result!=null)
            {
                return result;
            }
            _carDal.AddImage(carImages);
            return new SuccessResult();
        }
        public IResult DeleteImage(Car car)
        {
            _carDal.DeleteImage(car);
            return new SuccessResult();
        }
        public IResult UpdateImage(Car car)
        {
            _carDal.UpdateImage(car);
            return new SuccessResult();
        }

        private IResult CheckImageLimit(int ImageCount)
        {
            var result = _carDal.GetAll(c => c.ImageCount == ImageCount).Count;
            if (result >=10)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }
            return new SuccessResult();
        }

        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
