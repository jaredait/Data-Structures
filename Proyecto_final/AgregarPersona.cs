using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Agregar;

namespace Proyecto_final
{
    public partial class Form_AgregarPersona : Form
    {
        public Form_AgregarPersona()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 salaEspera = new Form1();
            this.Hide();
            salaEspera.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        private void nuevaPersona_Click(object sender, EventArgs e)
        {
            turnoGenerado.Visible = false;
            turnoNoGenerado.Visible = false;
            nombreRequerido.Visible = false;
            ingresoNombre.Text = string.Empty;
            ingresoEdad.Text = string.Empty;
            discapacidadNo.Checked = false;
            discapacidadSi.Checked = false;
            ingresoNombre.Focus();

        }

        // Funcion que verifica si es que uno radio button fue presionado 
        public bool DiscapacitadoChecked()
        {
            if (discapacidadSi.Checked || discapacidadNo.Checked)
                return true;
            else
                return false;
        }

        public bool EsDiscapacitado()
        {
            if (discapacidadSi.Checked)
                return true;
            return false;
        }

        

        private void Verificar()
        {
            if (ingresoNombre.Text == "" || ingresoEdad.Text == "" || DiscapacitadoChecked() == false)
            {
                if (ingresoNombre.Text == "")
                    nombreRequerido.Visible = true;
                turnoNoGenerado.Visible = true;
            }
            else
            {
                turnoGenerado.Visible = true;
                Persona persona = new Persona();

                persona.Nombre = ingresoNombre.Text;
                persona.Edad = Convert.ToInt32(ingresoEdad.Text);
                persona.Discapacidad = EsDiscapacitado();
                Guardar();
            }
        }
        private void Guardar()
        {
            //Agregar.Estructura estructura = new Agregar.Estructura();
            Persona usuario = new Persona();
            usuario.Nombre = ingresoNombre.Text;
            usuario.Edad = Convert.ToInt32(ingresoEdad.Text);
            usuario.Discapacidad = EsDiscapacitado();

            

            //MessageBox.Show("Usuario agregado con exito");
        }
    }
}
