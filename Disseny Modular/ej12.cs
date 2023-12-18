using System;

namespace DissenyModular
{
    class ex12
    {
        public static void Main()
        {
            const string FirstMsg = "Digues el nombre de litres consumits aquest mes";
            int liters;
            double result=6;
            Console.WriteLine(FirstMsg);
            liters=Convert.ToInt32(Console.ReadLine());
            result= Calc(liters,result);
            Console.WriteLine(result);
        }
        public static double Calc(int liters,double result)
        {
            if ( liters >50)
            {
                if( liters <=200)
                {
                    result += (liters-50)*0.1;
                }
                else if( liters > 200)
                {
                    result += 150 * 0.1;
                    result += (liters - 200) * 0.3;
                }
            }
            return result;
        }
    }
}
