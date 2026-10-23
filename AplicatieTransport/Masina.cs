using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTransport
{
    public class Masina
    {
        public int Id { get; set; }
        public string NumarInmatriculare { get; set; }
        public string Marca { get; set; }
        public int? SoferId { get; set; }
        public Sofer Sofer { get; set; }
        public override string ToString()
        {
            return Marca + " - " + NumarInmatriculare;
        }
    }
}
