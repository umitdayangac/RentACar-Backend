using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager  :ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    
    public List<Car> GetAll()
    {
         return _carDal.GetAll();
    }

    public Car GetById(int id)
    {
        return _carDal.Get(x => x.Id == id);
    }

    public void Add(Car car)
    {
        _carDal.Add(car);
    }

    public void Update(Car car)
    {
        _carDal.Update(car);
    }

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }

    public List<CarDetailDto> GetDetailDto()
    {
        return _carDal.GetDetailDto();
    }
}