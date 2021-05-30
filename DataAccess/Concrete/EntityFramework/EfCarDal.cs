using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext rentACarContext = new RentACarContext())
            {
                var result = from c in rentACarContext.Cars
                             join co in rentACarContext.Colors
                             on c.ColorId equals co.ColorId
                             join b in rentACarContext.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 ColorName = co.ColorName,
                                 BrandName=b.BrandName,
                                 DailyPrice=c.DailyPrice
                                 
                             };
                return result.ToList();
            }
        }

    }
}
