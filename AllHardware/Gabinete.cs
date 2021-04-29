using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Gabinete
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Compatibilidad_Placa_Madre { get; set; }

        public Gabinete(string marca, string modelo, string color, string compatibilidad_Placa_Madre)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Compatibilidad_Placa_Madre = compatibilidad_Placa_Madre;
        }
    }
}
