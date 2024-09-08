using System;
using System.Collections.Generic;
using System.Linq;

public class MazeService
{
    private readonly List<Maze> _mazes = new List<Maze>();

    public Maze AddMaze(string configuration)
    {
        var maze = new Maze
        {
            Id = Guid.NewGuid(),
            Configuration = configuration,
            Solution = SolveMaze(configuration)
        };
        _mazes.Add(maze);
        return maze;
    }

    public List<Maze> GetAllMazes() => _mazes;

    private List<string> SolveMaze(string configuration)
    {
        var lines = configuration.Split('\n');
        var maze = lines.Select(l => l.ToCharArray()).ToArray();
        var start = FindStart(maze);
        var path = new List<string>();

        if (DFS(maze, start.Item1, start.Item2, path))
        {
            return path;
        }

        return null;
    }

    private bool DFS(char[][] maze, int row, int col, List<string> path)
    {
        if (row < 0 || row >= maze.Length || col < 0 || col >= maze[0].Length || maze[row][col] == 'X')
            return false;

        if (maze[row][col] == 'G')
            return true;

        if (maze[row][col] != 'S' && maze[row][col] != '_')
            return false;

        maze[row][col] = 'V'; // Mark as visited

        string[] directions = { "Up", "Right", "Down", "Left" };
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, 1, 0, -1 };

        for (int i = 0; i < 4; i++)
        {
            if (DFS(maze, row + dx[i], col + dy[i], path))
            {
                path.Insert(0, directions[i]);
                return true;
            }
        }

        maze[row][col] = '_'; // Backtrack
        return false;
    }

    private Tuple<int, int> FindStart(char[][] maze)
    {
        for (int i = 0; i < maze.Length; i++)
        {
            for (int j = 0; j < maze[i].Length; j++)
            {
                if (maze[i][j] == 'S')
                    return Tuple.Create(i, j);
            }
        }
        throw new InvalidOperationException("Start point not found in maze");
    }
}