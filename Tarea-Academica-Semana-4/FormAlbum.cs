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
    public partial class FormAlbum : Form
    {
        private AlbumService albumService = new AlbumService();
        public FormAlbum()
        {
            InitializeComponent();
            MostrarAlbumes(AlbumService.ListarAlbumes());
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

        private void VerAlbumes_Click(object sender, EventArgs e)
        {
            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un album");
                return;
            }
            string codigoAlbum = dgAlbumes.SelectedRows[0].Cells["Codigo"].Value.ToString();
            FormCancion form = new FormCancion(codigoAlbum);
            form.Show();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == ""|| tbNombre.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            //Crear el objeto album
            Album album = new Album()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Canciones = new List<Cancion>()
            };

            bool registrado = albumService.Registrar(album);
            if(!registrado)
            {
                MessageBox.Show("El codigo del album ya existe");
                return;
            }
            MostrarAlbumes(AlbumService.ListarAlbumes());
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();    
        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }
    }
}
