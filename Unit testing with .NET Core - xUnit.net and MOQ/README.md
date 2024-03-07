# Test in ASP.NET Core

## Most common types of testing used in software development.

• [Unit Testing](#unit-testing)

• [Integration Testing](#integration-testing)

• [Automated Testing](#automated-testing)

• [Load Testing](#load-testing)

## Frameworks

• [xUnit](#xunit)

• [Moq](#moq)

## Getting Started

• [Creating a Project](#creating-a-project)

• [First Test](#first-test)

---


### Unit Testing

Unit testing is a software testing practice where individual units or components of the code are tested in isolation. The goal is to validate that each unit functions as expected.

### Integration Testing

Integration testing is a type of software testing where individual units are combined and tested as a group. The goal is to verify that the units work together correctly.

### Automated Testing

Automated testing refers to software tests that are executed automatically, without manual intervention. They are often used in conjunction with agile development practices to ensure code quality.

### Load Testing

Load testing is a type of performance testing where the software is subjected to a significant workload to evaluate its behavior under intensive use conditions.

---

### xUnit

The xUnit testing framework is the premier framework for building automated tests in C# and .NET.

XUnit encourages the use of test classes with constructor injection. This allows for better management of test dependencies and integration with dependency injection frameworks, facilitating easier and more modular testing.

For installation porpuses, you can [learn how to download xUnit.net](#xunit-installation)

### MOQ

Mocking is a process used in unit testing when the unit being tested has external dependencies.
The purpose of mocking is to isolate and focus on the code being tested and not on the behavior or state of external dependencies.
Because of this, we use MOQ.

Click [here](#moq-installation) for installation.

---

### xUnit Installation

Framework:
```bash
	Install-Package xunit
```

Installation for Visual Studio runner:
```bash
	Install-Package xunit.runner.visualstudio
```

### MOQ Installation

Framework:
```bash
	Install-Package Moq
```

---


### Creating a Project

From the command line, create a folder then create a project using dotnet new xunit.

### First testing

For good practing, it's important to allocate your code in three different parts.
Arrange: Create objects, instantiate, entities...
Act: Action, execute what you want to test.
Assert: Validate if the result it is what you are expectating.

Simple test:
```csharp
	// Arrange
		var controller = new TestController();

	// Act
		var result = controller.Index();

	// Assert
		Assert.IsType<ViewResult>(result);
```
Use `dotnet test` for run.
