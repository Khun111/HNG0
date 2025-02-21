# HNG0

## Description
HNG0 is a simple ASP.NET Core web application that provides a JSON response with user information and the current date and time. It also includes an endpoint to classify numbers and fetch fun facts about them.

## Setup Instructions

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Docker](https://www.docker.com/products/docker-desktop) (optional, for running in a container)

### Running the Project Locally

1. Clone the repository:
    ```sh
    git clone https://github.com/Khun111/HNG0.git
    cd HNG0
    ```

2. Restore the dependencies:
    ```sh
    dotnet restore
    ```

3. Build the project:
    ```sh
    dotnet build
    ```

4. Run the project:
    ```sh
    dotnet run
    ```

5. The application will be available at `http://localhost:5065`.

### Running with Docker

1. Build the Docker image:
    ```sh
    docker build -t hng0 .
    ```

2. Run the Docker container:
    ```sh
    docker run -p 8080:80 hng0
    ```

3. The application will be available at `http://localhost:8080`.

## API Documentation

### Home Endpoint

- **URL**: `/`
- **Method**: `GET`
- **Response Format**: JSON

#### Response
```json
{
    "email": "amure387@gmail.com",
    "current_datetime": "2023-10-01T12:00Z",
    "github_url": "https://github.com/Khun111/HNG0"
}

### Classify Endpoint

- **URL**: `/`
- **Method**: `GET`
- **Response Format**: JSON

#### Response
```json
{
    "number": 123,
    "is_prime": false,
    "is_even": false,
    "is_perfect": false,
    "properties": ["armstrong", "odd"],
    "digit_sum": 6,
    "fun_fact": "123 is the number of times a woodpecker can peck in a second."
}



## Additional Resources
For more information on hiring C# developers, visit [HNG Tech](https://hng.tech/hire/csharp-developers).