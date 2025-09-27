using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Academica_Semana_4.entities;
using Tarea_Academica_Semana_4.repositories;

namespace Tarea_Academica_Semana_4.services
{
    internal class AlbumService
    {
        private AlbumRepository albumRepository = new AlbumRepository();
        public bool Registrar(Album album)
        {
            if (albumRepository.ExisteAlbum(album.Codigo))
            {
                return false;
            }
            albumRepository.RegistrarAlbum(album);
            return true;
        }

        public static List<Album> ListarAlbumes()
        {
            return AlbumRepository.ListarAlbumes();
        }

        public List<Album> MostrarAlbumConMasCanciones()
        {
            return albumRepository.MostrarAlbumConMasCanciones();
        }
        public List<Album> MostrarAlbumconCancion(string codigoCancion)
        {
            return albumRepository.MostrarAlbumconCancion(codigoCancion);
        }
    }
}
