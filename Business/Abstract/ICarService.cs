﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    IDataResult<List<Car>> GetAll();
    IDataResult<Car> GetById(int id);
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
    IDataResult<List<CarDetailDto>> GetDetailDto();
}