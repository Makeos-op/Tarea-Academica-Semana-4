using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Academica_Semana_4
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void VerAlbumes_Click(object sender, EventArgs e)
        {
            FormAlbum form = new FormAlbum();
            form.Show(); 
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
