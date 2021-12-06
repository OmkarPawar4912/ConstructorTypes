using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConsole
{
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
            Console.WriteLine("Default Contructor =>  No 1 : {0}   No 2 : {1} ", no1, no2);
        }
        public ConstrTypes(int no3, int no4) //Parameterized constructor
        {
            Console.WriteLine("Parameterized Contructor Called =>  No 3 : {0}   No 4 : {1} ", no3,no4);
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
                return "Copy Contructor =>  Name : " + name + "   Age : " + age.ToString();
            }
        }
    }
}
