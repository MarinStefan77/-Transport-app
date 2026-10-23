using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTransport
{
    public class Ruta
    {
        public int Id { get; set; }
        public string Destinatie { get; set; }
        public double DistantaKm { get; set; }
        public int MasinaId { get; set; }
        public Masina Masina { get; set; }
        public override string ToString()
        {
            return Destinatie + " (" + DistantaKm + " km)";
        }
    }
}
