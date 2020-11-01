using System;
using prelim_exam;

namespace prelim_exam
{
    //Birds are a collection of warm-blooded vertebrates within the class Aves, identified by feathers, toothless, beaked jaws, the laying of hard-shelled eggs, a four-chambered heart, and a well-built yet lightweight skeleton system.

    public class Bird : Animal
    {

        public override void GetClass()
        {
            this._class = "Aves";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Bird";
            Console.WriteLine("Type: " + this._ofType);
        }

    }
    public class Crow : Bird
    {


        public void crow()
        {
            Bird crow = new Bird();
            this._numberOfLegs = 2;
            this.Name = "Raven";
           

            Console.WriteLine("The first Aviary creature is a Crow");
            Console.WriteLine("The name of it is " + this.Name + " they're different birds I know but I like the name.");
            Console.WriteLine(this.Name + " is a warm blooded vertabrate, they have jet black feathers ");
            Console.WriteLine("they are tootlhless hence they have beaked jaws, lay hardshell eggs, have four chambered hearts");
            Console.WriteLine(this._numberOfLegs +"small legs and a lightweight but well built skeleton system");
        }

        public void crowsnest()
        {
            Crow crow = new Crow();
            crow.crow();
        }
       
    }

    public class Sparrow : Bird
    {
        public void sparrow()
        {
            Bird sparrow = new Bird();
            this._numberOfLegs = 2;
            this.Name = "Spearow";
            this.CanSwim = false;

            Console.WriteLine("Sparrow's that once flocked the streets where I live is the other Avian specie");
            Console.WriteLine(this.Name+" is the name of the game");
            Console.WriteLine("They have the same system as the Crow from before!");
            Console.WriteLine("They have feathers which are not black, they have beaks, they have multi chambered hearts");
            Console.WriteLine("They have a well built skeletal system");
            Console.WriteLine(" ''And You Got To Catch Em All'' ");
            Console.WriteLine("Most avian creatures can swim but these do not, " + this.CanSwim);
            
        }

        public void Pokeball()
        {
            Sparrow sparrow = new Sparrow();
            sparrow.sparrow();
        }

      
    }
}