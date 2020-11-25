﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace whg
{
    public partial class Form1 : Form
    {
        GameController gc = new GameController();
        GameArea ga;
        int populationSize = 100;
        int nbrOfSteps = 10;
        int nbrOfStepsIncrement = 10;
        int generation = 1;
        var playerList = from p in gc.GetCurrentPlayers()
                         orderby p.GetFitness() descending
                         select p;
        var topPerformers = playerList.Take(populationSize / 2).ToList();
        public Form1()
        {
            InitializeComponent();
            

            ga = gc.ActivateDisplay();
            this.Controls.Add(ga);
            gc.GameOver += Gc_GameOver;
            for (int i = 1; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOfSteps);
            }
            gc.Start(true);

        }

        private void Gc_GameOver(object sender)
        {
            generation++;
            label1.Text = generation.ToString() + ". generáció";

            gc.ResetCurrentLevel();
            foreach (var p in topPerformers)
            {
                var b = p.Brain.Clone();
                if (generation % 3 == 0)
                    gc.AddPlayer(b.ExpandBrain(nbrOfStepsIncrement));
                else
                    gc.AddPlayer(b);

                if (generation % 3 == 0)
                    gc.AddPlayer(b.Mutate().ExpandBrain(nbrOfStepsIncrement));
                else
                    gc.AddPlayer(b.Mutate());
            }
            gc.Start();
        }

    }
}
