using System;

namespace DissenyModularEx8
{
    public class DissenyModularEx8
    {
        public static void Main()
        {
            var rand = new Random();
            Console.WriteLine("10 nombres aleatoris entre 0 i 256:");
            for (int ctr = 0; ctr <= 4; ctr++)
            {
                Console.Write(rand.Next(0, 256)+" ");
            }
        }
    }
}