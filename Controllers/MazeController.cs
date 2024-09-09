using Microsoft.AspNetCore.Mvc;
using System;

namespace MazePathfinder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MazeController : ControllerBase
    {
        private readonly MazeService _mazeService;

        public MazeController(MazeService mazeService)
        {
            _mazeService = mazeService;
        }

        /// <summary>
        /// Submits a new maze configuration and returns the solution.
        /// </summary>
        /// <param name="mazeConfiguration">The maze configuration string.</param>
        /// <returns>The maze object with its solution, if found.</returns>
        /// <response code="200">Returns the maze object with its solution</response>
        /// <response code="400">If the maze configuration is invalid</response>
        [HttpPost]
        [ProducesResponseType(typeof(Maze), 200)]
        [ProducesResponseType(400)]
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

        /// <summary>
        /// Retrieves all previously submitted mazes and their solutions.
        /// </summary>
        /// <returns>A list of all mazes and their solutions.</returns>
        /// <response code="200">Returns the list of all mazes</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Maze>), 200)]
        public IActionResult GetAllMazes()
        {
            return Ok(_mazeService.GetAllMazes());
        }
    }
}