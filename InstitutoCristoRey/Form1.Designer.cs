namespace InstitutoCristoRey
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
            this.components = new System.ComponentModel.Container();
            this.labelICR = new System.Windows.Forms.Label();
            this.OPC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.altaProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaProfesorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProfesorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opciones = new System.Windows.Forms.Label();
            this.OPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelICR
            // 
            this.labelICR.AutoSize = true;
            this.labelICR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelICR.Location = new System.Drawing.Point(29, 124);
            this.labelICR.Name = "labelICR";
            this.labelICR.Size = new System.Drawing.Size(602, 55);
            this.labelICR.TabIndex = 0;
            this.labelICR.Text = "INSTITUTO CRISTO REY";
            // 
            // OPC
            // 
            this.OPC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProfesorToolStripMenuItem,
            this.modificarProfesorToolStripMenuItem});
            this.OPC.Name = "Profesor";
            this.OPC.Size = new System.Drawing.Size(181, 70);
            // 
            // altaProfesorToolStripMenuItem
            // 
            this.altaProfesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAlumnoToolStripMenuItem,
            this.modificarAlumnoToolStripMenuItem});
            this.altaProfesorToolStripMenuItem.Name = "altaProfesorToolStripMenuItem";
            this.altaProfesorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaProfesorToolStripMenuItem.Text = "Alumnos";
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // modificarAlumnoToolStripMenuItem
            // 
            this.modificarAlumnoToolStripMenuItem.Name = "modificarAlumnoToolStripMenuItem";
            this.modificarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarAlumnoToolStripMenuItem.Text = "Modificar Alumno";
            // 
            // modificarProfesorToolStripMenuItem
            // 
            this.modificarProfesorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaProfesorToolStripMenuItem1,
            this.modificarProfesorToolStripMenuItem1,
            this.listarProfesoresToolStripMenuItem,
            this.eliminarProfesorToolStripMenuItem});
            this.modificarProfesorToolStripMenuItem.Name = "modificarProfesorToolStripMenuItem";
            this.modificarProfesorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarProfesorToolStripMenuItem.Text = "Profesor";
            // 
            // altaProfesorToolStripMenuItem1
            // 
            this.altaProfesorToolStripMenuItem1.Name = "altaProfesorToolStripMenuItem1";
            this.altaProfesorToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.altaProfesorToolStripMenuItem1.Text = "Alta Profesor";
            this.altaProfesorToolStripMenuItem1.Click += new System.EventHandler(this.altaProfesorToolStripMenuItem1_Click);
            // 
            // modificarProfesorToolStripMenuItem1
            // 
            this.modificarProfesorToolStripMenuItem1.Name = "modificarProfesorToolStripMenuItem1";
            this.modificarProfesorToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.modificarProfesorToolStripMenuItem1.Text = "Modificar Profesor";
            // 
            // listarProfesoresToolStripMenuItem
            // 
            this.listarProfesoresToolStripMenuItem.Name = "listarProfesoresToolStripMenuItem";
            this.listarProfesoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listarProfesoresToolStripMenuItem.Text = "Listar Profesores";
            // 
            // eliminarProfesorToolStripMenuItem
            // 
            this.eliminarProfesorToolStripMenuItem.Name = "eliminarProfesorToolStripMenuItem";
            this.eliminarProfesorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.eliminarProfesorToolStripMenuItem.Text = "Eliminar Profesor";
            // 
            // opciones
            // 
            this.opciones.AutoSize = true;
            this.opciones.ContextMenuStrip = this.OPC;
            this.opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opciones.Location = new System.Drawing.Point(-1, -1);
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(92, 24);
            this.opciones.TabIndex = 2;
            this.opciones.Text = "Opciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opciones);
            this.Controls.Add(this.labelICR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OPC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelICR;
        private System.Windows.Forms.ContextMenuStrip OPC;
        private System.Windows.Forms.ToolStripMenuItem altaProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaProfesorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarProfesorToolStripMenuItem1;
        private System.Windows.Forms.Label opciones;
        private System.Windows.Forms.ToolStripMenuItem listarProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProfesorToolStripMenuItem;
    }
}

