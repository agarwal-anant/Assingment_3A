# LMS Web API Project

This document provides an overview and instructions for setting up, running, and interacting with the LMS (Library Management System) Web API.

---

## Prerequisites

Ensure the following tools are installed on your machine:

1. **.NET SDK 8.0** or later.
2. A code editor such as [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/).
3. [Postman](https://www.postman.com/) or any REST client for testing the API.

---

## Project Structure

The LMS project consists of the following key files:

- **program.cs**: Configures the web application and middleware.
- **LibraryFactory.cs**: Contains a factory class to create instances of the `Library` class.
- **Library.cs**: Implements the main `Library` class that manages books.
- **Book.cs**: Defines the `Book` model with properties such as `Id`, `Title`, `Author`, `Year`, and `ISBN`.
- **LibraryController.cs**: Implements the API endpoints to interact with the library.
- **LMS.csproj**: Specifies project dependencies and build configuration.

---

## Installation and Setup

1. Clone or download the repository to your local machine.
2. Navigate to the project directory in the terminal.
3. Restore dependencies using the following command:
   ```bash
   dotnet restore
   ```

---

## Running the Application

1. Start the application by running:
   ```bash
   dotnet run
   ```

2. Once the application is running, it will be hosted at `https://localhost:5001` (or another specified port). The Swagger UI will be available at `https://localhost:5001/swagger` to test and interact with the API.

---

## API Endpoints

### Base URL
All endpoints are prefixed with:
```
https://localhost:5001/api/library
```

### 1. **Get All Books**
   - **Method**: `GET`
   - **Endpoint**: `/`
   - **Description**: Retrieves a list of all books in the library.
   - **Response**: JSON array of books.

### 2. **Get Book by ID**
   - **Method**: `GET`
   - **Endpoint**: `/{id}`
   - **Description**: Retrieves a book by its ID.
   - **Response**: JSON object of the requested book or `404 Not Found` if the book does not exist.
   - 
### 3. **Add a Book**
   - **Method**: `POST`
   - **Endpoint**: `/`
   - **Description**: Adds a new book to the library.
   - **Request Body**:
     ```json
     {
       "id": 1,
       "title": "Book Title",
       "author": "Author Name",
       "year": 2025,
       "isbn": "123-4567890123"
     }
     ```
   - **Response**: JSON object of the created book with a `201 Created` status.

### 4. **Remove a Book**
   - **Method**: `DELETE`
   - **Endpoint**: `/{id}`
   - **Description**: Removes a book by its ID.
   - **Response**: `204 No Content` if successful or `404 Not Found` if the book does not exist.

---

## Testing the API

Use tools like [Postman](https://www.postman.com/) or [cURL](https://curl.se/) to test the endpoints.

### Example with cURL:

1. **Add a Book**:
   ```bash
   curl -X POST https://localhost:5001/api/library \
   -H "Content-Type: application/json" \
   -d '{"id":1,"title":"Example Book","author":"John Doe","year":2025,"isbn":"123-4567890123"}'
   ```

2. **Get All Books**:
   ```bash
   curl https://localhost:5001/api/library
   ```

3. **Delete a Book**:
   ```bash
   curl -X DELETE https://localhost:5001/api/library/1
   ```

---

## Notes

- The project uses **Swagger** to generate API documentation and a UI for testing the endpoints.
- Ensure HTTPS is enabled while interacting with the API.
- Customize the `Library` class as needed to extend functionality.

---

## License
This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

