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
    public partial class FormCancion : Form
    {
        private CancionService cancionService = new CancionService();
        private string codigoAlbum;
        private void MostrarCancion(List<Cancion> canciones)
        {
            dgCanciones.DataSource = null;
            if (canciones.Count == 0)
            {
                return;
            }
            dgCanciones.DataSource = canciones;
        }
        public FormCancion(string CodigoAlbum)
        {
            InitializeComponent();
            this.codigoAlbum = CodigoAlbum;
            MostrarCancion(CancionService.ListarTodoPorAlbum(codigoAlbum));
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == ""|| tbDuracion.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            Cancion cancion = new Cancion()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Duracion = int.Parse( tbDuracion.Text)  
            };
            bool registrado = cancionService.Registrar(codigoAlbum, cancion);

            MostrarCancion(CancionService.ListarTodoPorAlbum(codigoAlbum));
        }
    }
}
