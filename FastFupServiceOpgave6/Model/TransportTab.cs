using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastFupServiceOpgave6.Model
{
    public class TransportTab
    {
        private int _id;
        private string _lastbil;
        private string _chauffor;
        private DateTime _dato;
        private int _antalKm;
        private double _gennemsnit;

        public TransportTab(int id, string lastbil, string chauffor, DateTime dato, int antalKm, double gennemsnit)
        {
            Id = id;
            Lastbil = lastbil;
            Chauffor = chauffor;
            Dato = dato;
            AntalKm = antalKm;
            Gennemsnit = gennemsnit;
        }

        public TransportTab() { }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Lastbil
        {
            get { return _lastbil; }
            set { _lastbil = value; }
        }

        public string Chauffor
        {
            get { return _chauffor; }
            set { _chauffor = value; }
        }

        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public int AntalKm
        {
            get { return _antalKm; }
            set { _antalKm = value; }
        }

        public double Gennemsnit
        {
            get { return _gennemsnit; }
            set { _gennemsnit = value; }
        }
    }
}
