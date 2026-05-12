<div align="center">

<img src="./docs/assets/logotipo.svg" alt="KwaValidator Logo" width="30%" />
</br>

</div>

**Cross-platform validation library for Angolan documents**

[![NuGet Version](https://img.shields.io/nuget/v/KwaValidator.svg)](https://www.nuget.org/packages/KwaValidator)
[![NuGet Downloads](https://img.shields.io/nuget/dt/KwaValidator.svg)](https://www.nuget.org/packages/KwaValidator)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

---


> KwaValidator is a modern and extensible validation library focused on Angolan documents.

> Built to be lightweight, fast and framework-independent, allowing integration across multiple ecosystems and programming languages.

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

## Choose your platform:

| Platform | Installation Guide |
|----------|-------------------|
| .NET | [Installation Guide](./docs/INSTALLATION-DOTNET.md) |
| Node.js |  |
| Python |  |

---

### Quick Examples

**.NET**
```csharp
using KwaValidator.Services;

var validator = new BiValidator();
var result = validator.Validate("123456789LA001");
```

**Node.js (coming soon)**
```javascript
import { validateBI } from 'kwavalidator';
const result = validateBI('123456789LA001');
```

**Python (coming soon)**
```python
from kwavalidator import validate_bi
result = validate_bi('123456789LA001')
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
