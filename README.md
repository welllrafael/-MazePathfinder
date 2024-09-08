# Maze Pathfinder API

This API allows users to submit maze configurations and retrieve solutions.

## Setup

1. Ensure you have .NET 6 SDK installed
2. Clone this repository
3. Navigate to the project directory
4. Run `dotnet build` to build the project
5. Run `dotnet run --project MazePathfinder` to start the API

## API Endpoints

- POST /api/maze: Submit a new maze configuration
- GET /api/maze: Get all previously submitted mazes and their solutions

## Running Tests

Navigate to the MazePathfinder.Tests directory and run `dotnet test`