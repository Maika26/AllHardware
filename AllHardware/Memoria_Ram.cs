using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Memoria_Ram
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Compatibilidad { get; set; }
        public string Capacidad { get; set; }
        public string Formato { get; set; }

        public Memoria_Ram(string marca, string modelo, string compatibilidad, string capacidad, string formato)
        {
            Marca = marca;
            Modelo = modelo;
            Compatibilidad = compatibilidad;
            Capacidad = capacidad;
            Formato = formato;
        }
    }
}
