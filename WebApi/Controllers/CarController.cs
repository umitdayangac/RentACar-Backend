using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private CarManager _carManager;

    public CarController()
    {
        _carManager = new CarManager(new EfCarDal());
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _carManager.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    
    [HttpGet("getcardetail")]
    public IActionResult GetCarDetail()
    {
        var result = _carManager.GetDetailDto();
        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
}