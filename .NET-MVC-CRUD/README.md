# Simple CRUD Application with ASP.NET Core MVC

## Description

This is a CRUD (Create, Read, Update, Delete) application built in C# using the ASP.NET Core MVC framework, allowing you to perform basic CRUD operations in a database. In this app, you can create, read, update, and delete products.

![image](https://github.com/PauloSaid/.NET-development/assets/103071726/329b9036-da21-4df6-b80c-f31e6f0b696d)


### Authorization

This application contains authentication and authorization services using Identity. This means that you can only perform each CRUD operation if you are authenticated and authorized for it. In the database, roles such as *User* and *Admin* have been created.
![image](https://github.com/PauloSaid/.NET-development/assets/103071726/b919beae-bc57-4cef-81f7-907c1de77d71)

![image](https://github.com/PauloSaid/.NET-development/assets/103071726/03508f7a-8a11-4f2b-864b-516dea3e8c92)


### Modal

For a better user experience, a modal is used to display additional information about the products, enhancing the application's performance.

![image](https://github.com/PauloSaid/.NET-development/assets/103071726/cdd88cab-f072-45fd-8747-9e2b614fc592)


### Globalization and Culture

The application supports globalization and culture settings, making it adaptable to different languages and cultures, although not all are fully implemented.

![image](https://github.com/PauloSaid/.NET-development/assets/103071726/87aa81d3-df93-4590-9fe7-7cb310d4987d)


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
