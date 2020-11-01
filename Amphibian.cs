using System;

namespace prelim_exam
{
    public class Amphibian : Animal
    {
       
        public override void GetClass()
        {
            this._class = "Amphibia";
            Console.WriteLine("Class: " + this._class);
        }

        public override void GetType()
        {
            this._ofType = "Amphibian";
            Console.WriteLine(this._ofType);
        }
    }
    public class Snake : Amphibian
    {
        public void snake()
        {
            Amphibian snake = new Amphibian();
            this._numberOfLegs = 0;
            this.CanSwim = true;
            this.Name = "snek ";

            Console.WriteLine("Snake are that slithers silently then attack their prey with fast reflexes");
            Console.WriteLine(this.Name +" is the slithery fella");
            Console.WriteLine("They have " +this._numberOfLegs + "legs and they slither to get around");
            Console.WriteLine(this.Name + "can swim " + this.CanSwim);


        }

        public void snek()
        {
            Snake snake = new Snake();
            snake.snake();
        }

       
    }


    public class Axolotl : Amphibian
    {

        public void axolotl()
        {
            Amphibian axolotl = new Amphibian();
            this._numberOfLegs = 4;
            this.CanSwim = true;
            this.Name = "ax";

            Console.WriteLine("Axolotl are one of the many that can be key to immortality");
            Console.WriteLine(this.Name + " is its name");
            Console.WriteLine(this.Name + "has " +this._numberOfLegs +" legs, and even though it swims! ");
            Console.WriteLine("Speaking of swimming, it is " + this.CanSwim + "that it can swim");
        }

       
        public void immortal()
        {
            Axolotl axolotl = new Axolotl();
            axolotl.axolotl();
        }
    }
}