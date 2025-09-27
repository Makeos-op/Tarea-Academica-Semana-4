namespace Tarea_Academica_Semana_4
{
    partial class FormAlbum
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.VerCanciones = new System.Windows.Forms.Button();
            this.Reportes = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(177, 44);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(394, 22);
            this.tbCodigo.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(177, 89);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(394, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(177, 141);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 2;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // VerCanciones
            // 
            this.VerCanciones.Location = new System.Drawing.Point(271, 141);
            this.VerCanciones.Name = "VerCanciones";
            this.VerCanciones.Size = new System.Drawing.Size(121, 23);
            this.VerCanciones.TabIndex = 3;
            this.VerCanciones.Text = "Ver Canciones";
            this.VerCanciones.UseVisualStyleBackColor = true;
            this.VerCanciones.Click += new System.EventHandler(this.VerAlbumes_Click);
            // 
            // Reportes
            // 
            this.Reportes.Location = new System.Drawing.Point(415, 141);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(75, 23);
            this.Reportes.TabIndex = 4;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(496, 141);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(121, 194);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.RowHeadersWidth = 51;
            this.dgAlbumes.RowTemplate.Height = 24;
            this.dgAlbumes.Size = new System.Drawing.Size(518, 227);
            this.dgAlbumes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAlbumes);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reportes);
            this.Controls.Add(this.VerCanciones);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Name = "FormAlbum";
            this.Text = "Tarea-Academica-Semana-4";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button VerCanciones;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}