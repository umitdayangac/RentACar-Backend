using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private ICarService _carService;


    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result =  _carService.GetAll();
        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
    
    [HttpGet("getcardetail")]
    public IActionResult GetCarDetail()
    {
        var result =  _carService.GetDetailDto();
        if (result.Success)
        {
            return Ok(result);
        }

        return BadRequest(result);
    }
}