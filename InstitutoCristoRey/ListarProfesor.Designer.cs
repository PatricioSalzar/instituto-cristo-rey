namespace InstitutoCristoRey
{
    partial class ListarProfesor
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
            this.ListadoProf = new System.Windows.Forms.DataGridView();
            this.volverProf = new System.Windows.Forms.Button();
            this.filtrarProf = new System.Windows.Forms.Label();
            this.filtrarNomProf = new System.Windows.Forms.Label();
            this.filtrarApeProf = new System.Windows.Forms.Label();
            this.filtarDniProf = new System.Windows.Forms.Label();
            this.textFiltroNomP = new System.Windows.Forms.TextBox();
            this.textFiltroApeP = new System.Windows.Forms.TextBox();
            this.textFiltroDniP = new System.Windows.Forms.TextBox();
            this.buscarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProf)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoProf
            // 
            this.ListadoProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoProf.Location = new System.Drawing.Point(309, 50);
            this.ListadoProf.Name = "ListadoProf";
            this.ListadoProf.Size = new System.Drawing.Size(703, 265);
            this.ListadoProf.TabIndex = 0;
            // 
            // volverProf
            // 
            this.volverProf.Location = new System.Drawing.Point(167, 291);
            this.volverProf.Name = "volverProf";
            this.volverProf.Size = new System.Drawing.Size(75, 23);
            this.volverProf.TabIndex = 2;
            this.volverProf.Text = "Volver";
            this.volverProf.UseVisualStyleBackColor = true;
            this.volverProf.Click += new System.EventHandler(this.volverProf_Click);
            // 
            // filtrarProf
            // 
            this.filtrarProf.AutoSize = true;
            this.filtrarProf.Location = new System.Drawing.Point(34, 50);
            this.filtrarProf.Name = "filtrarProf";
            this.filtrarProf.Size = new System.Drawing.Size(122, 13);
            this.filtrarProf.TabIndex = 3;
            this.filtrarProf.Text = "FILTRAR PROFERSOR";
            // 
            // filtrarNomProf
            // 
            this.filtrarNomProf.AutoSize = true;
            this.filtrarNomProf.Location = new System.Drawing.Point(32, 112);
            this.filtrarNomProf.Name = "filtrarNomProf";
            this.filtrarNomProf.Size = new System.Drawing.Size(50, 13);
            this.filtrarNomProf.TabIndex = 4;
            this.filtrarNomProf.Text = "Nombre: ";
            // 
            // filtrarApeProf
            // 
            this.filtrarApeProf.AutoSize = true;
            this.filtrarApeProf.Location = new System.Drawing.Point(34, 151);
            this.filtrarApeProf.Name = "filtrarApeProf";
            this.filtrarApeProf.Size = new System.Drawing.Size(50, 13);
            this.filtrarApeProf.TabIndex = 5;
            this.filtrarApeProf.Text = "Apellido: ";
            // 
            // filtarDniProf
            // 
            this.filtarDniProf.AutoSize = true;
            this.filtarDniProf.Location = new System.Drawing.Point(37, 192);
            this.filtarDniProf.Name = "filtarDniProf";
            this.filtarDniProf.Size = new System.Drawing.Size(29, 13);
            this.filtarDniProf.TabIndex = 6;
            this.filtarDniProf.Text = "Dni: ";
            // 
            // textFiltroNomP
            // 
            this.textFiltroNomP.Location = new System.Drawing.Point(128, 105);
            this.textFiltroNomP.Name = "textFiltroNomP";
            this.textFiltroNomP.Size = new System.Drawing.Size(100, 20);
            this.textFiltroNomP.TabIndex = 7;
            // 
            // textFiltroApeP
            // 
            this.textFiltroApeP.Location = new System.Drawing.Point(128, 144);
            this.textFiltroApeP.Name = "textFiltroApeP";
            this.textFiltroApeP.Size = new System.Drawing.Size(100, 20);
            this.textFiltroApeP.TabIndex = 8;
            // 
            // textFiltroDniP
            // 
            this.textFiltroDniP.Location = new System.Drawing.Point(128, 185);
            this.textFiltroDniP.Name = "textFiltroDniP";
            this.textFiltroDniP.Size = new System.Drawing.Size(100, 20);
            this.textFiltroDniP.TabIndex = 9;
            // 
            // buscarFiltros
            // 
            this.buscarFiltros.Location = new System.Drawing.Point(37, 291);
            this.buscarFiltros.Name = "buscarFiltros";
            this.buscarFiltros.Size = new System.Drawing.Size(75, 23);
            this.buscarFiltros.TabIndex = 10;
            this.buscarFiltros.Text = "Buscar";
            this.buscarFiltros.UseVisualStyleBackColor = true;
            this.buscarFiltros.Click += new System.EventHandler(this.buscarFiltros_Click);
            // 
            // ListarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 450);
            this.Controls.Add(this.buscarFiltros);
            this.Controls.Add(this.textFiltroDniP);
            this.Controls.Add(this.textFiltroApeP);
            this.Controls.Add(this.textFiltroNomP);
            this.Controls.Add(this.filtarDniProf);
            this.Controls.Add(this.filtrarApeProf);
            this.Controls.Add(this.filtrarNomProf);
            this.Controls.Add(this.filtrarProf);
            this.Controls.Add(this.volverProf);
            this.Controls.Add(this.ListadoProf);
            this.Name = "ListarProfesor";
            this.Text = "ListarProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoProf;
        private System.Windows.Forms.Button volverProf;
        private System.Windows.Forms.Label filtrarProf;
        private System.Windows.Forms.Label filtrarNomProf;
        private System.Windows.Forms.Label filtrarApeProf;
        private System.Windows.Forms.Label filtarDniProf;
        private System.Windows.Forms.TextBox textFiltroNomP;
        private System.Windows.Forms.TextBox textFiltroApeP;
        private System.Windows.Forms.TextBox textFiltroDniP;
        private System.Windows.Forms.Button buscarFiltros;
    }
}