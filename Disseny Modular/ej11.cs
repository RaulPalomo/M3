using System;

namespace DissenyModularEx10
{
    public class DissenyModularEx10
    {
        public static void Main()
        {
            const string Msg = "Escriu un número";
            int num;
            Console.WriteLine(Msg);
            num=Convert.ToInt32(Console.ReadLine());
            num=Factorize(num);
            Console.WriteLine(num);
        }

        public static int Factorize(int num)
        {
            int result = 1;
            for(int i = num; i>0; i--)
            {
                result *= i;
            }

            return (result);
        }
        

    }
}