using System.Runtime.InteropServices;

namespace DissenyModular
{
    public class ex20
    {
        public static void Main()
        {
            const string Msg = "Insereix un número decimal";
            double num;
            int units=0;
            double decimals = 0;
            Console.WriteLine(Msg);
            num=Convert.ToDouble(Console.ReadLine());
            units = UnitPart(num, units);
            Console.WriteLine(units);
            decimals = DecimalPart(num,decimals,units);
            Console.WriteLine(decimals);
        }
        public static int UnitPart(double num, int units)
        {
            units = Convert.ToInt32(num);
            if (units>num)
            {
                units--;
            }
            return units;
        }
        public static double DecimalPart(double num,double decimals, int units)
        {
            decimals= num-units;
            return decimals;
        }
    }
}