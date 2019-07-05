using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Musico
  {
    public string nombre;
    public string apellido;
    public int edad;
    public Instrumento instrumento;
    public Orquesta orquesta;

    public Musico(string nombre, string apellido, int edad, Instrumento instru, Orquesta orques)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
      this.orquesta = orques;
      this.instrumento = instru;
    }

    public void imprimirMusico()
    {
      Console.WriteLine("nombre {0}, apellido {1}, edad {2}.", this.nombre, this.apellido, this.edad.ToString());
      this.orquesta.imprimirOrquesta();
      this.instrumento.imprimirInstrumento();
    }
  }
}
