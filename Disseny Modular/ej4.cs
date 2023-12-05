using System;

namespace UnitTest4
{
    public class DissenyModularEx4
    {
        public static void Main()
        {
            const string MsgText = "Escriu un text";
            const string MsgChoose = "A. Majuscules  B. Minuscules";
            string text;
            string option;
            Console.WriteLine(MsgText);
            text= Console.ReadLine();
            Console.WriteLine(MsgChoose);
            option = Console.ReadLine().ToUpper();
            Transform(text, option);

        }

        public static void Transform (string text, string option) 
            {
            if (option == "A")
            {
                Console.WriteLine(text.ToUpper());
            }
            else if (option == "B")
            {
                Console.WriteLine(text.ToLower());
            }

            }
    }
}