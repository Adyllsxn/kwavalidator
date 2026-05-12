namespace KwaValidator.Enums;
public sealed class Province
{
    public string Code { get; }
    public string Name { get; }

    public Province(string code, string name)
    {
        Code = code;
        Name = name;
    }
}
