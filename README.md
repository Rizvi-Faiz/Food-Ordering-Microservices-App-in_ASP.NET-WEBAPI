# Food Ordering Microservices App in ASP.NET Web API

This project is a microservices-based food ordering application built using **ASP.NET Web API** and **C#**. It follows a modular architecture, where each service is independently developed, making the system highly scalable, maintainable, and fault-tolerant.

## Services

The application consists of the following core microservices:

- **Auth API** (`ECommerce.Services.AuthAPI`): Handles user authentication and authorization, utilizing JWT tokens for secure access.
- **Coupon API** (`ECommerce.Services.CouponAPI`): Manages coupon codes and discount-related operations.
- **Product API** (`ECommerce.Services.ProductAPI`): Provides product catalog and inventory management functionalities.
- **Shopping Cart API** (`ECommerce.Services.ShoppingCartAPI`): Manages the shopping cart, including item additions, removals, and cart persistence.

Additionally, the project has:

- **ECommerce.Web**: A web front-end for interacting with the microservices.
- **Database**: A SQL Server database is used for persistence across various services.

## Features

- **Order Management**: Seamless processing of customer orders with real-time updates.
- **Authentication & Authorization**: Secured user management with JWT tokens.
- **Product Catalog**: Dynamic product listings with inventory management.
- **Discounts**: Easy-to-manage coupon codes and promotions.
- **Shopping Cart**: Robust cart system supporting multiple users and sessions.

## Architecture

- **Microservices**: Each core feature is built as a separate service, allowing for independent deployment and scaling.
- **Database**: SQL Server is used for relational data storage.
- **Message Queue**: Uses **RabbitMQ** for communication between services.
- **Containerization**: Services are containerized using **Docker** for seamless deployment and scaling.
- **API Gateway**: Acts as the entry point for all requests, routing them to the appropriate microservices.

## Tech Stack

- **ASP.NET Web API** for building RESTful services.
- **C#** as the primary programming language.
- **SQL Server** for data persistence.

## Prerequisites

- **Visual Studio 2022** or later
- **.NET 6.0 SDK** or later
- **SQL Server**

## Running the Application

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Rizvi-Faiz/Food-Ordering-Microservices-App-in_ASP.NET-WEBAPI.git


2. **Open the solution in Visual Studio**:
   Open the `ECommerce.sln` file in Visual Studio.

3. **Run the services**:
   - Use Visual Studio to run each service independently.
   - Alternatively, use Docker Compose to spin up the services in containers.

4. **Configure the database**:
   - Ensure SQL Server is running.
   - Update the connection strings in each microservice's configuration files.

## API Endpoints

- **Auth Service**: `/api/auth`
- **Coupon Service**: `/api/coupons`
- **Product Service**: `/api/products`
- **Shopping Cart Service**: `/api/cart`

## Contributing

Contributions are welcome! Feel free to fork the repository and submit a pull request with any improvements or bug fixes.
