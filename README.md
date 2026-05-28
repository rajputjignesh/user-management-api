# User Management API

This project is a simple REST API built using ASP.NET Core (.NET). The API allows users to perform CRUD operations such as creating, reading, updating, and deleting user data.

## Features

* GET all users
* GET user by ID
* POST new user
* PUT update existing user
* DELETE user
* Input validation
* Middleware logging
* RESTful API structure

## Technologies Used

* ASP.NET Core (.NET 6/8)
* C#
* GitHub
* GitHub Copilot

## API Endpoints

| Method | Endpoint      | Description    |
| ------ | ------------- | -------------- |
| GET    | `/users`      | Get all users  |
| GET    | `/users/{id}` | Get user by ID |
| POST   | `/users`      | Add a new user |
| PUT    | `/users/{id}` | Update user    |
| DELETE | `/users/{id}` | Delete user    |

## Validation

The API validates:

* User name should not be empty
* Email must contain a valid format

## Middleware

Middleware is used for:

* Logging incoming requests

## How to Run the Project

### Step 1: Install .NET SDK

Download and install .NET SDK from:
https://dotnet.microsoft.com/download

### Step 2: Run the Project

Open terminal in the project folder and run:

```bash id="x8m3qa"
dotnet run
```

### Step 3: Access API

```text id="z2n7wr"
https://localhost:5001/users
```

## GitHub Copilot Usage

GitHub Copilot was used to:

* Debug API routes
* Improve validation logic
* Suggest middleware implementation
* Improve code structure

## Future Improvements

* Add database integration (SQL Server/MongoDB)
* Implement JWT Authentication
* Add Swagger Documentation
* Improve error handling

## Author

Jignesh Bhoi
