using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Academica_Semana_4.entities;

namespace Tarea_Academica_Semana_4.repositories
{
    internal class AlbumRepository
    {
        private static List<Album> Albumes = new List<Album>();
        public bool ExisteAlbum(string codigo)
        {
            return Albumes.Exists(a => a.Codigo.Equals(codigo));
        }
        public void RegistrarAlbum(Album album)
        {
            Albumes.Add(album);
        }
        public static List<Album> ListarAlbumes()
        {
            return Albumes;
        }

        public List<Album> MostrarAlbumConMasCanciones()
        {
            int AlbumConMasCanciones =
                Albumes.Count == 0 ?
                0
                :
                Albumes.Max(a => a.Canciones.Count);
            return Albumes.Where(a => a.Canciones.Count == AlbumConMasCanciones).ToList();
        }
        public List<Album> MostrarAlbum(string codigo)
        {
            return Albumes.Where(a => a.Canciones.Exists(b => b.Codigo.Equals(codigo))).ToList();
        }

    }
}
