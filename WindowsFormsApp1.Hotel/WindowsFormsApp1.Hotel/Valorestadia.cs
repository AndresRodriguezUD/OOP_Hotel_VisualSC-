using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Hotel
{
    class Valorestadia
    {
        private string hotel;
        private string sucursal;
        private decimal precio;

        public string Hotel { get; set; }
        public string Sucursal { get; set; }
        public decimal Precio { get; set; }



        public decimal CalcularAlojamiento(string hotel, string sucursal, decimal precio);



    }
}
