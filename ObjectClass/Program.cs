using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Object object1 = new Object();
            Object object2 = new Object();

            // Object class built-in methods
            // Equals() compares the current object to the specified one
            Console.WriteLine("Equals(): " + object1.Equals(object2));

            // GetHashCode() default hash function
            Console.WriteLine("GethashCode(): " + object1.GetHashCode());

            // GetType() returns the Type of the object
            Console.WriteLine("GetType(): " + object1.GetType());

            // ToString() returns the fully-qualified object name of the type
            Console.WriteLine("ToString(): " + object1.ToString());

            // Now let's create an object of a class which overrides the ToString() method
            // Product class overrides ToString() to print the value of ProductName
            Product Computer = new Product();
            Computer.ProductName = "HAL-9000";

            // Overridden ToString()
            Console.WriteLine("Overridden ToString(): " + Computer.ToString());

            // Computer has inherited IsValid (along with other methods in EntityBase class) from EntityBase class
            Console.WriteLine(Computer.IsValid);
        }
    }
}
