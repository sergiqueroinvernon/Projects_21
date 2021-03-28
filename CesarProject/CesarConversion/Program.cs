using System;
using TestCesar.Classes;

namespace CesarConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var cesar = new Cesar();
            Console.WriteLine("Schreiben Sie bitte eine Dezimalnumber von 1 bis 3999. Ich werde dir das Ergebnis in romänischen Nummern liefern ");
            var nummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(String.Format("Das Ergebnis ist {0}", cesar.getRomanNumber(nummer)));

        }
    }
}
