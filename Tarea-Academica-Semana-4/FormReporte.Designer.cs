namespace Tarea_Academica_Semana_4
{
    partial class FormReporte
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
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.dgCanciones = new System.Windows.Forms.DataGridView();
            this.AlbumMasCanciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoCancion = new System.Windows.Forms.TextBox();
            this.Albumes_segun_heroe = new System.Windows.Forms.Button();
            this.MayorDuracion = new System.Windows.Forms.Button();
            this.MenorDuracion = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(348, 27);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.RowHeadersWidth = 51;
            this.dgAlbumes.RowTemplate.Height = 24;
            this.dgAlbumes.Size = new System.Drawing.Size(480, 193);
            this.dgAlbumes.TabIndex = 7;
            // 
            // dgCanciones
            // 
            this.dgCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCanciones.Location = new System.Drawing.Point(348, 245);
            this.dgCanciones.Name = "dgCanciones";
            this.dgCanciones.RowHeadersWidth = 51;
            this.dgCanciones.RowTemplate.Height = 24;
            this.dgCanciones.Size = new System.Drawing.Size(480, 193);
            this.dgCanciones.TabIndex = 16;
            // 
            // AlbumMasCanciones
            // 
            this.AlbumMasCanciones.Location = new System.Drawing.Point(34, 27);
            this.AlbumMasCanciones.Name = "AlbumMasCanciones";
            this.AlbumMasCanciones.Size = new System.Drawing.Size(233, 23);
            this.AlbumMasCanciones.TabIndex = 17;
            this.AlbumMasCanciones.Text = "Obtener album con mas canciones";
            this.AlbumMasCanciones.UseVisualStyleBackColor = true;
            this.AlbumMasCanciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = " Codigo de Cancion";
            // 
            // tbCodigoCancion
            // 
            this.tbCodigoCancion.Location = new System.Drawing.Point(143, 77);
            this.tbCodigoCancion.Name = "tbCodigoCancion";
            this.tbCodigoCancion.Size = new System.Drawing.Size(159, 22);
            this.tbCodigoCancion.TabIndex = 19;
            // 
            // Albumes_segun_heroe
            // 
            this.Albumes_segun_heroe.Location = new System.Drawing.Point(15, 124);
            this.Albumes_segun_heroe.Name = "Albumes_segun_heroe";
            this.Albumes_segun_heroe.Size = new System.Drawing.Size(252, 23);
            this.Albumes_segun_heroe.TabIndex = 20;
            this.Albumes_segun_heroe.Text = "Listar albumes segun cancion";
            this.Albumes_segun_heroe.UseVisualStyleBackColor = true;
            this.Albumes_segun_heroe.Click += new System.EventHandler(this.Albumes_segun_heroe_Click);
            // 
            // MayorDuracion
            // 
            this.MayorDuracion.Location = new System.Drawing.Point(16, 277);
            this.MayorDuracion.Name = "MayorDuracion";
            this.MayorDuracion.Size = new System.Drawing.Size(251, 23);
            this.MayorDuracion.TabIndex = 21;
            this.MayorDuracion.Text = "Obtener cancion con mayor duracion";
            this.MayorDuracion.UseVisualStyleBackColor = true;
            this.MayorDuracion.Click += new System.EventHandler(this.MayorDuracion_Click);
            // 
            // MenorDuracion
            // 
            this.MenorDuracion.Location = new System.Drawing.Point(17, 340);
            this.MenorDuracion.Name = "MenorDuracion";
            this.MenorDuracion.Size = new System.Drawing.Size(250, 23);
            this.MenorDuracion.TabIndex = 22;
            this.MenorDuracion.Text = "Obtener cancion con menor duracion";
            this.MenorDuracion.UseVisualStyleBackColor = true;
            this.MenorDuracion.Click += new System.EventHandler(this.button2_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(17, 403);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 23;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.MenorDuracion);
            this.Controls.Add(this.MayorDuracion);
            this.Controls.Add(this.Albumes_segun_heroe);
            this.Controls.Add(this.tbCodigoCancion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlbumMasCanciones);
            this.Controls.Add(this.dgCanciones);
            this.Controls.Add(this.dgAlbumes);
            this.Name = "FormReporte";
            this.Text = "Tarea-Academica-Semana-4";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.DataGridView dgCanciones;
        private System.Windows.Forms.Button AlbumMasCanciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoCancion;
        private System.Windows.Forms.Button Albumes_segun_heroe;
        private System.Windows.Forms.Button MayorDuracion;
        private System.Windows.Forms.Button MenorDuracion;
        private System.Windows.Forms.Button Salir;
    }
}