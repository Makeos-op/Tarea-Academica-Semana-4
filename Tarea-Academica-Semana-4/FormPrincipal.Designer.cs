namespace Tarea_Academica_Semana_4
{
    partial class FormPrincipal
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
            this.VerAlbumes = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerAlbumes
            // 
            this.VerAlbumes.Location = new System.Drawing.Point(209, 122);
            this.VerAlbumes.Name = "VerAlbumes";
            this.VerAlbumes.Size = new System.Drawing.Size(121, 23);
            this.VerAlbumes.TabIndex = 0;
            this.VerAlbumes.Text = "Ver Albumes";
            this.VerAlbumes.UseVisualStyleBackColor = true;
            this.VerAlbumes.Click += new System.EventHandler(this.VerAlbumes_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(231, 185);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 329);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.VerAlbumes);
            this.Name = "FormPrincipal";
            this.Text = "Tarea-Academica-Semana-4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VerAlbumes;
        private System.Windows.Forms.Button Salir;
    }
}