﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Info
{
    class Camion:Véhicule
    {
        private int Volume;
        public int volume
        {
            get { return Volume; }
        }

        public Camion(string Immat, string Marque, string Modèle, string TypeVeh, int Volume) :base(Immat, Marque, Modèle, TypeVeh)
        {
            this.Volume = Volume;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + volume;
        }
        public override double Cout(int nbKm)
        {
            double c = 0;
            c = 0.30 * nbKm;
            return c;
        }
    }
}
