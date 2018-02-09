using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm03
{
    class Habitantes
    {
        public DateTime FechaEntrada { get; set; }
        public string Nombre { get; set; }

        public Habitantes(DateTime _fechaEntrada, string _nombre)
        {
            FechaEntrada = _fechaEntrada;
            Nombre = _nombre;
        }
    }
}
