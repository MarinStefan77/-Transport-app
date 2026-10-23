using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTransport
{
    public class Marfa
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public double GreutateKg { get; set; }
        public int RutaId { get; set; }
        public Ruta Ruta { get; set; }

        public override string ToString()
        {
            return Denumire + " - " + GreutateKg + " kg";
        }
    }
}