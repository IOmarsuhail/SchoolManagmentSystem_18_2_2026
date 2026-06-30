namespace Pioneersacademy.SMS.Domains.Entities;

public /*sealed*/ class BaseEntity <T>: System.Object //any class in C# implicitly inherits from System.Object, so we can omit it, but it's included here for clarity.
{
    public T Id { get; set; } //uint => 0 to 4,294,967,295 (unsigned integer)
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int DeletedBy { get; set; }

}
// sealed => a sealed class cannot be inherited by any other class. This is useful when you want to prevent further derivation of a class, ensuring that its behavior remains unchanged and that it cannot be extended or modified through inheritance.
//sealed mean عقيم
