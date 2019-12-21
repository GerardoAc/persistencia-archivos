using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNA.Cheques
{
    class Cheque
    {
        public string Receptor { get; set; }
        public string Emisor { get; set; }
        public string Fecha { get; set; }
        public string InstitucionFinaciera { get; set; }
        public string Moneda { get; set; }
        public string Numero { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
    }
}
