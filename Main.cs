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
    public partial class t : Form
    {
        double bmr = 0;
        bool mouseDown;
        public t()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mouseX = MousePosition.X - 400;
                int mouseY = MousePosition.Y- 20;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info infoPanel = new Info();
            infoPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetupApplication();
        }

        public void SetupApplication()
        {
            //Home button
            buttonStart.Visible = false;

            //Labels
            labelTitleData.Text = "Въведете вашите данни";
            labelTitleData.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


            //Data
            textBoxHeight.Visible = true;
            textBoxWeight.Visible = true;
            textBoxAge.Visible = true;
            comboBoxSex.Visible = true;
            comboBoxActivity.Visible = true;
            comboBoxAim.Visible = false;

            textBoxWeight.Text = "";
            textBoxHeight.Text = "";
            textBoxAge.Text = "";
            comboBoxSex.Text = "";
            comboBoxActivity.Text = "";
            comboBoxAim.Text = "";

            //Submit button
            buttonSubmit.Visible = true;

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = int.Parse(textBoxWeight.Text);
                double height = int.Parse(textBoxHeight.Text);
                double age = int.Parse(textBoxAge.Text);
                string sex = comboBoxSex.Text;
                int activityindex = comboBoxActivity.SelectedIndex;
                double activityCoeficent = 0;

                switch (activityindex)
                {
                    case 0:
                        activityCoeficent = 1.2;
                        break;
                    case 1:
                        activityCoeficent = 1.375;
                        break;
                    case 2:
                        activityCoeficent = 1.55;
                        break;
                    case 3:
                        activityCoeficent = 1.725;
                        break;
                    case 4:
                        activityCoeficent = 1.9;
                        break;
                    default:
                        break;
                }

                if (sex == "Мъж")
                {
                    bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5;
                }
                else
                {
                    bmr = (10 * weight) + (6.25 * height) - (5 * age) - 161;
                }
                bmr *= activityCoeficent;

                //Labels
                labelTitleData.Text = "Изберете вашата цел";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;

                //Data
                textBoxHeight.Visible = false;
                textBoxWeight.Visible = false;
                textBoxAge.Visible = false;
                comboBoxSex.Visible = false;
                comboBoxActivity.Visible = false;
                comboBoxAim.Visible = true;

                //Buttons
                buttonSubmit.Visible = false;
                buttonFinalSubmit.Visible = true;
            }
            catch (Exception ex)
            {
                Notification nf = new Notification();
                nf.Notify("Невалидни данни!");
                textBoxWeight.Text = "";
                textBoxHeight.Text = "";
                textBoxAge.Text = "";
                comboBoxSex.Text = "";
                comboBoxActivity.Text = "";

            }
            
        }

        private void buttonFinalSubmit_Click(object sender, EventArgs e)
        {
            int aimIndex = comboBoxAim.SelectedIndex;
            int nCalories = 0;

            if (aimIndex == 0)
            {
                bmr -= 550;
            }
            else
            {
                bmr += 100;
            }
            Result result = new Result();
            result.PrintData(bmr);
            SetupApplication();
        }

    }
}
