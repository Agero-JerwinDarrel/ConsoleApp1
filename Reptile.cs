using System;

namespace prelim_exam
{
    public class Reptile : Animal
    {
        //Reptiles are four-limbed (aka tetrapod) animals within the class Reptilia

        public override void GetClass()
        {
            this._class = "Reptilia";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Reptile";
            Console.WriteLine("Type: " + this._ofType);
        }
    }


    public class KD : Reptile
    {
        public void kd()
        {
          
            this.Name = "Koko";
            this.CanSwim = true;
            this._numberOfLegs = 4;

            Console.WriteLine("Komodo Dragon, are creatures deadly that use their poison for hunting prey!");
            Console.WriteLine("Side note they are not dragons but reptiles, and this reptile is " + this.Name);
            Console.WriteLine(this.Name + " has "+this._numberOfLegs+ " legs/limbs ");
            Console.WriteLine(this.Name + " can swim which is " + this.CanSwim);
        }

        public void Dlair()
        {
            KD kd = new KD();
            kd.kd();
        }

        
    }


    public class Iguana : Reptile
    {


        public void Ig()
        {
            this._numberOfLegs = 4;
            this.Name = "Iggy";
            this.CanSwim = true;

            Console.WriteLine("The color changing reptile " + this.Name +" The Iguana");
            Console.WriteLine("They have " + this._numberOfLegs + " legs");
            Console.WriteLine("And most definitely " + this.CanSwim + "That they can swim");

        }

        

        public void iggy()
        {
            Iguana iggy = new Iguana();
            iggy.Ig();
        }
    }

}