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

        public Moto(string immat, string marque, string modèle, string typeVeh, string couleur, int Puissance) : base(immat, marque, modèle, typeVeh)
        {
            this.Puissance = Puissance;
            this.Couleur = couleur;
        }


    }
}
