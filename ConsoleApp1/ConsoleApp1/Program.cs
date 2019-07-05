using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Orquesta orquesta1 = new Orquesta();
      orquesta1.imprimirOrquesta();
      Orquesta orquesta2 = new Orquesta("tu vieja", "mi vieja ", "y la de murray");
      orquesta2.imprimirOrquesta();
      Instrumento instrumento1 = new Instrumento("flauta", "viento");
      instrumento1.imprimirInstrumento();

      Musico musico1 = new Musico("fernando", "vera", 12, instrumento1, orquesta2);
      musico1.imprimirMusico();

      ArrayList listaOrquesta = new ArrayList();
      listaOrquesta.Add(orquesta1);
      listaOrquesta.Add(orquesta2);
      /*ArrayList nombres = new ArrayList();
      nombres.Add("pepe4");
      nombres.Add("pepe5");
      nombres.Add("pepe1");*/

      Console.WriteLine("el buble for");
      foreach (Orquesta elemento in listaOrquesta)
      {
        elemento.imprimirOrquesta();
      }
      Console.ReadLine();
    }
  }
}
