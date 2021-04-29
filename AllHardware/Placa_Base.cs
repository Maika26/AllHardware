using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Placa_Base
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Factor_de_Forma { get; set; }
        public string Slot_Memoria_Ram { get; set; }
        public string Socket { get; set; }
        public string Ranuras_Expansion { get; set; }
        public int Puertos_Sata { get; set; }
        public int Puertos_Usb { get; set; }

        public Placa_Base(string nombre, string tipo, string factor_de_Forma, string slot_Memoria_Ram, 
            string socket, string ranuras_Expansion, int puertos_Sata, int puertos_Usb)
        {
            Nombre = nombre;
            Tipo = tipo;
            Factor_de_Forma = factor_de_Forma;
            Slot_Memoria_Ram = slot_Memoria_Ram;
            Socket = socket;
            Ranuras_Expansion = ranuras_Expansion;
            Puertos_Sata = puertos_Sata;
            Puertos_Usb = puertos_Usb;
        }
    }
}
