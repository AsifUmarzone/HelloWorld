using System;
using static System.Console;


namespace Ch02Variable
{
    class Program
    {
        static void Main(string[] args)



        {
            //Object Type
            object height = 1.88; //storing double in an object
            object name = "Amir"; // storing string in an object
          //  int length1 = name.Length; //gives a compile error
            int length2 = ((string)name).Length; //cast to access members


            //Dynamic Types 


            //storing a string in dynamic object

            dynamic anotherName = "Asif";
            //this compile but might gives exception error at run time

            int lenght = anotherName.Length;



            //Local Variable


            int population = 66_000_000;
            double weight = 1.88;
            decimal price = 4.99M;
            string fruit = "Apple";
            char letter = 'A';
            bool happy = false;


            //var population = 66_000_000;
            //var weight = 1.88;
            //var price = 4.99M;
            //var fruit = "Apple";
            //var letter = 'A';
            //var happy = false;

            //this only works c# 6.0 or later
            WriteLine($"the uk population is {population}.");
            WriteLine($"The weight is{weight}.");
            WriteLine($"The Price is {price}");
            WriteLine($"the fruit is{fruit}.");
            WriteLine($"LETTER is the {letter}.");
            WriteLine($"bool is the {happy}.");
            WriteLine($"enter the name and pres enter");
            string firstName = ReadLine();
           WriteLine($"Enter the Age and press enter");
            string age =ReadLine();

            WriteLine($"Hello  {firstName} you look good at {age}");
           ReadKey();


        }
    }
}