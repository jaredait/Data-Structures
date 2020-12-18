
namespace Grafos006MatrizAyacencia_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAgregarVertice = new System.Windows.Forms.Button();
            this.botonAgregarArco = new System.Windows.Forms.Button();
            this.botonEliminarVertice = new System.Windows.Forms.Button();
            this.pantallaImpresion = new System.Windows.Forms.TextBox();
            this.entradaFila = new System.Windows.Forms.TextBox();
            this.entradaColumna = new System.Windows.Forms.TextBox();
            this.entradaEliminarVertice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonAgregarVertice
            // 
            this.botonAgregarVertice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(230)))));
            this.botonAgregarVertice.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarVertice.Location = new System.Drawing.Point(72, 274);
            this.botonAgregarVertice.Name = "botonAgregarVertice";
            this.botonAgregarVertice.Size = new System.Drawing.Size(166, 64);
            this.botonAgregarVertice.TabIndex = 0;
            this.botonAgregarVertice.Text = "Agregar vertice";
            this.botonAgregarVertice.UseVisualStyleBackColor = false;
            this.botonAgregarVertice.Click += new System.EventHandler(this.botonAgregarVertice_Click);
            // 
            // botonAgregarArco
            // 
            this.botonAgregarArco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(230)))));
            this.botonAgregarArco.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarArco.Location = new System.Drawing.Point(304, 274);
            this.botonAgregarArco.Name = "botonAgregarArco";
            this.botonAgregarArco.Size = new System.Drawing.Size(166, 64);
            this.botonAgregarArco.TabIndex = 1;
            this.botonAgregarArco.Text = "Agregar arco";
            this.botonAgregarArco.UseVisualStyleBackColor = false;
            this.botonAgregarArco.Click += new System.EventHandler(this.botonAgregarArco_Click);
            // 
            // botonEliminarVertice
            // 
            this.botonEliminarVertice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(230)))));
            this.botonEliminarVertice.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminarVertice.Location = new System.Drawing.Point(528, 274);
            this.botonEliminarVertice.Name = "botonEliminarVertice";
            this.botonEliminarVertice.Size = new System.Drawing.Size(166, 64);
            this.botonEliminarVertice.TabIndex = 2;
            this.botonEliminarVertice.Text = "Eliminar vertice";
            this.botonEliminarVertice.UseVisualStyleBackColor = false;
            this.botonEliminarVertice.Click += new System.EventHandler(this.botonEliminarVertice_Click);
            // 
            // pantallaImpresion
            // 
            this.pantallaImpresion.BackColor = System.Drawing.Color.White;
            this.pantallaImpresion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pantallaImpresion.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaImpresion.Location = new System.Drawing.Point(258, 29);
            this.pantallaImpresion.Multiline = true;
            this.pantallaImpresion.Name = "pantallaImpresion";
            this.pantallaImpresion.ReadOnly = true;
            this.pantallaImpresion.Size = new System.Drawing.Size(259, 224);
            this.pantallaImpresion.TabIndex = 6;
            // 
            // entradaFila
            // 
            this.entradaFila.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaFila.Location = new System.Drawing.Point(399, 353);
            this.entradaFila.MaxLength = 1;
            this.entradaFila.Name = "entradaFila";
            this.entradaFila.Size = new System.Drawing.Size(37, 29);
            this.entradaFila.TabIndex = 7;
            this.entradaFila.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entradaColumna
            // 
            this.entradaColumna.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaColumna.Location = new System.Drawing.Point(399, 397);
            this.entradaColumna.MaxLength = 1;
            this.entradaColumna.Name = "entradaColumna";
            this.entradaColumna.Size = new System.Drawing.Size(37, 29);
            this.entradaColumna.TabIndex = 8;
            this.entradaColumna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entradaEliminarVertice
            // 
            this.entradaEliminarVertice.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaEliminarVertice.Location = new System.Drawing.Point(598, 353);
            this.entradaEliminarVertice.MaxLength = 1;
            this.entradaEliminarVertice.Name = "entradaEliminarVertice";
            this.entradaEliminarVertice.Size = new System.Drawing.Size(37, 29);
            this.entradaEliminarVertice.TabIndex = 9;
            this.entradaEliminarVertice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Columna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 4);
            this.label3.TabIndex = 12;
            this.label3.Text = "...............";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 4);
            this.label4.TabIndex = 13;
            this.label4.Text = "...............";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(4, 200);
            this.label5.TabIndex = 14;
            this.label5.Text = ".\r\n.\r\n.\r\n.\r\n.\r\n.\r\n\n.\r\n\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n\r\n.\r\n.\r\n\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r" +
    "\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(4, 200);
            this.label6.TabIndex = 15;
            this.label6.Text = ".\r\n.\r\n.\r\n.\r\n.\r\n.\r\n\n.\r\n\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n\r\n.\r\n.\r\n\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r" +
    "\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n.\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(503, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 4);
            this.label7.TabIndex = 16;
            this.label7.Text = "...............";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 4);
            this.label8.TabIndex = 17;
            this.label8.Text = "...............";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entradaEliminarVertice);
            this.Controls.Add(this.entradaColumna);
            this.Controls.Add(this.entradaFila);
            this.Controls.Add(this.pantallaImpresion);
            this.Controls.Add(this.botonEliminarVertice);
            this.Controls.Add(this.botonAgregarArco);
            this.Controls.Add(this.botonAgregarVertice);
            this.Name = "Form1";
            this.Text = "Matriz de Adyacencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAgregarVertice;
        private System.Windows.Forms.Button botonAgregarArco;
        private System.Windows.Forms.Button botonEliminarVertice;
        private System.Windows.Forms.TextBox pantallaImpresion;
        private System.Windows.Forms.TextBox entradaFila;
        private System.Windows.Forms.TextBox entradaColumna;
        private System.Windows.Forms.TextBox entradaEliminarVertice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

