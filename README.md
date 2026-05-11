<div align="center">

<img src="./assets/logotipo.svg" alt="KwaValidator Logo" width="30%" />

# **KwaValidator**

**Cross-platform validation library for Angolan documents**

[![NuGet Version](https://img.shields.io/nuget/v/KwaValidator.svg)](https://www.nuget.org/packages/KwaValidator)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KwaValidator.svg)](https://www.nuget.org/packages/KwaValidator)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

</div>

---

# ✨ Overview

> KwaValidator is a modern and extensible validation library focused on Angolan documents.

Built to be lightweight, fast and framework-independent, allowing integration across multiple ecosystems and programming languages.

### Currently Supported

- 🇦🇴 Bilhete de Identidade (BI)

### Planned Support

- NIF
- Passport
- Driver License

---

# 🚀 Features

- ⚡ Fast validation engine
- 🌍 Cross-platform architecture
- 🧩 Extensible document system
- 🔒 Framework independent
- 🧼 Clean and minimal API
- 📦 Multi-ecosystem support
- ❌ No forced exceptions
- 🔧 Easy integration

---

# 📦 Ecosystem

| Platform | Package |
|----------|----------|
| .NET | `KwaValidator` |
| Node.js | `kwavalidator` *(planned)* |
| Python | `kwavalidator` *(planned)* |

---

# 📥 Installation

## .NET

### NuGet
```powershell
Install-Package KwaValidator
```

### .NET CLI
```bash
dotnet add package KwaValidator
```

---

# 🛠️ Usage

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

---

# 📄 Philosophy

KwaValidator does not enforce:

- Exceptions
- HTTP status codes
- Frameworks
- Specific return patterns

You decide how validation should behave inside your application.

---

# 📜 License

Licensed under the MIT License.
