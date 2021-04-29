using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Fuente_Poder
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Potencia { get; set; }
        public string Fuente_Alimentacion { get; set; }

        public Fuente_Poder(string marca, string modelo, string potencia, string fuente_Alimentacion)
        {
            Marca = marca;
            Modelo = modelo;
            Potencia = potencia;
            Fuente_Alimentacion = fuente_Alimentacion;
        }
    }
}
