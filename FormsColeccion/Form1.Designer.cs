﻿
namespace FormsColeccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dirección";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(263, 216);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(411, 38);
            this.txtbNombre.TabIndex = 1;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(263, 327);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(411, 38);
            this.txtbTelefono.TabIndex = 1;
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(263, 451);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(411, 38);
            this.txtbEdad.TabIndex = 1;
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(263, 583);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(411, 38);
            this.txtbDireccion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(68, 739);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(388, 110);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(528, 739);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(388, 110);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 1042);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

