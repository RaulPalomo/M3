using System;
using System.Security.Cryptography.X509Certificates;

class HelloWorld
{
    public static void Main()
    {
        const string Msg = "Introdueix un num: ";

        int num;
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(Msg);
            num = Convert.ToInt32(Console.ReadLine());
            naturals(num);
        }

        
    }
    public static void naturals(int num)
    {
        const string MsgTrue = "És natural";
        const string MsgFalse = "No és natural";
        Console.WriteLine(num>0?MsgTrue:MsgFalse);
    }


}


