﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class SælgerBLL : IPerson
    {
        public int SælgerID { get; set; }
        public int CPR { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
        public string Vej { get; set; }
        public int Postnummer { get; set; }

        public SælgerBLL(int sælgerid, int cpr, int telefon, string email, string fnavn, string enavn, string vej, int postnummer)
        {
            this.SælgerID = sælgerid;
            this.CPR = cpr;
            this.Telefon = telefon;
            this.Email = email;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
            this.Vej = vej;
            this.Postnummer = postnummer;
        }

        public SælgerBLL(int sælgerid, string fnavn, string enavn)
        {
            this.SælgerID = sælgerid;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
        }

        public SælgerBLL(int sælgerid)
        {
            this.SælgerID = sælgerid;
        }

        public SælgerBLL() { }

        public override string ToString()
        {
            return $"{SælgerID} - {Fnavn} {Enavn}";
        }
    }
}
