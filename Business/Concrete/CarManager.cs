using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

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
        throw new NotImplementedException();
    }

    public void Add(Car car)
    {
        throw new NotImplementedException();
    }

    public void Update(Car car)
    {
        throw new NotImplementedException();
    }

    public void Delete(Car car)
    {
        throw new NotImplementedException();
    }
}