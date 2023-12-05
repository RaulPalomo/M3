using System;

namespace DissenyModularEx10
{
    public class DissenyModularEx10
    {
        public static void Main()
        {
            var rand = new Random();
            int[] list = new int[10];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] =  Convert.ToInt32(rand.Next(200));
            }
            Search(list);

        }

        public static void Search(int[] list)
        {
            const string FirstMsg = "Escriu un número";
            int num, control = 0;
            Console.WriteLine(FirstMsg);
            num = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            while (!found && control < list.Length)
            {
                if (num == list[control])
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
                control++;
            }
            if (found)
            {
                Console.WriteLine($"{num} està dins de la llista");
            }
            else
            {
                Console.WriteLine($"{num} no està dins de la llista");
            }
        }
        

    }
}