using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Academica_Semana_4.entities;

namespace Tarea_Academica_Semana_4.repositories
{
    internal class CancionRepository
    {
        public bool Existe(String codigoalbum, string codigocancion)
        {
            List<Album> albumes = AlbumRepository.ListarAlbumes();
            Album album = albumes.Find(a => a.Codigo.Equals(codigoalbum));

            return album.Canciones.Exists(h => h.Codigo.Equals(codigocancion));
        }
        public void Registrar(string codigoalbum, Cancion Cancion)
        {
            List<Album> albumes = AlbumRepository.ListarAlbumes();
            Album album = albumes.Find(a =>a.Codigo.Equals(codigoalbum));
            
            album.Canciones.Add(Cancion);
        }
        public List<Cancion> ListarTodoPorAlbum(string codigoCancion)
        {
            List<Album> albums = AlbumRepository.ListarAlbumes();
            return albums.Where(a => a.Canciones.Exists(b => b.Codigo.Equals(codigoCancion))).SelectMany(a => a.Canciones.Where(b => b.Codigo.Equals(codigoCancion))).ToList();
        }

        public List<Cancion> MostrarCancionMasLarga()
        {
          
        }
        public List<Cancion> MostrarCancionMasCorta()
        {
        }

    }
}
