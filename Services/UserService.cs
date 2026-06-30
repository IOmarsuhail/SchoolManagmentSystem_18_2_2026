using Pioneersacademy.SMS.Domains.Entities;
using Pioneersacademy.SMS.Domains.Enums;
using Pioneersacademy.SMS.Domains.Interfaces;
//blue dt theme
namespace Pioneersacademy.SMS.Services;

public class UserService : IUser //struct is a value type , class is a reference type
{
    private readonly List<User> _users;

    public UserService()
    {
        if(_users == null)
        {
            _users = new List<User>();
        }
    }
    //CRUD => Create, Read, Update, Delete
    public OpStatus Add(User user)
    {
        //var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
        //if (existingUser != null)
        //{
        //    return OpStatus.AlreadyExists;
        //}

        var existingUser = false;
        foreach (var u in _users)
        {
            if (u.PhoneNumber == user.PhoneNumber)
            {
                existingUser = true;
                break;
            }
        }
        if (existingUser) 
        {
            return OpStatus.AlreadyExists;
        }
        if (IsValidUser(user))
        {
            _users.Add(user);
            return OpStatus.Success;
        } else
        {
            Console.WriteLine("invalid user data");
            return OpStatus.Failure;
        }
    }
    public OpStatus Update(User newUser)
    {
        if (IsValidUser(newUser))
        {
            foreach (var user in _users) 
            {
                if (user.Id == newUser.Id)
                {
                    user.FirstName = newUser.FirstName;
                    user.LastName = newUser.LastName;
                    user.Address = newUser.Address;
                    user.Country = newUser.Country;
                    user.PhoneNumber = newUser.PhoneNumber;
                    user.UserType = newUser.UserType;
                    return OpStatus.Success;
                }
            }
        }
        return OpStatus.Failure;
    }
    public OpStatus Delete(User user) 
    {
        foreach (var u in _users) 
        {
            if(u == user) {
                _users.Remove(user);
                return OpStatus.Success;
            }
        }
        return OpStatus.Failure;

    }
    public void GetById(string id) 
    {
        foreach(var user in _users)
        {
            if (user.Id == id)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.FirstName} {user.LastName}, Address: {user.Address}, Country: {user.Country.Name}, UserType: {user.UserType}");
                break;
            }
        }
    }
    public void PrintAll()
    {
        foreach(var user in _users)
        {
            Console.WriteLine($"Id: {user.Id}, Name: {user.FirstName} {user.LastName}, Address: {user.Address}, Country: {user.Country.Name}, UserType: {user.UserType}");
            Console.WriteLine("***********************************************************************");
        }
    }
    private bool IsValidUser(User user)
    {
        if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName) || user.Country == null || 
             string.IsNullOrEmpty(user.Address) || user.UserType == UserTypeEnum.None)
        {
            return false;
        }
        return true;    
    }
}
