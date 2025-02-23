# Microservices(PlatformService) API with .NET 8, Asynchronous inter-service communication(RabbitMQ), Publishing messages(MassTransit), Docker, Kubernetes, Repository, gRPC, EFCore and MSSQL.

The Project covers database storage with MSSQL, implementing repository patterns, using Docker and Kubernetes for containerization, and configuring dependency injection. It also addresses microservice preparation, synchronous and asynchronous inter-service communication, leveraging tools like Postman, IHttpClientFactory, MassTransit, gRPC for Http2/TLS communication and RabbitMQ, with a focus on code reuse and Docker Compose.

## Table of Contents

- [Getting Started](#getting-started)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/)

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/mizanurrahman13/PlatformService.git
   ```
2. Navigate to the project directory
   ```sh
   cd PlatformService
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```

## Migration and Docke & Kubernetes Stuff

Follow Docs Folder Commands file.

## Architecture Overview

Our project includes database storage with MSSQL, repository patterns, and containerization with Docker and Kubernetes. We set up dependency injection and prepare for both synchronous and asynchronous inter-service communication using RabbitMQ and MassTransit. We employ gRPC for service communication, EFCore for data access, and prioritize code reuse and best practices for scalability and maintainability.

## Features

- **Built with .NET 8**: Utilizes the latest features for efficient development.
- **RabbitMQ**: RabbitMQ facilitates reliable, scalable, and efficient communication between distributed systems through message queuing, ensuring robust asynchronous processing and integration.
- **MassTransit**: MassTransit simplifies the development and management of messaging patterns in .NET applications, enhancing scalability, reliability, and maintainability through seamless integration with message brokers like RabbitMQ.
- **Docker**: Docker provides a lightweight and consistent environment for application development and deployment, enabling portability, scalability, and efficient resource utilization across different platforms.
- **Kubernetes**: Kubernetes automates deployment, scaling, and management of containerized applications.
- **Repository**: Provides abstraction and simplifies data access logic.
- **CORS**: CORS (Cross-Origin Resource Sharing) enhances web security by allowing browsers to make requests to different origins only when explicitly permitted, preventing unauthorized data access.
- **gRPC**: gRPC enables fast, efficient, cross-platform communication with strong API contracts.
- **EF Core**: EFCore streamlines data access, supports LINQ queries, and optimizes performance.
- **MSSQL**: MSSQL ensures data integrity, security, scalability, and powerful querying capabilities.

## Technologies Used

- **.NET 8**
- **RabbitMQ**
- **MassTransit**
- **Docker**
- **Kubernetes**
- **Repository Pattern**
- **CORS**
- **gRPC**
- **EF Core**
- **MSSQL**

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Create a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.

