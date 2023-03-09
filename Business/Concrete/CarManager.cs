using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
    
    public IDataResult<List<Car>> GetAll()
    {
         return new SuccessDataResult<List<Car>>(_carDal.GetAll());
    }

    public IDataResult<Car> GetById(int id)
    {
        return new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id));
    }

    public IResult Add(Car car)
    {
        _carDal.Add(car);
        return new SuccessResult();
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult();
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult();
    }

    public IDataResult<List<CarDetailDto>> GetDetailDto()
    {
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetDetailDto());
    }
}