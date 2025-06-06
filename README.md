# Driving and Vehicle License Department (DVLD) System



## About

The DVLD System is a comprehensive desktop application designed to manage all aspects of driving licenses and vehicle registration. This Windows Forms application is built using C# and follows a three-tier architecture with separate layers for presentation, business logic, and data access.

The system serves as a complete solution for government driving and vehicle license departments, allowing efficient management of people records, driving licenses, tests, and users with different access levels.

## Key Features

### User Management
Secure login system with role-based access control for different staff members.

![Login Screen](screenshots/Login.png)
![Main Screen](screenshots/Main.png)

### People Management
Complete database of citizens with personal information and history.

![People Management](screenshots/People.png)

### New License Applications
Manage the entire process of new license applications including application forms, fees, and approval workflow.

### International License
Issue and manage international driving permits for citizens traveling abroad, with validity tracking and renewal options.

### Driver License Management
Issue, renew, and manage all types of driving licenses.

![Driving License](screenshots/LocalDrivingLicense.png)

### Driver Information
Comprehensive driver profiles with test history and license status.

![Drivers Information](screenshots/Drivers.png)


### Test Management
Schedule and record results for different types of driving tests.

![Test Management](screenshots/Test.png)

### License Detainment
Record and manage license detainments and releases.

![Detain License](screenshots/Detain.png)

### License Replacement
Process for handling lost or damaged license replacements.

![License Replacement](screenshots/Replacement.png)

### User Managment
Process for handling lost or damaged license replacements.

![License Replacement](screenshots/User.png)

## Architecture

The project follows a three-tier architecture:
- **Presentation Layer**: Windows Forms UI (DVLD project)
- **Business Layer**: Business logic and rules (DVLD_Business project)
- **Data Access Layer**: Database operations (DVLD_DataAccess project)

## Technologies Used

- C# Programming Language
- .NET Framework
- Windows Forms
- SQL Server Database
- ADO.NET for database connectivity

## Installation

1. Clone the repository
2. Open the solution in Visual Studio
3. Restore the database backup
4. Update the connection string in the configuration file
5. Build and run the application

## Default Login

- Username: admin
- Password: admin@123

## License

This project is licensed under the MIT License - see the LICENSE file for details. 