using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Ventilador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidad { get; set; }
        public string Voltaje_Entrada { get; set; }

        public Ventilador(string marca, string modelo, string velocidad, string voltaje_Entrada)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad = velocidad;
            Voltaje_Entrada = voltaje_Entrada;
        }
    }
}
