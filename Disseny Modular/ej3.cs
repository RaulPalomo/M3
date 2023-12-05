using System;

namespace UnitTest3
{
    public class ex3
    {
        public static void Main()
        {
            const string MsgNum = "Escriu un número per veure el seu valor absolut";
            int num;
            Console.WriteLine(MsgNum);
            num = Convert.ToInt32(Console.ReadLine());
            num=Absolute(num);
            Console.WriteLine(num);
        }

        public static int Absolute (int num) 
            {
            if (num < 0) 
            {
                num *= (-1);
            }
            return num;
            }
    }
}