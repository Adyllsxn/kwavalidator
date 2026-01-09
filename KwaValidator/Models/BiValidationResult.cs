namespace KwaValidator.Models;
public sealed class BiValidationResult
{
    public bool IsValid { get; init; }
    public string? ErrorMessage { get; init; }
    public BiValidationError? ErrorCode { get; init; }

    public Province? Province { get; init; }

    public static BiValidationResult Success(Province province)
        => new()
        {
            IsValid = true,
            Province = province
        };

    public static BiValidationResult Failure(BiValidationError error, string message)
        => new()
        {
            IsValid = false,
            ErrorCode = error,
            ErrorMessage = message
        };
}
