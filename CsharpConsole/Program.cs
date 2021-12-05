using System;
using CsharpConsole;
public enum Season
{
    Spring=1,
    Summer,
    Winter
}
public class ConstrTypes
{
    public int no1, no2;
    private string name;
    private int age;
    public static float _PI;
    
    static ConstrTypes() // Static constructor
    {
        _PI = 3.142F;
    }
   
    public ConstrTypes()
    {
        no1 = 100;
        no2 = 200;
        Console.WriteLine("Default Contructor =>  No 1 : {0}   No 2 : {1} ", no1,no2);
    }
    public ConstrTypes(int no3, int no4) //Parameterized constructor
    {
        this.no1 = no3;
        this.no2 = no4;
    }
    public ConstrTypes(string name, int age)  // Instance constructor.
    {
        this.name = name;
        this.age = age;
    }
    public ConstrTypes(ConstrTypes CopyConstr)   // Declar Copy constructor.
    {
        name = CopyConstr.name; ;
        age = CopyConstr.age;
    }
    public string GetDetiles     //Get Copy Details
    {
        get
        {
            return "Copy Contructor =>  Name : " + name + "   Age : "+ age.ToString();
        }
    }
}
class PrivateConstructor
{
    private PrivateConstructor() // Private Constructor
    {

    }
    public static string GetCalled() // Display Private Constructor Method Called
    {
        return "Private Constructor => Private Constructor Called";
    }
}
public class Program
{
public static void Main()
    {
        ConstrTypes constrTypes = new ConstrTypes();//For Default Constructor
        ConstrTypes constrTypesPara = new ConstrTypes(10,20);//For Parameterized Constructor
        ConstrTypes constrTypesCopy = new ConstrTypes("Aditya Pawar",21);//For Parameterized Constructor
        ConstrTypes constrTypesCopyDeatils = new ConstrTypes(constrTypesCopy);//For Parameterized Constructor
        Console.WriteLine("Parameterized Contructor =>  No 1 : {0}   No 2 : {1} ", constrTypesPara.no1, constrTypesPara.no2);
        Console.WriteLine(constrTypesCopyDeatils.GetDetiles);  //Copy Contructor
        Console.WriteLine("Static Contructor => Values of PI : {0}", ConstrTypes._PI); // Static Constructor
        Console.WriteLine(PrivateConstructor.GetCalled()); // Private Constructor
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Display Season Value of Summer (Using Enum) : {0}", (int)Season.Summer);//For Enum Dislpay
        Console.WriteLine("----------------------------------------------------------------");
        string name = "Omkar";
        Console.WriteLine("Display Before Pass By Reference : {0}", name);//For Pass By Reference Dislpay
        PassByRefe(name);
        Console.WriteLine("----------------------------------------------------------------");
        int no = 3;
        Console.WriteLine("Display Before Pass By Value : {0}", no);//For Pass By Value Dislpay
        PassByValue(no);
        Console.WriteLine("----------------------------------------------------------------");
        int num = 23;
        // boxing
        object obj = num;
        // unboxing
        int i = (int)obj;
        Console.WriteLine("Value of obj is : " + obj);// Display result
        Console.WriteLine("Value of i   is : " + i);
        Console.WriteLine("----------------------------------------------------------------");
        int number = 10;
        bool result = number.IsGreaterThan(100);
        Console.WriteLine("Extension Method => 10 is Greater Than 100 (True or False) = {0}",result);
        Console.WriteLine("=================================================================");
    }
    static void PassByValue(int value)
    {
        value = 3;
        switch (value)
        {
            case 1:
                Console.WriteLine("Display Season After Pass By Value : {0}  and Name : {1}", (int)Season.Spring, Season.Spring);
                break;
            case 2:
                Console.WriteLine("Display Season After Pass By Value : {0} and Name : {1}", (int)Season.Summer, Season.Summer);
                break;
            case 3:
                Console.WriteLine("Display Season After Pass By Value : {0} and Name : {1}", (int)Season.Winter, Season.Winter);
                break;
            default:
                Console.WriteLine("Oh no..! Something is wrong");
                break;
        }
    }
    static void PassByRefe(string name)
    {
        name = "Pawar";
        Console.WriteLine("Display After Pass By Reference : {0}", name);//For Pass By Reference Dislpay
    }
}
