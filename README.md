# Reflection Demo App in C#

A console application demonstrating how to use **reflection** in C# to inspect and manipulate both built-in and custom types at runtime.

## 🧰 Technologies Used:
- C# .NET (Console App)
- System.Reflection
- Visual Studio 2022

## 📋 Description:

The application consists of two parts:

### 🔹 1. Reflection on the `System.String` class
- Displays class metadata: name, namespace, assembly, base type, interfaces
- Checks properties: whether the class is abstract, sealed, or generic

### 🔹 2. Reflection on a custom class `Country`
- Dynamically creates an instance using `Activator.CreateInstance`
- Invokes a method `GetCountryInfo()` using reflection
- Demonstrates reflection on a user-defined class

## ▶️ How to Run:
1. Open the solution in Visual Studio
2. Build and run the project (press `F5`)
3. Follow the console output

## 💡 Sample Output:

---

## 📌 Concepts Demonstrated:
- `Type` class and its properties
- `GetInterfaces()`, `IsSealed`, `IsAbstract`, `IsGenericType`
- `Activator.CreateInstance` for dynamic object creation
- `MethodInfo.Invoke` for runtime method execution

---

> This app is a useful example of how reflection can be used for dynamic behavior, inspection, or tooling in .NET applications.
