using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Semana15
{
    internal class Grafo
    {
        int[,] matriz;
        int numNodos = 7;

        public Grafo()
        {
            matriz=new int[numNodos,numNodos];
        }

        public void Insertar()
        {
            matriz[0, 1] = 2;
            matriz[0, 2] = 4;
            matriz[0, 3] = 1;
            matriz[1, 3] = 3;
            matriz[1, 4] = 10;
            matriz[2, 5] = 5;
            matriz[3, 2] = 2;
            matriz[3, 5] = 8;
            matriz[3, 6] = 4;
            matriz[4, 3] = 2;
            matriz[4, 6] = 6;
            matriz[6, 5] = 1;
        }
        public void ImprimirMatriz(RichTextBox rich)
        {
            for (int i = 0; i < numNodos; i++)
            {
                for(int j = 0; j < numNodos; j++)
                {
                    rich.Text += matriz[i, j] + "\t";
                }
                rich.Text += "\n";
            }
        }
        public List<int[]> Prim()
        {
            List<int[]>ArbolExpasion = new List<int[]>();
            HashSet<int>verticesVisitados = new HashSet<int>();

            int verticeInicial = 0;

            verticesVisitados.Add(verticeInicial);

            while (verticesVisitados.Count < numNodos)
            {
                int[] aristaMinimna = null;
                int costoMinimo=int.MaxValue;
                foreach(int i in verticesVisitados)
                {for (int j=0;j < numNodos; j++){
                        if (!verticesVisitados.Contains(j) && matriz[i, j] != 0)
                        {
                            int costoArista = matriz[i, j];
                            if (costoArista < costoMinimo)
                            {
                                aristaMinimna = new int[] { i, j };
                                costoMinimo=costoArista;
                            }
                        }
                    }

                }
                ArbolExpasion.Add(aristaMinimna);
                verticesVisitados.Add(aristaMinimna[1]);
            }
            return ArbolExpasion;
        }
    }
}
