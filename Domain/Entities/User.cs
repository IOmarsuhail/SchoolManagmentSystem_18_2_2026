using Pioneersacademy.SMS.Domains.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pioneersacademy.SMS.Domains.Entities;

public class User : BaseEntity<string>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public Country Country { get; set; }//complex object
    public UserTypeEnum UserType { get; set; }
    /*
     1 => Admin
     2 => Teacher
     3 => Student
    */
}


//  inheritance => we have derived and base classes, the derived class inherits the properties and methods of the base class, and can also have its own properties and methods.

//derived class => child class
//base class => parent class