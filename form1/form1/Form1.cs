using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      string numero1 = this.txtBox1.Text;
      string numero2 = this.textBox2.Text;
      Numero n1 = new Numero(numero1);
      Numero n2 = new Numero(numero2);
      double resultado = n1.SumarNumero(n2);
      this.textBox3.Text = resultado.ToString();
    }
  }
}
