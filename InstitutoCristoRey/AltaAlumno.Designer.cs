namespace InstitutoCristoRey
{
    partial class AltaAlumno
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
            this.NombreAlum = new System.Windows.Forms.Label();
            this.apellidoAlum = new System.Windows.Forms.Label();
            this.dniAlum = new System.Windows.Forms.Label();
            this.añoIngAlum = new System.Windows.Forms.Label();
            this.textNombreAlum = new System.Windows.Forms.TextBox();
            this.textApellidoAlum = new System.Windows.Forms.TextBox();
            this.textDniAlum = new System.Windows.Forms.TextBox();
            this.textAñoIngAlum = new System.Windows.Forms.TextBox();
            this.aceptarAltaAlum = new System.Windows.Forms.Button();
            this.CancelarAltaAlum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreAlum
            // 
            this.NombreAlum.AutoSize = true;
            this.NombreAlum.Location = new System.Drawing.Point(15, 42);
            this.NombreAlum.Name = "NombreAlum";
            this.NombreAlum.Size = new System.Drawing.Size(50, 13);
            this.NombreAlum.TabIndex = 0;
            this.NombreAlum.Text = "Nombre: ";
            // 
            // apellidoAlum
            // 
            this.apellidoAlum.AutoSize = true;
            this.apellidoAlum.Location = new System.Drawing.Point(15, 82);
            this.apellidoAlum.Name = "apellidoAlum";
            this.apellidoAlum.Size = new System.Drawing.Size(47, 13);
            this.apellidoAlum.TabIndex = 1;
            this.apellidoAlum.Text = "Apellido:";
            // 
            // dniAlum
            // 
            this.dniAlum.AutoSize = true;
            this.dniAlum.Location = new System.Drawing.Point(15, 124);
            this.dniAlum.Name = "dniAlum";
            this.dniAlum.Size = new System.Drawing.Size(29, 13);
            this.dniAlum.TabIndex = 2;
            this.dniAlum.Text = "DNI:";
            this.dniAlum.Click += new System.EventHandler(this.dniAlum_Click);
            // 
            // añoIngAlum
            // 
            this.añoIngAlum.AutoSize = true;
            this.añoIngAlum.Location = new System.Drawing.Point(15, 165);
            this.añoIngAlum.Name = "añoIngAlum";
            this.añoIngAlum.Size = new System.Drawing.Size(66, 13);
            this.añoIngAlum.TabIndex = 3;
            this.añoIngAlum.Text = "Año ingreso:";
            // 
            // textNombreAlum
            // 
            this.textNombreAlum.Location = new System.Drawing.Point(97, 35);
            this.textNombreAlum.Name = "textNombreAlum";
            this.textNombreAlum.Size = new System.Drawing.Size(100, 20);
            this.textNombreAlum.TabIndex = 4;
            // 
            // textApellidoAlum
            // 
            this.textApellidoAlum.Location = new System.Drawing.Point(97, 75);
            this.textApellidoAlum.Name = "textApellidoAlum";
            this.textApellidoAlum.Size = new System.Drawing.Size(100, 20);
            this.textApellidoAlum.TabIndex = 5;
            // 
            // textDniAlum
            // 
            this.textDniAlum.Location = new System.Drawing.Point(97, 117);
            this.textDniAlum.Name = "textDniAlum";
            this.textDniAlum.Size = new System.Drawing.Size(100, 20);
            this.textDniAlum.TabIndex = 6;
            // 
            // textAñoIngAlum
            // 
            this.textAñoIngAlum.Location = new System.Drawing.Point(97, 158);
            this.textAñoIngAlum.Name = "textAñoIngAlum";
            this.textAñoIngAlum.Size = new System.Drawing.Size(100, 20);
            this.textAñoIngAlum.TabIndex = 7;
            // 
            // aceptarAltaAlum
            // 
            this.aceptarAltaAlum.Location = new System.Drawing.Point(18, 249);
            this.aceptarAltaAlum.Name = "aceptarAltaAlum";
            this.aceptarAltaAlum.Size = new System.Drawing.Size(75, 23);
            this.aceptarAltaAlum.TabIndex = 8;
            this.aceptarAltaAlum.Text = "Aceptar";
            this.aceptarAltaAlum.UseVisualStyleBackColor = true;
            this.aceptarAltaAlum.Click += new System.EventHandler(this.aceptarAltaAlum_Click);
            // 
            // CancelarAltaAlum
            // 
            this.CancelarAltaAlum.Location = new System.Drawing.Point(141, 249);
            this.CancelarAltaAlum.Name = "CancelarAltaAlum";
            this.CancelarAltaAlum.Size = new System.Drawing.Size(75, 23);
            this.CancelarAltaAlum.TabIndex = 9;
            this.CancelarAltaAlum.Text = "Cancelar";
            this.CancelarAltaAlum.UseVisualStyleBackColor = true;
            this.CancelarAltaAlum.Click += new System.EventHandler(this.CancelarAltaAlum_Click);
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.CancelarAltaAlum);
            this.Controls.Add(this.aceptarAltaAlum);
            this.Controls.Add(this.textAñoIngAlum);
            this.Controls.Add(this.textDniAlum);
            this.Controls.Add(this.textApellidoAlum);
            this.Controls.Add(this.textNombreAlum);
            this.Controls.Add(this.añoIngAlum);
            this.Controls.Add(this.dniAlum);
            this.Controls.Add(this.apellidoAlum);
            this.Controls.Add(this.NombreAlum);
            this.Name = "AltaAlumno";
            this.Text = "AltaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreAlum;
        private System.Windows.Forms.Label apellidoAlum;
        private System.Windows.Forms.Label dniAlum;
        private System.Windows.Forms.Label añoIngAlum;
        private System.Windows.Forms.TextBox textNombreAlum;
        private System.Windows.Forms.TextBox textApellidoAlum;
        private System.Windows.Forms.TextBox textDniAlum;
        private System.Windows.Forms.TextBox textAñoIngAlum;
        private System.Windows.Forms.Button aceptarAltaAlum;
        private System.Windows.Forms.Button CancelarAltaAlum;
    }
}