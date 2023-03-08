using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    Car GetById(int id);
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);
    List<CarDetailDto> GetDetailDto();
}