# White Chapel Rental Service

## Overview

White Chapel Rental Service is a desktop-based vehicle rental management system developed using C# and Windows Forms in Microsoft Visual Studio.

The application was designed to streamline the day-to-day operations of a vehicle rental company by providing tools for managing vehicles, customers, rental agencies, rental transactions, returns, and user accounts. The system offers an intuitive graphical interface that enables staff members to efficiently track vehicle availability, process rentals, and maintain customer records.

---

## Features

### Vehicle Management

* Add new vehicles to the fleet
* Edit vehicle information
* Delete vehicles from inventory
* View vehicle details
* Display all available vehicles

### Customer Management

* Add tourist customers
* Maintain customer records
* View customer listings
* Remove customer accounts

### Agency Management

* Add rental agencies
* Manage agency information
* View registered agencies
* Delete agency records

### Rental Operations

* Rent vehicles to individual customers
* Rent vehicles to partner agencies
* Track active rentals
* View rented vehicle reports

### Return Processing

* Process vehicle returns from customers
* Process vehicle returns from agencies
* Automatically update vehicle availability

### User Administration

* Create user accounts
* Add and remove system users
* Change passwords
* Manage application access

### Reporting and Listings

* View all vehicles
* View all customers
* View all agencies
* View rented vehicle records
* Generate rental activity summaries

---

## Technologies Used

* C#
* Windows Forms (WinForms)
* .NET Framework
* Microsoft Visual Studio
* Object-Oriented Programming (OOP)

---

## Project Structure

```text
wvrs/
│
├── Vehicle.cs
├── TouristCust.cs
├── AgencyCompany.cs
├── RentCustomer.cs
├── RentCompany.cs
├── user.cs
│
├── AddVehicle.cs
├── EditVehicle.cs
├── DeleteVehicle.cs
├── ViewVehicle.cs
│
├── AddTouristCust.cs
├── DeleteTouristCust.cs
│
├── AddAgency.cs
├── DeleteAgency.cs
│
├── RentToCust.cs
├── RentToAgency.cs
├── ReturnFromCust.cs
├── ReturnFromAgency.cs
│
├── AddUser.cs
├── DeleteUser.cs
├── ChangePassword.cs
│
├── AllVehList.cs
├── AllCustList.cs
├── AllAgencyList.cs
├── AllRentedVehList.cs
│
├── Program.cs
├── App.config
└── wvrs.csproj
```

---

## System Design

The application follows an object-oriented approach where key business entities are represented through classes:

### Core Classes

* **Vehicle** – Stores vehicle information and availability.
* **TouristCust** – Represents individual customers.
* **AgencyCompany** – Represents partner rental agencies.
* **RentCustomer** – Handles customer rental transactions.
* **RentCompany** – Handles agency rental transactions.
* **user** – Manages system users and authentication.

---

## Installation

### Prerequisites

* Windows Operating System
* Microsoft Visual Studio 2017 or later
* .NET Framework

### Steps

1. Clone the repository:

```bash
git clone https://github.com/Skite720/White-Chapel-Rental-Service.git
```

2. Open the solution file:

```text
wvrs.sln
```

3. Build the project in Visual Studio.

4. Run the application using:

```text
Start Debugging (F5)
```

---

## Application Workflow

1. Login using a valid user account.
2. Add vehicles to the rental inventory.
3. Register customers and agencies.
4. Process vehicle rentals.
5. Track active rental records.
6. Process vehicle returns.
7. Generate reports and view rental statistics.

---

## Learning Outcomes

This project demonstrates practical experience with:

* Object-Oriented Programming
* Windows Desktop Application Development
* Event-Driven Programming
* CRUD Operations
* Data Management
* User Authentication
* Software Design Principles
* Business Process Automation

---

## Future Improvements

Potential enhancements include:

* SQL Server database integration
* Online booking functionality
* Vehicle maintenance tracking
* Payment processing system
* PDF invoice generation
* Email notifications
* Search and filtering capabilities
* Role-based access control
* Cloud data storage

---

## Author

**Ritvik Sethi**

GitHub: https://github.com/Skite720

---

## License

This project was developed for educational and academic purposes.
