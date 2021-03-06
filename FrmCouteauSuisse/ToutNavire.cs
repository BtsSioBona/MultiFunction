﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesNavires
{
    /// <summary>
    /// Classe Abstraite ToutNavire
    /// </summary>
    public abstract class ToutNavire
    {
        private int _NoLloyds;
        private string _NomNavire;
        private string _Pavillon;
        private int _Longueur;
        private int _Largeur;
        private int _TirantEau;
        // Variable statique qui renvoit le nombre de Navire, on l'incrémentera sans instancier un objet de cette classe.
        private static int _NbToutNavire;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public ToutNavire(int noLloyds, string nomNavire, string pavillon, int longueur, int largeur, int tirantEau)
        {
            this.NoLloyds = noLloyds;
            this.NomNavire = nomNavire;
            this.Pavillon = pavillon;
            this.Longueur = longueur;
            this.Largeur = largeur;
            this.TirantEau = tirantEau;
        }
        //Getters & Setters.
        public int NoLloyds
        {
            get
            {
                return _NoLloyds;
            }

            set
            {
                _NoLloyds = value;
            }
        }
        public string NomNavire
        {
            get
            {
                return _NomNavire;
            }

            set
            {
                _NomNavire = value;
            }
        }
        public string Pavillon
        {
            get
            {
                return _Pavillon;
            }

            set
            {
                _Pavillon = value;
            }
        }
        public int Longueur
        {
            get
            {
                return _Longueur;
            }

            set
            {
                _Longueur = value;
            }
        }
        public int Largeur
        {
            get
            {
                return _Largeur;
            }

            set
            {
                _Largeur = value;
            }
        }
        public int TirantEau
        {
            get
            {
                return _TirantEau;
            }

            set
            {
                _TirantEau = value;
            }
        }



    }
}
