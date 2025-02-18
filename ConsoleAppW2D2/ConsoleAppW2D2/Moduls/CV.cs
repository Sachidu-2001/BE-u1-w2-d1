using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW2D2.Moduls
{
    public class CV
    {
        public class InformazioniPersonali 
        {
            public string Nome { get; set; } = "";
            public string Cognome { get; set; } = "";
            public string Telefono { get; set; } = "";
            public string Email { get; set; } = "";

        }
        public class StudiEffettuati
        {
            public string Qualifica { get; set; }
            public string Istituto { get; set; }
            public string Tipo { get; set; }
            public DateTime Dal { get; set; }
            public DateTime Al { get; set; }
        }
        public class Impieghi
        {
            public class Esperienza
            {
                public string Azienda { get; set; }
                public string JobTitle { get; set; }
                public DateTime Dal { get; set; }
                public DateTime Al { get; set; }
                public string Descrizione { get; set; }
                public string Compiti { get; set; }
            }
        }



    }
}
