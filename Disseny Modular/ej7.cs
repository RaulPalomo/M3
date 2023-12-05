using System;

namespace DissenyModularEx6
{
    public class DissenyModularEx6
    {
        public static void Main()
        {
            const string MsgText = "Escriu un número";
            const string MsgExp = "Escriu el exponent";
            double num,exp;

            Console.WriteLine(MsgText);
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MsgExp);
            exp = Convert.ToDouble(Console.ReadLine());
            num =Potencia(num,exp);
            Console.WriteLine(num);
        }

        public static double Potencia (double num,double exp) 
            {
                num=Math.Pow(num,exp);
                return num;
            }
    }
}