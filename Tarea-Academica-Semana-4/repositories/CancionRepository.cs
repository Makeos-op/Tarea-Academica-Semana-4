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
        public List<Cancion> ListarTodoPorAlbum(string codigoAlbum)
        {
            List<Album> albums = AlbumRepository.ListarAlbumes();
            Album album = albums.Find(a => a.Codigo.Equals(codigoAlbum));
            return album.Canciones;
        }

        public List<Cancion> MostrarCancionMasLarga()
        {
            List<Album> albums = AlbumRepository.ListarAlbumes();
            double menorduracion = albums.Max(a => a.Canciones.Max(b => b.Duracion));
            return albums.SelectMany(a => a.Canciones).Where(c => c.Duracion == menorduracion).ToList(); // SelectMany fue aprendido por cuenta propia
        }
        public List<Cancion> MostrarCancionMasCorta()
        {
            List<Album> albums = AlbumRepository.ListarAlbumes();
            double menorduracion = albums.Min(a => a.Canciones.Min(b => b.Duracion));
            return albums.SelectMany(a => a.Canciones).Where(c => c.Duracion == menorduracion).ToList(); // SelectMany fue aprendido por cuenta propia
        }

    }
}
