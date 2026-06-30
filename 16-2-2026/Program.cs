using Pioneersacademy.SMS.Domains.Entities;
using Pioneersacademy.SMS.Domains.Enums;
using System.Collections;


//when we create a namespace must named it like this company name + project name + folder name if exist,



namespace Pioneersacademy.SMS.UI;

internal class Program
{
    static void Main(string[] args)
    {
        

        var status = StudentStatus.None;
        switch (status)
        {
            case StudentStatus.None:
                Console.WriteLine("None");
                break;
            case StudentStatus.Pass:
                Console.WriteLine("Pass");
                break;
            case StudentStatus.Fail:
                Console.WriteLine("Fail");
                break;
        }

       


        //extension method
        var lst = new ArrayList() { 1, 2, 3, 4, 5 };
        Console.WriteLine(lst.FindListCount());




        //polymorphism is multishapes 1 => override 2=> overload

        var mo = new MethodOverloading();
        mo.Add(1, 2);
        mo.Add(1.5, 2.5);
        mo.Add(1.5f, 2.5f);
        mo.Add(5, 6, 7);

        MethodOverriding_Derived mod = new MethodOverriding_Derived();
        mod.Add(10, 20);




        var teacher = new Teacher();
        teacher.Id = Guid.NewGuid(); // the id here is a guid because the base class is BaseEntity<Guid> and the id type is guid


        var user = new User();
        user.Id = "155268"; // but the id here is a string because the base class is BaseEntity<string> and the id type is string





    }
}
//**********************************************************************************************************************************
abstract class Animal
{
    public abstract void Sound(); //abstract mean you must override the method in the derived class
}

class Cat : Animal
{
    public override void Sound() // this method must be implemented because it's abstract in the base class
    {
        Console.WriteLine($"the cat sound is Meao Meao");
    }
}

class Dog : Animal
{
    public override void Sound() // this method must be implemented because it's abstract in the base class
    {
        Console.WriteLine($"the Dog sound is Hao Hao");
    }
}
//**********************************************************************************************************************************
class MethodOverriding_Base
{
    public virtual void Add(int a, int b)
    {
        Console.WriteLine($"the sum of {a} and {b} is {a + b}");
    }
}

class MethodOverriding_Derived : MethodOverriding_Base
{
    public override void Add(int a, int b)
    {
        base.Add(a, b);
    }
}
//**********************************************************************************************************************************

class MethodOverloading  //overload mean you can have multiple methods with the same name but different parameters
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(double a, double b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(float a, float b)
    {
        Console.WriteLine(a + b);
    }

    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
}
//**********************************************************************************************************************************

public static class CustomList   //extension method
{ 
    public static string FindListCount(this ArrayList lst)
    {

        return $"the count of the list is {lst.Count}";
    }
}
//**********************************************************************************************************************************

class Vehicle
{
    public string brand = "ford";
    public virtual void honk(string h)//virtual mean you can override the method in the derived class
    {
        Console.WriteLine(h);
    }
}

class Car : Vehicle
{
    public string modelName = "mustang";
    public override void honk(string h) 
    {
        base.honk(h);
    }
}
