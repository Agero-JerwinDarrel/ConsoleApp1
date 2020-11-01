using System;
using prelim_exam;

namespace prelim_exam
{
    public class Fish : Animal
    {
        //Fishes are the aquatic animals within the class Anatidae that do not have limbs with digits.
        public int Limbs { get; set; }

        public override void GetClass()
        {
            this._class = "Anatidae";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Fish";
            Console.WriteLine("Type: " + this._ofType);
        }
    }
    class Carpy : Fish
    {


        public void koi()
        {
            Carpy koi = new Carpy();
            this.Name = "Kai";
            this._numberOfLegs = 0;
            this.CanSwim = true;

            Console.WriteLine("A very colorful Fish, The Koi");
            Console.WriteLine(this.Name + " is the Kois' name");
            Console.WriteLine("It has " + this._numberOfLegs+ "number of legs but has fins");
            Console.WriteLine("It is "+this.CanSwim + " that it can swim, its a fish");

        }

        public void Kphish()
        {
            Carpy kai = new Carpy();
            kai.koi();
        }
       

    }
    public class Carp : Fish
    {
        public void carp()
        {
            Carpy carp = new Carpy();
            this.Name = "MagiCarp ";
            this._numberOfLegs = 0;
            this.CanSwim = true;

            Console.WriteLine("Carps are the fish of freshwater");
            Console.WriteLine("The fish name is " + this.Name);
            Console.WriteLine("It has "+this._numberOfLegs +" legs");
            Console.WriteLine(this.CanSwim+ " that it can do swimmingly, but in a game they have a hard time doing so");

        }

        public void carpinfo()
        {
            Carp carp = new Carp();
            carp.carp();
        }

    }
}