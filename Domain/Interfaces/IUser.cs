using Pioneersacademy.SMS.Domains.Entities;
using Pioneersacademy.SMS.Domains.Enums;

namespace Pioneersacademy.SMS.Domains.Interfaces;

public interface IUser  
{
    //in ijnterface we only declare the method signature, we don't implement the method body,
    //the implementation will be done in the class that implements the interface




    // the interface is conract between the class that implements the interface and the code that uses the interface,
    // the class that implements the interface must implement all the methods declared in the interface,
    // otherwise it will throw an error, and the code that uses the interface can only use the methods declared in the interface,
    // it cannot use any other method that is not declared in the interface, this is called encapsulation,
    // it helps to hide the implementation details of the class and only expose the necessary methods to the outside world,
    // this is one of the main principles of object-oriented programming,
    // it helps to achieve loose coupling between classes and makes the code more maintainable and scalable.
    OpStatus Add(User user);
    OpStatus Update(User user);
    OpStatus Delete(User user);
    void GetById(string id);
    void PrintAll();

}
