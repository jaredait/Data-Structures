using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        public Queue<string> ColaDatos = new Queue<string>();
        Agregar.Estructura estructura = new Agregar.Estructura();
        

        public Form1()
        {
            InitializeComponent();
            Program.LlenarCola(ColaDatos);
            ImprimirEnBlanco();
        }

        // CORREGIR
        private void button3_Click(object sender, EventArgs e)
        {
            Form_AgregarPersona agregarPersona = new Form_AgregarPersona();
            this.Hide();
            agregarPersona.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonFinalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Cerrar programa
        }

        // Boton Ventanilla General
        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirCola();
        }

        private void ImprimirEnBlanco()
        {
            Label[] arrLabel = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };

            foreach (Label lbl in arrLabel)
                lbl.Text = "";
        }

        private void ImprimirNombres()
        {
            Label[] arrLabel = { label1, label2, label3, label4 };

            //string[] arrTemp = ColaDatos.ToArray();
            Persona[] arrPers = estructura.ColaGeneral.ToArray();
            
            int i = 0;
            while(estructura.ColaGeneral.Count > 0 && i < 4 && i < arrPers.Length)
            {
                arrLabel[i].Text = arrPers[i].Nombre;
                i++;
            }
            /*
            while(ColaDatos.Count > 0 && i < 4 && i < arrTemp.Length)
            {
                arrLabel[i].Text = arrTemp[i];
                i++;
            }
            */
        }

        private void ImprimirCola()
        {
            if(estructura.ColaGeneral.Count > 0)
            {
                Persona aux = estructura.ColaGeneral.Dequeue();
                ImprimirEnBlanco();
                label5.Text = aux.Nombre;
                ImprimirNombres();
            }
            else
            {
                label5.Text = "";
                MessageBox.Show("No hay mas personas en la cola");
            }
            /*
            if (ColaDatos.Count > 0)
            {
                ImprimirEnBlanco();
                label5.Text = ColaDatos.Dequeue();
                ImprimirNombres();
            }
            else
            {
                label5.Text = "";
                MessageBox.Show("No hay mas personas en la cola");
            }
            */
        }

        
    }
}
