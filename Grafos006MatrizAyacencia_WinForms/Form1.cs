using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grafos006MatrizAyacencia_WinForms
{
    // Definicion de la clase Form1
    public partial class Form1 : Form
    {
        // Atributos
        Estructura.Grafo Matriz = new Estructura.Grafo(0);
        byte Dimension = 0;
        const byte MAX_DIMENSION = 9;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            ImprimirMatriz();
            ImprimirCamposEnBlanco();
        }

        // Cuando el boton "Agregar vertice es oprimido, se llama al metodo AgregarVertice y se aumenta el numero de vertices en 1
        private void botonAgregarVertice_Click(object sender, EventArgs e)
        {
            if(Dimension <= MAX_DIMENSION)
            {
                Matriz.AgregarVertice();
                ImprimirMatriz();
                Dimension++;
            }
            else
                MessageBox.Show("No es posible aumentar la dimension");

        }

        // Cuando el boton AgregarAco es oprimido, se llama al metodo AgregarArco y se traza un camino entre el par de vertices
        // especificado. Tambien imprime guias en los campos si es que no se los lleno correctamente
        private void botonAgregarArco_Click(object sender, EventArgs e)
        {
            if (entradaFila.Text == string.Empty || entradaColumna.Text == string.Empty)
            {
                if (entradaFila.Text == string.Empty)
                    entradaFila.BackColor = Color.LightCoral;
                if (entradaColumna.Text == "")
                    entradaColumna.BackColor = Color.LightCoral;
            }
            else
            {
                entradaFila.BackColor = Color.White;
                entradaColumna.BackColor = Color.White;
                int fila = Convert.ToInt32(entradaFila.Text);
                int col = Convert.ToInt32(entradaColumna.Text);
                Matriz.AgregarArco(fila, col);
                ImprimirMatriz();
                ImprimirCamposEnBlanco();
            }
        }

        // Cuando el boton EliminarVertice es oprimido, se llama al metodo EliminarVertice y se elimina el vertice
        // especificado. Tambien imprime guias en los campos si es que no se los lleno correctamente
        private void botonEliminarVertice_Click(object sender, EventArgs e)
        {
            if(entradaEliminarVertice.Text == string.Empty)
            {
                entradaEliminarVertice.BackColor = Color.LightCoral;
            }
            else
            {
                if (Dimension > 0)
                {
                    int rem = Convert.ToInt32(entradaEliminarVertice.Text);

                    entradaEliminarVertice.BackColor = Color.White;
                    Matriz.RemoverVertice(rem);
                    ImprimirMatriz();
                    ImprimirCamposEnBlanco();
                    Dimension--;
                }
                else
                    MessageBox.Show("No es posible disminuir la dimension");
            }
        }

        // Imprime la matriz en el cuadro de texto pantallaImpresion
        private void ImprimirMatriz()
        {
            pantallaImpresion.Text = Matriz.ImprimirMatrizAdyacencia();
        }

        // Limpia los campos de cualquier caracter que haya sido introducido en ellos previamente
        private void ImprimirCamposEnBlanco()
        {
            entradaFila.Text = "";
            entradaColumna.Text = "";
            entradaEliminarVertice.Text = "";
        }
    }
}
