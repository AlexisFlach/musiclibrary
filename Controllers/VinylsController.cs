using Microsoft.AspNetCore.Mvc;

using webapi.Repositories;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VinylsController : ControllerBase
{

    private readonly IVinylRepository _repository;

    public VinylsController(IVinylRepository repo)
    {
        _repository = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetVinyls()
    {
        var vinyls = await _repository.GetVinyls();

        return Ok(vinyls);
    }
}
