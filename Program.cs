using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace prelim_exam
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Animal> listOfAnimals = new List<Animal>();

            Amphibian turtle = new Turtle();
            Amphibian frog = new Frog();

            turtle.Name = "Lassie";
            frog.Name = "Ernie";

            listOfAnimals.Add(turtle);
            listOfAnimals.Add(frog);

        

            foreach (IPrintName a in listOfAnimals)
            {
                a.PrintName();
               
            }

            Console.WriteLine("Hello World!");
        }
    }
}
