using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightQueen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private List<chromosome> pop;

        private void startbut_Click(object sender, EventArgs e)
        {
            SolutionToShow.Maximum = (int)popsize.Value - 1;
            GeneticAlgoritm GA = new GeneticAlgoritm();
            GA.Start((int)popsize.Value, (int)Gen.Value, (double)crossprob.Value, (double)Mutprob.Value, OptimizedMode.Checked);
            pop = GA.Get_population();
            fitness.Text = Convert.ToString(pop[(int)SolutionToShow.Value].fitness);
            board1.DrawQueen(pop[(int)SolutionToShow.Value].gene);
        }

        private void SolutionToShow_ValueChanged(object sender, EventArgs e)
        {
            fitness.Text = Convert.ToString(pop[(int)SolutionToShow.Value].fitness);
            board1.DrawQueen(pop[(int)SolutionToShow.Value].gene);
        }
    }
}
