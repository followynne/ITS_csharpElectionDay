﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    class Candidato
    {

        public Candidato (string nome, List<Partito> p)
        {
            _nome = nome;
            _partitiAssociati = p;
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private List<Partito> _partitiAssociati;

        public List<Partito> PartitiAssociati
        {
            get { return _partitiAssociati; }
            set { _partitiAssociati = value; }
        }

        private int _votiTot;

        public int VotiTot
        {
            get { return _votiTot; }
            set { _votiTot = value; }
        }
    }
}
