namespace KwaValidator.Services;

public sealed class BiValidator : IBiValidator
{
    private static readonly Regex BiRegex =
        new(@"^\d{9}[A-Z]{2}\d{3}$", RegexOptions.Compiled);

    private static readonly Dictionary<string, Province> Provinces =
        new()
        {
            { "BL", new Province("BL", "Bengo") },
            { "BG", new Province("BG", "Benguela") },
            { "BI", new Province("BI", "Bié") },
            { "CB", new Province("CB", "Cabinda") },
            { "CC", new Province("CC", "Cuando Cubango") },
            { "CN", new Province("CN", "Cunene") },
            { "HU", new Province("HU", "Huambo") },
            { "HL", new Province("HL", "Huíla") },
            { "LA", new Province("LA", "Luanda") },
            { "LD", new Province("LD", "Lunda Norte") },
            { "LS", new Province("LS", "Lunda Sul") },
            { "ML", new Province("ML", "Malanje") },
            { "MO", new Province("MO", "Moxico") },
            { "NA", new Province("NA", "Namibe") },
            { "UI", new Province("UI", "Uíge") },
            { "ZA", new Province("ZA", "Zaire") }
        };

    public BiValidationResult Validate(string bi)
    {
        if (string.IsNullOrWhiteSpace(bi))
            return BiValidationResult.Failure(
                BiValidationError.Empty,
                "BI is required");

        if (bi.Length != 14)
            return BiValidationResult.Failure(
                BiValidationError.InvalidLength,
                "BI must have 14 characters");

        if (!BiRegex.IsMatch(bi))
            return BiValidationResult.Failure(
                BiValidationError.InvalidFormat,
                "BI format is invalid");

        var provinceCode = bi.Substring(9, 2);

        if (!Provinces.TryGetValue(provinceCode, out var province))
            return BiValidationResult.Failure(
                BiValidationError.InvalidProvince,
                "Invalid province code");

        return BiValidationResult.Success(province);
    }
}
