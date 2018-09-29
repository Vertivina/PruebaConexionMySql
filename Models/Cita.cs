using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demowebmvc.Models
{
    public class Cita
    {
        public string nombre { get; set; }
        public string mascota { get; set; }
        public int numTelefono { get; set; }
        public string tipoTel { get; set; }
        public string doctor { get; set; }
        public int hora { get; set; }
        public string fecha { get; set; }
        public string tipoM { get; set; }
        public string tipoCita { get; set; }
        public string direccion { get; set; }

        public Cita()
        {

        }

        public Cita(string nom, string mas, int num,string tt, string doc, int ho, 
            string fec, string tm, string tc, string dir)
        {
            tipoTel = tt;
            nombre = nom;
            mascota = mas;
            numTelefono = num;
            doctor = doc;
            hora = ho;
            fecha = fec;
            tipoM = tm;
            tipoCita = tc;
            direccion = dir;

        }
        public Cita(string nom, string mas, int num, string tt, string doc, int ho,
            string fec, string tm, string tc)
        {
            nombre = nom;
            mascota = mas;
            numTelefono = num;
            doctor = doc;
            hora = ho;
            fecha = fec;
            tipoM = tm;
            tipoCita = tc;
        }



    }
}
