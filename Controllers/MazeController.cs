using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MazeController : ControllerBase
{
    private readonly MazeService _mazeService;

    public MazeController(MazeService mazeService)
    {
        _mazeService = mazeService;
    }

    [HttpPost]
    public IActionResult SubmitMaze([FromBody] string mazeConfiguration)
    {
        try
        {
            var maze = _mazeService.AddMaze(mazeConfiguration);
            return Ok(maze);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllMazes()
    {
        return Ok(_mazeService.GetAllMazes());
    }
}