namespace Negocio
{
    partial class AltaProfesor
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
            this.nombreProfesor = new System.Windows.Forms.Label();
            this.ApellidoProf = new System.Windows.Forms.Label();
            this.dniProf = new System.Windows.Forms.Label();
            this.textNombreProf = new System.Windows.Forms.TextBox();
            this.textApellidoProf = new System.Windows.Forms.TextBox();
            this.textDNIprof = new System.Windows.Forms.TextBox();
            this.AceptarAltaProf = new System.Windows.Forms.Button();
            this.CancelarAltaProf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreProfesor
            // 
            this.nombreProfesor.AutoSize = true;
            this.nombreProfesor.Location = new System.Drawing.Point(13, 35);
            this.nombreProfesor.Name = "nombreProfesor";
            this.nombreProfesor.Size = new System.Drawing.Size(50, 13);
            this.nombreProfesor.TabIndex = 0;
            this.nombreProfesor.Text = "Nombre: ";
            // 
            // ApellidoProf
            // 
            this.ApellidoProf.AutoSize = true;
            this.ApellidoProf.Location = new System.Drawing.Point(13, 76);
            this.ApellidoProf.Name = "ApellidoProf";
            this.ApellidoProf.Size = new System.Drawing.Size(50, 13);
            this.ApellidoProf.TabIndex = 1;
            this.ApellidoProf.Text = "Apellido: ";
            // 
            // dniProf
            // 
            this.dniProf.AutoSize = true;
            this.dniProf.Location = new System.Drawing.Point(13, 124);
            this.dniProf.Name = "dniProf";
            this.dniProf.Size = new System.Drawing.Size(29, 13);
            this.dniProf.TabIndex = 2;
            this.dniProf.Text = "DNI:";
            // 
            // textNombreProf
            // 
            this.textNombreProf.Location = new System.Drawing.Point(70, 35);
            this.textNombreProf.Name = "textNombreProf";
            this.textNombreProf.Size = new System.Drawing.Size(100, 20);
            this.textNombreProf.TabIndex = 3;
            // 
            // textApellidoProf
            // 
            this.textApellidoProf.Location = new System.Drawing.Point(70, 76);
            this.textApellidoProf.Name = "textApellidoProf";
            this.textApellidoProf.Size = new System.Drawing.Size(100, 20);
            this.textApellidoProf.TabIndex = 4;
            // 
            // textDNIprof
            // 
            this.textDNIprof.Location = new System.Drawing.Point(70, 117);
            this.textDNIprof.Name = "textDNIprof";
            this.textDNIprof.Size = new System.Drawing.Size(100, 20);
            this.textDNIprof.TabIndex = 5;
            // 
            // AceptarAltaProf
            // 
            this.AceptarAltaProf.Location = new System.Drawing.Point(13, 230);
            this.AceptarAltaProf.Name = "AceptarAltaProf";
            this.AceptarAltaProf.Size = new System.Drawing.Size(75, 23);
            this.AceptarAltaProf.TabIndex = 6;
            this.AceptarAltaProf.Text = "Aceptar";
            this.AceptarAltaProf.UseVisualStyleBackColor = true;
            this.AceptarAltaProf.Click += new System.EventHandler(this.AceptarAltaProf_Click);
            // 
            // CancelarAltaProf
            // 
            this.CancelarAltaProf.Location = new System.Drawing.Point(165, 229);
            this.CancelarAltaProf.Name = "CancelarAltaProf";
            this.CancelarAltaProf.Size = new System.Drawing.Size(75, 23);
            this.CancelarAltaProf.TabIndex = 7;
            this.CancelarAltaProf.Text = "Cancelar";
            this.CancelarAltaProf.UseVisualStyleBackColor = true;
            // 
            // AltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.CancelarAltaProf);
            this.Controls.Add(this.AceptarAltaProf);
            this.Controls.Add(this.textDNIprof);
            this.Controls.Add(this.textApellidoProf);
            this.Controls.Add(this.textNombreProf);
            this.Controls.Add(this.dniProf);
            this.Controls.Add(this.ApellidoProf);
            this.Controls.Add(this.nombreProfesor);
            this.Name = "AltaProfesor";
            this.Text = "AltaProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreProfesor;
        private System.Windows.Forms.Label ApellidoProf;
        private System.Windows.Forms.Label dniProf;
        private System.Windows.Forms.TextBox textNombreProf;
        private System.Windows.Forms.TextBox textApellidoProf;
        private System.Windows.Forms.TextBox textDNIprof;
        private System.Windows.Forms.Button AceptarAltaProf;
        private System.Windows.Forms.Button CancelarAltaProf;
    }
}