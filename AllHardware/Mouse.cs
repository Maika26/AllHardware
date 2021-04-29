using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class Mouse
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Inalambrico { get; set; }
        public string Alcance_Maximo { get; set; }

        public Mouse(string marca, string modelo, string inalambrico, string alcance_Maximo)
        {
            Marca = marca;
            Modelo = modelo;
            Inalambrico = inalambrico;
            Alcance_Maximo = alcance_Maximo;
        }
    }
}
