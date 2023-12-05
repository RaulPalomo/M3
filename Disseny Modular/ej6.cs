using System;

namespace DissenyModularEx6
{
    public class DissenyModularEx6
    {
        public static void Main()
        {
            const string MsgText = "Escriu un número";
            int num;
            Console.WriteLine(MsgText);
            num = Convert.ToInt32(Console.ReadLine());
            num=Absolute(num);
            Console.WriteLine(num);
        }

        public static int Absolute (int num) 
            {
                num=Math.Abs(num);
                return num;
            }
    }
}