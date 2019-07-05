using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1
{
  public class Numero
  {
    private double numero;

    public void SetNumber(double numero)
    {
      this.numero = numero;
    }

    public double GetNumber()
    {
      return this.numero;
    }

    private static double ValidNumber(string numero)
    {
      double retorno;
      if (!double.TryParse(numero,out retorno))
      {
        retorno = 0;
      }
      return retorno;
    }

    public Numero(double numero)
    {
      this.numero = numero;
    }
    public Numero(string numero)
    {
      this.numero = Numero.ValidNumber(numero);
    }
    public static double SumarNumeros(Numero n1, Numero n2)
    {
      double retorno;
      retorno = n1.GetNumber() + n2.GetNumber();
      return retorno;
    }
    public double SumarNumero(Numero n2)
    {
      double retorno;
      retorno = this.numero + n2.GetNumber();
      return retorno;
    }
  }
}
