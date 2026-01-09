# KwaValidator

KwaValidator is a simple and extensible .NET library for validating Angolan documents, starting with the **Bilhete de Identidade (BI)**, focused on performance, reusability and framework independence.

---

| Package | Version | Downloads |
| ------ | ------- | --------- |
| `KwaValidator` | [![NuGet](https://img.shields.io/nuget/v/KwaValidator.svg)](https://nuget.org/packages/KwaValidator) | [![NuGet](https://img.shields.io/nuget/dt/KwaValidator.svg)](https://nuget.org/packages/KwaValidator) |

---

## Installation

This package is available through NuGet Packages:  
https://www.nuget.org/packages/KwaValidator

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

- This project is licensed under the MIT License, allowing commercial and personal use, modification, distribution, and private or public projects.