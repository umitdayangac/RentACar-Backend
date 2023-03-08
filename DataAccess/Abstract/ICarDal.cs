using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface ICarDal : IEntityRepository<Car>
{
    List<CarDetailDto> GetDetailDto();
}