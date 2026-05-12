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
