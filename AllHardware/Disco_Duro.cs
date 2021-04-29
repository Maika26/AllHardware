using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Disco_Duro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Capacidad { get; set; }
        public string Compatibilidad { get; set; }

        public Disco_Duro(string marca, string modelo, string capacidad, string compatibilidad)
        {
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            Compatibilidad = compatibilidad;
        }
    }
}
