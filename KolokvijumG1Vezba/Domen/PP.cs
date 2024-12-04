using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class PP
    {
        public Profesor Profesor { get; set; }
        public Predmet Predmet { get; set; }
        public string ProfesorPrikaz { get { return Profesor.ImePrezime; } }
        public string PredmetPrikaz { get { return Predmet.Naziv; } }
    }
}
