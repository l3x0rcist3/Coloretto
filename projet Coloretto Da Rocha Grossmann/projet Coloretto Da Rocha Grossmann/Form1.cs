﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet_Coloretto_Da_Rocha_Grossmann
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Jeu coloretto = new Jeu();
            Joueur cloclo = new Joueur("clocloleCharclo", "JauneAsiatique");
        }








        private void DeuxJoueurs(Jeu coloretto)
        {
            if (coloretto.NbJoueurs == 2)
            {
                coloretto.DeuxJoueurs = true;
            }
            else coloretto.DeuxJoueurs = false;
        }




    }
}
