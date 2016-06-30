namespace Person
{

//  Problem 4. Person class
//• Create a class  Person  with two fields – name and age.
//    Age can be left unspecified (may contain  null  value. 
//    Override  ToString()  to display the information of a person and if age is not specified – to say so.
//• Write a program to test this functionality.

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            Person p1 = new Person("Alexander");
            Console.WriteLine(p1);

            Person p2 = new Person("Peter",null);
            Console.WriteLine(p2);

            Person p3 = new Person("Mariana", 25);
            Console.WriteLine(p3);
        }
    }
}
