using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Teclado
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Pad_Numerico { get; set; }
        public string Forma_Teclas { get; set; }

        public Teclado(string marca, string modelo, string pad_Numerico, string forma_Teclas)
        {
            Marca = marca;
            Modelo = modelo;
            Pad_Numerico = pad_Numerico;
            Forma_Teclas = forma_Teclas;
        }
    }
}
