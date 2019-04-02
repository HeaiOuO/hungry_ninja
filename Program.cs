using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet ninjaBuffet = new Buffet ();
            Ninja ciso = new Ninja ();
            while (ciso.IsFull == false) {
                ciso.Eat (ninjaBuffet.Serve ());
            }
            Console.WriteLine ($"Warning: calorie intake is {ciso.CalorieAmount}. Your ninja is full.");
        }
    }
}
