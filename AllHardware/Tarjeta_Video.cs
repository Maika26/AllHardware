using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Tarjeta_Video
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidad_Memoria { get; set; }
        public string Tamaño_Memoria { get; set; }

        public Tarjeta_Video(string marca, string modelo, string velocidad_Memoria, string tamaño_Memoria)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad_Memoria = velocidad_Memoria;
            Tamaño_Memoria = tamaño_Memoria;
        }
    }
}
