using System;
using System.Collections.Generic;
using prelim_exam;
using System.Threading;
namespace prelim_exam
{

    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            snake.GetClass();
            snake.GetType();
            snake.snek();

            Console.WriteLine("-->");

            Axolotl axolotl = new Axolotl();
            axolotl.immortal();

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Mammoth mammoth = new Mammoth();
            mammoth.GetClass();
            mammoth.GetType();
            mammoth.mammothstuff();

            Console.WriteLine("-->");
            
            Bear bear = new Bear();
            bear.bearstash();

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Crow crow = new Crow();
            crow.GetClass();
            crow.GetType();
            crow.crowsnest();

            Console.WriteLine("-->");

            Sparrow dove = new Sparrow();
            dove.Pokeball();


            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Carpy goldfish = new Carpy();
            goldfish.GetClass();
            goldfish.GetType();
            goldfish.Kphish();

            Console.WriteLine("-->");

            Carp carp = new Carp();
            carp.GetClass();
            carp.GetType();
            carp.carpinfo();

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");

            KD kd = new KD();
            kd.GetClass();
            kd.GetType();
            kd.Dlair();

            Console.WriteLine("");

            Iguana iguana = new Iguana();
            iguana.iggy();
        }

    }
}