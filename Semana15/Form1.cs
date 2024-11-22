using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana15
{
    public partial class Form1 : Form
    {
        Grafo g=new Grafo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMatrizCosto_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            g.Insertar();
            g.ImprimirMatriz(richTextBox1);
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            List<int[]> Arbol = g.Prim();
            foreach(var arista in Arbol)
            {
                listBox1.Items.Add($"{arista[0]}\t{arista[1]}");
            }
        }
    }
}
