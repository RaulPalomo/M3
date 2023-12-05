using System;

namespace UnitTest4
{
    public class DissenyModularEx4
    {
        public static void Main()
        {
            const string MsgText = "Escriu un número";
            int num;
            Console.WriteLine(MsgText);
            num = Convert.ToInt32(Console.ReadLine());
            Validate(num);
        }

        public static void Validate (int num) 
            {
                if (num>0 && num<100)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine ("False") ;
                }
            }
    }
}