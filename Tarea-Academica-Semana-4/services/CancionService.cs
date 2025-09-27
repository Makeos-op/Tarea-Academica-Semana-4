using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_Academica_Semana_4.entities;
using Tarea_Academica_Semana_4.repositories;

namespace Tarea_Academica_Semana_4.services
{
    internal class CancionService
    {
        private CancionRepository cancionRepository = new CancionRepository();
        public bool Registrar(string codigoAlbum, Cancion cancion)
        {
            if (cancionRepository.Existe(codigoAlbum, cancion.Codigo))
            {
                return false;
            }
            cancionRepository.Registrar(codigoAlbum, cancion);
            return true;
        }
        public static List<Cancion> ListarTodoPorAlbum(string codigoAlbum)
        {
            return CancionRepository.ListarTodoPorAlbum(codigoAlbum);
        }

        public List<Cancion> MostrarCancionMasLarga()
        {
            return cancionRepository.MostrarCancionMasLarga();
        }
        public List<Cancion> MostrarCancionMasCorta()
        {
            return cancionRepository.MostrarCancionMasCorta();
        }
    }
}
