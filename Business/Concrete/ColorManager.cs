using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager : IColorService
{
    private IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IDataResult<List<Color>> GetAll()
    {
        return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
    }

    public IDataResult<Color> GetById(int id)
    {
        return new SuccessDataResult<Color>(_colorDal.Get(x => x.Id == id));
    }

    public IResult Add(Color color)
    {
        _colorDal.Add(color);
        return new SuccessResult();
    }

    public IResult Update(Color color)
    {
        _colorDal.Update(color);
        return new SuccessResult();
    }

    public IResult Delete(Color color)
    {
        _colorDal.Delete(color);
        return new SuccessResult();
    }
}