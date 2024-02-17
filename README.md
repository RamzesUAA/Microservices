# Commands for Platform app

## Overview

This project utilizes .NET 7 to build two microservices: CommandsService and PlatformService. These microservices communicate with each other via RabbitMQ and gRPC. Additionally, the project is deployed and running within a Kubernetes cluster.

## Technologies Used

- .NET 7
- RabbitMQ
- gRPC
- Kubernetes

## Microservices

### CommandsService

This microservice is responsible for handling commands within the system. It provides endpoints for receiving and processing commands from clients. Communication with other services is facilitated through RabbitMQ for messaging and gRPC for inter-service communication.

### PlatformService

The PlatformService microservice manages platform-related functionalities. It interacts with the CommandsService and performs various tasks related to platform management. Similar to the CommandsService, it utilizes RabbitMQ and gRPC for communication with other services.

## Communication

- **RabbitMQ**: Used for asynchronous messaging between microservices. Messages containing commands, events, or other data are exchanged through RabbitMQ queues.
- **gRPC**: Facilitates communication between microservices with efficient and high-performance RPC (Remote Procedure Call) mechanism. Services expose gRPC endpoints to interact with each other.

## Deployment

The project is deployed and running within a Kubernetes cluster. Kubernetes provides orchestration and management of containerized applications, ensuring scalability, reliability, and easy deployment.

## Setup and Configuration

To run this project locally or deploy it in your own Kubernetes cluster, follow these steps:

1. Install and configure .NET 7 SDK.
2. Set up RabbitMQ instance for messaging between microservices.
3. Configure Kubernetes cluster and deploy the application using Kubernetes manifests provided in the project.
4. Ensure proper network configuration to allow communication between microservices within the cluster.
5. Update any environment-specific configurations in the application settings or Kubernetes manifests.

## Usage

Once the project is deployed and running, you can interact with the microservices through their respective endpoints. Use the provided APIs to send commands, retrieve data, or perform other actions as per the application requirements.

## Contributing

Contributions to this project are welcome. If you find any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
