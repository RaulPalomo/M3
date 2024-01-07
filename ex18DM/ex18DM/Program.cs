using System;
namespace DissenyModular
{
    public class ex18
    {
        public static void Main()
        {
            const string FirstMsg = "Escriu els minuts que vols passar a segons";
            int temps;
            Console.WriteLine(FirstMsg);
            temps = Convert.ToInt32(Console.ReadLine());
            temps = CalcSeconds(temps);
            Console.WriteLine(temps);
        }
        public static int CalcSeconds(int temps)
        {
            const int sixty = 60;
            return temps * sixty;
        }
    }
}
