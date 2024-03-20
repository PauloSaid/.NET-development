# Simple CRUD Application with ASP.NET Core MVC

## Description

This is a CRUD (Create, Read, Update, Delete) application built in C# using the ASP.NET Core MVC framework, allowing you to perform basic CRUD operations in a database. In this app, you can create, read, update, and delete products.

### Authorization

This application contains authentication and authorization services using Identity. This means that you can only perform each CRUD operation if you are authenticated and authorized for it. In the database, roles such as *User* and *Admin* have been created.

### Modal

For a better user experience, a modal is used to display additional information about the products, enhancing the application's performance.

### Globalization and Culture

The application supports globalization and culture settings, making it adaptable to different languages and cultures, although not all are fully implemented.

### Image Upload

You can upload images to describe your products, enhancing their visual representation.

## Getting Started

To run the application locally, follow these steps:

1. Clone the repository: `git clone https://github.com/PauloSaid/.NET-MVC-CRUD.git`
2. Navigate to the project directory: `cd '.NET-MVC-CRUD'`
3. Install dependencies: `dotnet restore`
4. Run the application: `dotnet run`

## Technologies Used

- ASP.NET Core MVC
- C#
- Entity Framework Core
- Identity
- Bootstrap (for styling)
- JavaScript (for modal functionality)