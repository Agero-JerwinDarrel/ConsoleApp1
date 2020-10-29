using System;
using System.Runtime.InteropServices.ComTypes;

namespace prelim_exam
{
    public class Amphibian : Animal, IPrintName
    {
        public void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }

    public interface IPrintName
    {
        void PrintName();
    }

    public class Turtle : Amphibian
    {
    }

    public class Frog : Amphibian
    {

    }
}
