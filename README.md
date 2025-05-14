# Course Management API 🚀  
**A .NET 7 Web API for CRUD operations on educational courses**  

🔹 **Description**:  
Backend service for an Angular-based course management system. Provides RESTful endpoints for creating, reading, updating, and deleting courses with SQL Server persistence. Developed as a proof-of-concept for Angular/.NET integration productivity.

🔹 **Key Features**:  
- **Full CRUD Operations**: Create, read, update, and delete courses  
- **Seed Data**: Pre-loaded sample courses via Entity Framework migrations  
- **CORS Enabled**: Configured for cross-origin requests from Angular frontend  
- **Validation**: Robust input validation for course operations  

🔹 **Tech Stack**:  
- **Framework**: .NET 7 Web API  
- **Database**: SQL Server with Entity Framework Core  
- **Authentication**: Trusted connection (can be extended to JWT)  

🔹 **Endpoints**:  
| Method | Route | Description |  
|--------|-------|-------------|  
| GET | `/api/courses` | Get all courses |  
| POST | `/api/courses` | Add new course |  
| PUT | `/api/courses/{id}` | Update existing course |  
| DELETE | `/api/courses/{id}` | Remove course |  
