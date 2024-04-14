Patient Management API

This repository contains an ASP.NET Core Web API project for managing patients and addresses. It uses Entity Framework Core (EF Core) for data access to interact with a relational database.

API Endpoints

List All Patients


HTTP GET: http://localhost:8080/adsweb/api/v1/patient/list
Displays a list of all patients, including their primary addresses, sorted in ascending order by their last name.
Get Patient by ID

HTTP GET: http://localhost:8080/adsweb/api/v1/patient/get/{id}
Retrieves data for a specific patient by ID, including the primary address.
Handles appropriate exceptions for invalid patient IDs.
Register New Patient

HTTP POST: http://localhost:8080/adsweb/api/v1/patient/register
Registers a new patient in the system.
Requires providing patient data in JSON format.
Update Patient

HTTP PUT: http://localhost:8080/adsweb/api/v1/patient/update/{id}
Retrieves and updates patient data by ID.
Handles appropriate exceptions for invalid patient IDs.
Delete Patient

HTTP DELETE: http://localhost:8080/adsweb/api/v1/patient/delete/{id}
Deletes a patient from the system by ID.
Handles appropriate exceptions for invalid patient IDs.
Search Patients

HTTP GET: http://localhost:8080/adsweb/api/v1/patient/search/{searchString}
Queries patients whose data matches the input search string.
List All Addresses

HTTP GET: http://localhost:8080/adsweb/api/v1/address/list
Displays a list of all addresses, including associated patient data, sorted in ascending order by city.
Technologies Used
ASP.NET Core Web API
Entity Framework Core (EF Core)
C#
JSON
SQL Server (or other compatible relational database)
Getting Started
To run the project locally:

Clone this repository:

git clone https://github.com/rkarimbd/cs489-lab7.git

Set up your database connection string in appsettings.json.

Build and run the project using Visual Studio or the .NET CLI:

dotnet build
dotnet run
