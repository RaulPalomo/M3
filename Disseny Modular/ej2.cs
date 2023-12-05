using System;
using System.Security.Cryptography.X509Certificates;

class HelloWorld
{
    public static void Main()
    {
        int b;
        int e;
        int resoult;
        const string MsgB = "Escriu la base: ";
        const string MsgE = "Escriu el exponent: ";
        Console.WriteLine(MsgB);
        b =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MsgE);
        e = Convert.ToInt32(Console.ReadLine());
        resoult = b;
        potencia(e, b,resoult);

    }
    public static void potencia(int e, int b, int resoult)
    {
       for(int i = 0; i < e-1; i++)
        {
            resoult *= b;
        }
        Console.WriteLine($"El resultat de la potència és {resoult}");
    }


}


