Temperature API

This is a simple Temperature API that generates a random temperature between 15°C and 45°C and returns the temperature data along with a timestamp. The API is rate-limited to prevent excessive requests and is configured to be accessed from a specific Angular client application. JWT authentication is implemented for secure access to endpoints.

Features

Random Temperature Generation: Returns a random temperature between 15°C and 45°C.

Rate Limiting:
Rate-limited to 100 requests per second for the /api/temperature endpoint.

CORS Configuration: 
Configured to allow requests from a specific Angular client.

JWT Authentication: 
Secures the API with JWT tokens for accessing temperature data.

Swagger Integration: 
Auto-generates API documentation in the development environment.

Requirements

.NET 6 or later for running the API.

Angular Client (if you plan to access it from an Angular app).

JWT Token for authentication (if JWT is enabled).

Installation

Clone the Repository
Clone the project to your local machine:

git clone https://your-repository-url.git
Install Dependencies
Open the project in Visual Studio or any other .NET-compatible IDE.

Run the following command to restore the dependencies:
dotnet restore
Configuration
1. Set Up CORS
The API is set up to allow requests from the Angular client running on http://localhost:4200. If you want to modify the allowed origins, change the AllowAngularClient CORS policy in Program.cs.

2. JWT Authentication (Optional)
If you're using JWT authentication, make sure you’ve configured the secret key and the issuer/audience in the JwtTokenService class.

Running the API
1. Run the API
You can run the API locally using:

dotnet run
This will start the application on https://localhost:5001 by default.

2. Accessing the API
Base URL: https://localhost:5001/api/temperature

Example Request
GET /api/temperature

Response:

json

{
    "temperature": 22.5,
    "unit": "celsius",
    "timestamp": "2025-06-17T19:00:00.0000000Z"
}

Rate Limiting
The API is rate-limited to 100 requests per second on the /api/temperature endpoint. You can configure this in the Program.cs file if needed.

Swagger API Documentation
In development mode, Swagger UI is available for easy exploration of the API. You can access it at:
https://localhost:5001/swagger
Error Handling
The API will respond with appropriate error messages in case of failures.

Internal Server Error (500): If something goes wrong on the server.

Unauthorized (401): If the JWT token is missing or invalid.

Example:

json

{
    "error": "Internal Server Error"
}
Dependencies
ASP.NET Core: Framework for building the API.

AspNetCoreRateLimit: Package used for rate limiting.

Swagger: Used for automatic API documentation.

Contributing
Fork the repository.

Create your feature branch (git checkout -b feature-name).

Commit your changes (git commit -am 'Add feature').

Push to the branch (git push origin feature-name).

Open a pull request.

License
This project is licensed under the MIT License - see the LICENSE file for details.
