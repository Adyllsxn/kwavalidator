namespace KwaValidator.Abstractions;
public interface IBiValidator
{
    BiValidationResult Validate(string bi);
}