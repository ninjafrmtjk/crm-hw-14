namespace Crm;

public sealed class Order
{
    //Hello
    int id;
    string? name;
    string? color;
    short price;
    public required int Id 
    {
        get => id;
        init => id = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Name
    {
        get => name ?? string.Empty;
        init => name = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string Color 
    { 
        get => color ?? string.Empty;
        init => color = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public short Price { get; init; }
}