# Maze Pathfinder API

This API allows users to submit maze configurations and retrieve solutions for pathfinding problems.

## Table of Contents

1. [Setup](#setup)
2. [Running the Application](#running-the-application)
3. [API Documentation](#api-documentation)
4. [Using Swagger UI](#using-swagger-ui)
5. [API Endpoints](#api-endpoints)
6. [Maze Configuration Format](#maze-configuration-format)
7. [Running Tests](#running-tests)
8. [Troubleshooting](#troubleshooting)

## Setup

1. Ensure you have .NET 6 SDK installed. You can download it from [here](https://dotnet.microsoft.com/download/dotnet/6.0).
2. Clone this repository:
3. Navigate to the project directory:


## Running the Application

1. Build the project:
2. Run the application:
3. The API will start running, typically on `https://localhost:5001` and `http://localhost:5000`. Depend of your setup

## API Documentation

When running the application, you can access the Swagger UI at:

This provides interactive documentation for the API endpoints.

## Using Swagger UI

1. Open your web browser and navigate to `https://localhost:5001/swagger`.
2. You'll see the Swagger UI with a list of available endpoints.
3. To test an endpoint:
   - Click on the endpoint you want to try.
   - Click the "Try it out" button.
   - If required, enter the necessary parameters.
   - Click "Execute".
   - Scroll down to see the response.

### Testing the POST /api/maze endpoint:

1. Click on the POST /api/maze endpoint.
2. Click "Try it out".
3. In the Request body, enter a maze configuration string. For example:

"S_________\nXXXXXXXX\nXX\nXXXXX_X\nXX__X_X\nXX__X_X\nXX____X\nXXXXXXX_\nX______\nXXXXXXXXG"

4. Click "Execute".
5. Scroll down to see the response, which should include the maze solution.

### Testing the GET /api/maze endpoint:

1. Click on the GET /api/maze endpoint.
2. Click "Try it out".
3. Click "Execute".
4. Scroll down to see the response, which should list all submitted mazes and their solutions.

## API Endpoints

- POST /api/maze: Submit a new maze configuration
- GET /api/maze: Get all previously submitted mazes and their solutions

## Maze Configuration Format

Mazes are represented as strings with the following format:


S_________
XXXXXXXX
XX
XXXXX_X
XX__X_X
XX__X_X
XX____X
XXXXXXX_
X_______
XXXXXXXXG_


Where:
- `S`: Start Point (exactly one)
- `G`: Goal Point (exactly one)
- `_`: Empty Space
- `X`: Wall

## Running Tests

Navigate to the MazePathfinder.Tests directory and run:


## Troubleshooting

- If you encounter HTTPS certificate errors, you may need to trust the development certificate:

- Ensure you're using the correct URL for Swagger UI. It should be `https://localhost:5001/swagger` unless you've configured a different port.
- If you're having issues with the POST request, make sure your maze configuration string is properly formatted and enclosed in quotes.

For any other issues, please open an issue in the GitHub repository.