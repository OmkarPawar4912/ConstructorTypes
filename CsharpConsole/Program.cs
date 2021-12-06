using System;
using CalculatorFn;
using CsharpConsole;
public enum Season
{
    Spring=1,
    Summer,
    Winter
}
public class Program
{
public static void Main()
    {
        ConstrTypes constrTypes = new ConstrTypes();//For Default Constructor
        ConstrTypes constrTypesPara = new ConstrTypes(10,20);//For Parameterized Constructor
        ConstrTypes constrTypesCopy = new ConstrTypes("Aditya Pawar",21);
        ConstrTypes constrTypesCopyDeatils = new ConstrTypes(constrTypesCopy);//For Copy Constructor
        Console.WriteLine("Parameterized Contructor After Excuting =>  No 1 : {0}   No 2 : {1} ", constrTypesPara.no1, constrTypesPara.no2);
        Console.WriteLine(constrTypesCopyDeatils.GetDetiles);  // after Copy Contructor show detiles
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
        FnClassLibrary fnClassLibrary = new FnClassLibrary();
        Console.WriteLine("Extension Method => 10 % 3 = {0}",fnClassLibrary.Reminder(10, 3));
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
