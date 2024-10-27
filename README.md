# Library Management System
A modern ASP.NET Core web application for managing library operations, built with MongoDB integration for efficient data management.

## 🚀 Overview
This web application provides a streamlined solution for libraries to manage their book inventory and subscriber operations. Built using ASP.NET Core Razor Pages architecture, it offers a robust platform for handling book loans, returns, and subscriber management with MongoDB as the backend database.

## ✨ Key Features
- Book Management
  - Add new books to the library inventory
  - Track book details (ID, Name, Category, Author)
  - View complete book catalog
- Subscriber Management
  - Register new library subscribers
  - Track subscriber information (First Name, Last Name)
  - Maintain subscriber borrowing history
- Lending Operations
  - Loan books to subscribers
  - Process book returns
  - Enforce maximum lending limit (3 books per subscriber)
  - Track borrowed books per subscriber

## 🛠 Technical Stack
- **Framework**: ASP.NET Core Razor Pages
- **Database**: MongoDB
- **Language**: C#
- **Architecture**: Model-View-PageModel pattern

## 📚 Core Components

### Models
- `Books`: Manages book information
- `Subscribers`: Handles subscriber data
- `BookDatabaseSettings`: MongoDB configuration for books
- `SubscribersDatabaseSettings`: MongoDB configuration for subscribers

### Services
- `BookService`: Handles book-related operations
  - Insert new books
  - Retrieve book by ID
  - Get all books
- `SubscribersService`: Manages subscriber operations
  - Register new subscribers
  - Update subscriber information
  - Track book loans
  - Retrieve subscriber details

### Page Models
- `ManageModel`: Handles book and subscriber registration
- `BookActionsModel`: Processes book loans and returns
- `DisplayModel`: Shows books and subscribers listings

## 💾 Database Structure

### Books Collection
- Id (int)
- BookName (string)
- Category (string)
- Author (string)

### Subscribers Collection
- Id (int)
- firstName (string)
- lastName (string)
- booksId (List<int>)

## 🔧 Setup Requirements
- .NET Core SDK
- MongoDB Server
- IDE (Visual Studio recommended)
