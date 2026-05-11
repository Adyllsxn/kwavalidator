<div align="center">

<img src="./assets/kwa002.svg" alt="KwaValidator Logo" width="180" />

# KwaValidator

**Simple, fast and extensible validation library for Angolan documents in .NET**

[![NuGet Version](https://img.shields.io/nuget/v/KwaValidator.svg)](https://www.nuget.org/packages/KwaValidator)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KwaValidator.svg)](https://www.nuget.org/packages/KwaValidator)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

</div>

---

## **✨ OVERVIEW**

> **KwaValidator** is a lightweight and framework-independent .NET library designed to validate Angolan documents with high performance and clean architecture principles.

Currently supported:

- 🇦🇴 Bilhete de Identidade (BI)

Planned support:

- NIF
- Passport
- Driver License

---

## 🚀 Features

- ⚡ High performance validation
- 🧩 Extensible architecture
- 🔒 Framework independent
- 🧼 Clean and reusable API
- ❌ No forced exceptions
- 🔧 Easy integration with any .NET project

---

# 📦 Installation

Install via NuGet Package Manager:

## Package Manager
```powershell
Install-Package KwaValidator
```

### NuGet
```powershell
Install-Package KwaValidator
```

**.NET CLI**
```
dotnet add package KwaValidator
```

## How to use
```csharp
using KwaValidator.Services;

var validator = new BiValidator();

var result = validator.Validate("123456789LA001");

if (!result.IsValid)
{
    Console.WriteLine(result.ErrorMessage);
    return;
}

Console.WriteLine($"Valid BI - Province: {result.Province!.Name}");
```

### KwaValidator does not force
- Exceptions
- HTTP Status Codes
- Specific return types
- Any framework

**You decide how to consume the validation result.**  

---

## 👨‍💻 Author
**Domingos Nascimento (Adyllsxn)**  

- [LinkedIn](https://www.linkedin.com/in/adyllsxn/)  
- [GitHub](https://github.com/Adyllsxn)  

---

## 📄 License

> This project is licensed under the MIT License, allowing commercial and personal use, modification, distribution, and private or public projects.
