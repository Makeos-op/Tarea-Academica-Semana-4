using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Academica_Semana_4.entities
{
    internal class Album
    {
        public Album() { }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Cancion> Canciones { get; set; }
    }
}
