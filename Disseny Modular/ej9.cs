using System;

namespace DissenyModularEx9
{
    public class DissenyModularEx9
    {
        public static void Main()
        {
            const string FirstMsg = "Escriu un número";
            const string OptionsMsg = "A.Comprovar si es més petit que...  B.Comprobar si es troba entre...i...";
            int num;
            string option;
            Console.WriteLine(FirstMsg);
            num= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(OptionsMsg);
            option = Console.ReadLine();
            if (option == "A")
            {
                Lower(num);
            }
            else if (option == "B")
            {
                Between(num);
            }
        }
        public static void Lower(int num)
        {
            Console.WriteLine("Escriu un altre num");
            int num2=Convert.ToInt32(Console.ReadLine());
            if (num2 > num)
            {
                Console.WriteLine($"{num} és més petit que {num2}");
            }
            else
            {
                Console.WriteLine($"{num} no és més petit que {num2}");
            }
        }

        public static void Between(int num)
        {
            Console.WriteLine("Escriu un altre num");
            int limit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu un altre num");
            int limit2 = Convert.ToInt32(Console.ReadLine());
            if ((limit1 > num && limit2<num)||(limit2>num && limit1<num))
            {
                Console.WriteLine($"{num} està entre {limit1} i {limit2}");
            }
            else
            {
                Console.WriteLine($"{num} no està entre {limit1} i {limit2}");
            }
        }

    }
}