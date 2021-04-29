using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Procesador
    {
        public string Modelo { get; set; }
        public string Zocalo { get; set; }
        public int Numero_Nucleos { get; set; }
        public int Numero_Hilos { get; set; }
        public string Frecuencia_Reloj { get; set; }

        public Procesador(string modelo, string zocalo, int numero_Nucleos, int numero_Hilos, string frecuencia_Reloj)
        {
            Modelo = modelo;
            Zocalo = zocalo;
            Numero_Nucleos = numero_Nucleos;
            Numero_Hilos = numero_Hilos;
            Frecuencia_Reloj = frecuencia_Reloj;
        }
    }
}
