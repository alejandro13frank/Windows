using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Instrumento
  {
    public string nombre;
    public string tipoInstrumento;

    public Instrumento(string nombre, string tipo)
    {
      this.tipoInstrumento = tipo;
      this.nombre = nombre;
    }

    public void imprimirInstrumento()
    {
      Console.WriteLine("nombre {0}, tipo {1}.", this.nombre,this.tipoInstrumento);
      Console.ReadLine();
    }
  }
}
