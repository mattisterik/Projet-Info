﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Info
{
    class Moto : Véhicule
    {
        private int Puissance;
        private string Couleur;
        public string couleur
        {
            get { return Couleur; }
        }
        public int puissance
        {
            get { return Puissance; }
        }

        public Moto(string Immat, string Marque, string Modèle, string TypeVeh, string Contrôleur, string Emplacement, int NbKm, string Couleur, int Puissance) : base(Immat, Marque, Modèle, TypeVeh, Contrôleur, Emplacement, NbKm)
        {
            this.Puissance = Puissance;
            this.Couleur = Couleur;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + Couleur + ";" + puissance;
        }
        public override double CalculCout(int nbKm)
        {
            double c = 0;
            c = 0.20 * nbKm;
            return c;
        }
    }
}
