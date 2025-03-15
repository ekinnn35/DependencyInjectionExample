# Dependency Injection Example

## Overview
This project demonstrates **Dependency Injection** in C# using ASP.NET Core. The application includes two primary entities: **Teacher** and **ClassRoom**, where a **ClassRoom** is associated with a **Teacher** through dependency injection.

## Features
- **Teacher Management**: Create and retrieve teacher details.
- **ClassRoom Management**: Assign a teacher to a classroom and retrieve information.
- **Swagger UI** integrated for easy API interaction.
- **Entity Framework Core** with **Code First Migration** for database management.

## Technologies Used
- **.NET 8.0**
- **ASP.NET Core Web API**
- **Entity Framework Core (EF Core)**
- **SQL Server**
- **Swagger UI**
- **Dependency Injection (DI)**

## Project Structure
```
DependencyInjectionExample
│── Context
│   ├── ApplicationDbContext.cs
│── Controllers
│   ├── TeacherController.cs
│   ├── ClassRoomController.cs
│── Entities
│   ├── Teacher.cs
│   ├── ClassRoom.cs
│── Interfaces
│   ├── ITeacher.cs
│── Models
│   ├── Teacher
│   │   ├── TeacherCreateRequest.cs
│   │   ├── TeacherResponse.cs
│   ├── ClassRoom
│   │   ├── ClassRoomCreateRequest.cs
│   │   ├── ClassRoomResponse.cs
│── Migrations
│── Properties
│── Program.cs
│── appsettings.json
```

## API Endpoints

### Teacher API
| Method | Endpoint | Description |
|--------|---------|-------------|
| POST   | `/api/Teacher` | Create a new teacher |
| GET    | `/api/Teacher/{id}` | Retrieve teacher details by ID |

### ClassRoom API
| Method | Endpoint | Description |
|--------|---------|-------------|
| POST   | `/api/ClassRoom` | Create a new classroom and assign a teacher |
| GET    | `/api/ClassRoom/{teacherId}` | Get classroom details based on the assigned teacher |



## Running the Project

. **Apply Migrations:**
   ```sh
  Add-Migration InitialCreate
  Update-Database
   ```

 **Open Swagger UI:**
   Navigate to `https://localhost:7252/swagger/index.html`

## Contact
📩 **Email:** ekinn.9193@gmail.com  
💼 **LinkedIn:** [Ekin Öztürk](https://www.linkedin.com/in/ekin-%C3%B6zt%C3%BCrk-a06659249/)

