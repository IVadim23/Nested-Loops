using System;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            //Goes through all floors from top to bottom
            for (int fl = floors; fl >= 1; fl--)
            {
                //Goes through all apartments/offices on a single floor
                for (int ap = 0; ap < apartments; ap++)
                {
                    //Combination -> Floor, Apartment
                    //Last Floor
                    if (fl == floors)
                    {
                        Console.Write($"L{fl}{ap} ");
                    }
                    else if (fl % 2 != 0)
                    {
                        Console.Write($"A{fl}{ap} ");
                    }
                    else if (fl % 2 == 0)
                    {
                        Console.Write($"O{fl}{ap} ");
                    }
                }

                //Visually move to the next floor
                Console.WriteLine();
            }
        }
    }
}
