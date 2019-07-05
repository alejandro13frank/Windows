using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Orquesta
  {
    public string nombre;
    public string lugar;
    public string tipoOrquesta;

    public Orquesta()
    {
      this.nombre = "no tiene nombre";
      this.lugar = "no tiene lugar";
      this.tipoOrquesta = "puto el que lee";
    }
    public Orquesta(string nombre,string lugar, string tipo)
    {
      this.nombre = nombre;
      this.lugar = lugar;
      this.tipoOrquesta = tipo;
    }

    public void imprimirOrquesta()
    {
      Console.WriteLine("nombre {0}, lugar {1}, tipo {2}.", this.nombre, this.lugar, this.tipoOrquesta);
      Console.ReadLine();
    }
      
  }
}
