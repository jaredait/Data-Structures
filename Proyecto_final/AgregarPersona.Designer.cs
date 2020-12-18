
namespace Proyecto_final
{
    partial class Form_AgregarPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label15 = new System.Windows.Forms.Label();
            this.ingresoEdad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ingresoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discapacidadSi = new System.Windows.Forms.RadioButton();
            this.discapacidadNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.turnoGenerado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.nuevaPersona = new System.Windows.Forms.Button();
            this.turnoNoGenerado = new System.Windows.Forms.Label();
            this.nombreRequerido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(304, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Edad";
            // 
            // ingresoEdad
            // 
            this.ingresoEdad.Location = new System.Drawing.Point(310, 173);
            this.ingresoEdad.Name = "ingresoEdad";
            this.ingresoEdad.Size = new System.Drawing.Size(208, 22);
            this.ingresoEdad.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(307, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Nombre";
            // 
            // ingresoNombre
            // 
            this.ingresoNombre.Location = new System.Drawing.Point(307, 124);
            this.ingresoNombre.Name = "ingresoNombre";
            this.ingresoNombre.Size = new System.Drawing.Size(208, 22);
            this.ingresoNombre.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tiene alguna discapacidad";
            // 
            // discapacidadSi
            // 
            this.discapacidadSi.AutoSize = true;
            this.discapacidadSi.Location = new System.Drawing.Point(307, 251);
            this.discapacidadSi.Name = "discapacidadSi";
            this.discapacidadSi.Size = new System.Drawing.Size(41, 21);
            this.discapacidadSi.TabIndex = 28;
            this.discapacidadSi.TabStop = true;
            this.discapacidadSi.Text = "Si";
            this.discapacidadSi.UseVisualStyleBackColor = true;
            // 
            // discapacidadNo
            // 
            this.discapacidadNo.AutoSize = true;
            this.discapacidadNo.Location = new System.Drawing.Point(376, 251);
            this.discapacidadNo.Name = "discapacidadNo";
            this.discapacidadNo.Size = new System.Drawing.Size(47, 21);
            this.discapacidadNo.TabIndex = 29;
            this.discapacidadNo.TabStop = true;
            this.discapacidadNo.Text = "No";
            this.discapacidadNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Formulario de ingreso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Generar turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turnoGenerado
            // 
            this.turnoGenerado.AutoSize = true;
            this.turnoGenerado.Location = new System.Drawing.Point(304, 343);
            this.turnoGenerado.Name = "turnoGenerado";
            this.turnoGenerado.Size = new System.Drawing.Size(201, 17);
            this.turnoGenerado.TabIndex = 32;
            this.turnoGenerado.Text = "Turno generado exitosamente!";
            this.turnoGenerado.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 32);
            this.button2.TabIndex = 33;
            this.button2.Text = "<< Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nuevaPersona
            // 
            this.nuevaPersona.Location = new System.Drawing.Point(310, 388);
            this.nuevaPersona.Name = "nuevaPersona";
            this.nuevaPersona.Size = new System.Drawing.Size(179, 33);
            this.nuevaPersona.TabIndex = 34;
            this.nuevaPersona.Text = "Ingresar nueva persona";
            this.nuevaPersona.UseVisualStyleBackColor = true;
            this.nuevaPersona.Click += new System.EventHandler(this.nuevaPersona_Click);
            // 
            // turnoNoGenerado
            // 
            this.turnoNoGenerado.AutoSize = true;
            this.turnoNoGenerado.Location = new System.Drawing.Point(292, 360);
            this.turnoNoGenerado.Name = "turnoNoGenerado";
            this.turnoNoGenerado.Size = new System.Drawing.Size(245, 17);
            this.turnoNoGenerado.TabIndex = 35;
            this.turnoNoGenerado.Text = "Por favor, complete todos los campos";
            this.turnoNoGenerado.Visible = false;
            // 
            // nombreRequerido
            // 
            this.nombreRequerido.AutoSize = true;
            this.nombreRequerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRequerido.ForeColor = System.Drawing.Color.Red;
            this.nombreRequerido.Location = new System.Drawing.Point(280, 98);
            this.nombreRequerido.Name = "nombreRequerido";
            this.nombreRequerido.Size = new System.Drawing.Size(23, 29);
            this.nombreRequerido.TabIndex = 36;
            this.nombreRequerido.Text = "*";
            this.nombreRequerido.Visible = false;
            // 
            // AgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombreRequerido);
            this.Controls.Add(this.turnoNoGenerado);
            this.Controls.Add(this.nuevaPersona);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.turnoGenerado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discapacidadNo);
            this.Controls.Add(this.discapacidadSi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ingresoEdad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ingresoNombre);
            this.Name = "AgregarPersona";
            this.Text = "AgregarPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ingresoEdad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ingresoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton discapacidadSi;
        private System.Windows.Forms.RadioButton discapacidadNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turnoGenerado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button nuevaPersona;
        private System.Windows.Forms.Label turnoNoGenerado;
        private System.Windows.Forms.Label nombreRequerido;
    }
}