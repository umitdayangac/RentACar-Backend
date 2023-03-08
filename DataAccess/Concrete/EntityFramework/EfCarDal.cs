using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal:EntityRepositoryBase<Car,ContextDb>,ICarDal
{
    public List<CarDetailDto> GetDetailDto()
    {
        using var context = new ContextDb();
        var result = from car in context.Cars
            join brand in context.Brands on car.BrandId equals brand.Id
            join color in context.Colors on car.ColorId equals color.Id
            select new CarDetailDto()
            {
                CarName = car.Description,
                BrandName = brand.Name,
                ColorName = color.Name,
                DailyPrice = car.DailyPrice
            };
        return result.ToList();
    }
}