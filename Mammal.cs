using System;
using prelim_exam;

namespace prelim_exam
{
    public class Mammal : Animal
    {

        public override void GetClass()
        {
            this._class = "Mammalia";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Mammal";
            Console.WriteLine("Type: " + this._ofType);
        }


    }

    public class Mammoth : Mammal

    {

        public void mammoth()
        {
            Mammoth mammoth = new Mammoth();
            this.Name = "Manny ";
            this._numberOfLegs = 4;
            this.CanSwim = true;

            Console.WriteLine("The first Mammal is a, Wooly Mammoth:");
            Console.WriteLine("The name is " + this.Name);
            Console.WriteLine(this.Name + " is a Vertabrate, has a NeoCortex, has hair/fur(Honestly it's fur i think)");
            Console.WriteLine("has 3 middle ear bones, has "+this._numberOfLegs + "legs and Mammary Glands!");
            Console.WriteLine("Them being able to swim is " + this.CanSwim);
        }
        public void mammothstuff()
        {
            Mammoth mammoth = new Mammoth();
            mammoth.mammoth();
        }

       
    }
       
    }
    public class Bear : Mammal

    {


        public void bear()
        {
            Bear bear = new Bear();
            this.Name = "Bewear";
             this._numberOfLegs = 4;
             this.CanSwim = true;

            Console.WriteLine("As like the Mammal before they are the same!");
            Console.WriteLine("but this ones not extinct");
            Console.WriteLine("This mammals name is " + this.Name + " The Bear");
        Console.WriteLine(this.Name + " has the same traits as the one before it!");
        Console.WriteLine("but its not extinct and has many sub species of it like Grizzly Bears, Panda Bears etc.");

        Console.WriteLine("Both Mammals can swim, " + this.CanSwim );
        }
        public void bearstash()
        {
            Bear bear = new Bear();
            bear.bear();
        }

        


    }


