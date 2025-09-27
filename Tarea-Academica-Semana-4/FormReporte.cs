using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Academica_Semana_4.entities;
using Tarea_Academica_Semana_4.services;

namespace Tarea_Academica_Semana_4
{
    public partial class FormReporte : Form
    {
        private AlbumService albumService = new AlbumService(); 
        private CancionService cancionService = new CancionService();
        public FormReporte()
        {
            InitializeComponent();
        }
        private void MostrarAlbumes(List<Album> albumes)
        {
            dgAlbumes.DataSource = null;
            if (albumes.Count == 0)
            {
                return;
            }
            dgAlbumes.DataSource = albumes;

        }
        private void MostrarCancion(List<Cancion> canciones)
        {
            dgCanciones.DataSource = null;
            if (canciones.Count == 0)
            {
                return;
            }
            dgCanciones.DataSource = canciones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumService.MostrarAlbumConMasCanciones());
        }

        private void Albumes_segun_heroe_Click(object sender, EventArgs e)
        {
            if (tbCodigoCancion.Text == "")
            {
                MessageBox.Show("Debe ingresar el codigo de la cancion");
                return;
            }
            string codigoCancion = tbCodigoCancion.Text;
            MostrarAlbumes(albumService.MostrarAlbumconCancion(codigoCancion));
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarCancion(cancionService.MostrarCancionMasCorta());
        }

        private void MayorDuracion_Click(object sender, EventArgs e)
        {
            MostrarCancion(cancionService.MostrarCancionMasLarga());
        }
    }
}
