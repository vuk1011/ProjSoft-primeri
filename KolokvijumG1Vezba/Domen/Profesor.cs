using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Profesor
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Zvanje { get; set; }
        public string Status { get; set; }
        public string ImePrezime
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }
    }
}
