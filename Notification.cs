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
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
        public void Notify(string text)
        {
            labelText.Text = text;
            this.Show();
        }

        private void Notification_Load(object sender, EventArgs e)
        {

        }
    }
}
