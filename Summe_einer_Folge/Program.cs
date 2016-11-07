using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summe_einer_Folge
{
  class Program
  {
    static void Main(string[] args)
    {
      int eingabe, ergebnis = 0;

      Console.WriteLine("Bitte geben Sie eine Zahl ein");
      int.TryParse(Console.ReadLine(), out eingabe);

      for (int i = 1; i <= eingabe; i++)
      {
        ergebnis += i;
        //Zusatzfeature
        Console.WriteLine("{0} - ter Schleifendurchlauf, Summe bisher: {1}", i, ergebnis);
      }
      Console.WriteLine("Die Summe aller Zahlen von 1 bis {0} ist: {1}", eingabe, ergebnis);
      Console.Read();
    }
  }
}
