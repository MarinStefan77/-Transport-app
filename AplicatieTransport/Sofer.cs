using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTransport
{
    public class Sofer
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string NumarPermis { get; set; }
        public string Telefon { get; set; }
        public override string ToString()
        {
            return Nume + " - " + NumarPermis;
        }
    }
}
