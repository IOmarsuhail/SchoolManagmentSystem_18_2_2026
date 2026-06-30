namespace Pioneersacademy.SMS.Domains.Entities;

public class Teacher :BaseEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public Country Country { get; set; }//complex object

}
