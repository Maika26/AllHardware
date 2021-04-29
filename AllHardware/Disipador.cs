using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Disipador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; } 
        public string Tipo_Disipador { get; set; }
        public string Tamaño_Ventilador { get; set; }

        public Disipador(string marca, string modelo, string tipo_Disipador, string tamaño_Ventilador)
        {
            Marca = marca;
            Modelo = modelo;
            Tipo_Disipador = tipo_Disipador;
            Tamaño_Ventilador = tamaño_Ventilador;
        }
    }
}
