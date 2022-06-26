using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesCalculator
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void PrintData(double calories)
        {
            this.Show();
            labelCalories.Text = calories.ToString();
            double carbCalories = calories * 0.50;
            double fatCalories = calories * 0.30;
            double proteinCalories = calories * 0.15;
            double carbGrams = carbCalories / 4;
            double proteinGrams = proteinCalories / 4;
            double fatGrams = fatCalories / 8.3;
            labelCarbs.Text = carbGrams.ToString();
            labelFats.Text = fatGrams.ToString();
            labelProteins.Text = proteinGrams.ToString();

        }
    }
}
