using System.Collections.Generic;
using System.Threading.Tasks;
using Cocoloko.Storing.Models;
using Cocoloko.Storing.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cocoloko.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BeverageController : ControllerBase
  {
    private readonly UnitOfWork _unitOfWork;

    public BeverageController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Beverage>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
      System.Console.WriteLine("logger");
      return Ok(await _unitOfWork.Beverage.SelectAsync());
    }
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Beverage), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(int id)
    {
      var beverage = await _unitOfWork.Beverage.SelectAsync(id);
      if (beverage != null)
      {
        return Ok(beverage);
      }
      else
      {
        return NotFound(id);
      }
    }
  }
}