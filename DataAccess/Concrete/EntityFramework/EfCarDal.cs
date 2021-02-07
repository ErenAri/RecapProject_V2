using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :EfEntityRepositoryBase<Car, RecapContext>,ICarDAL
    {
        public List<CarDetailDto> GetDetails()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = 
                    from car in context.Cars
                    join brand in context.Brands on car.BrandId  equals brand.BranId
                    join color in context.Colors on car.ColorId equals color.ColorId 
                    select new CarDetailDto()
                    {
                        CarName = car.CarName,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice
                    };
                
                return result.ToList();
            }
        }
    }
}
