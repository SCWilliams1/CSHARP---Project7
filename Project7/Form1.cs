using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbWin.Text = "";
            //lbRT1.Text = "";
            btnSpin.Enabled = false;
            btnR.Enabled = false;
            btnM.Enabled = false;
            btnL.Enabled = false;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            bool inp = int.TryParse(txtInput.Text, out int input);
            if (inp && input > 0)
            {
                btnSpin.Enabled = true;
            }
            else
            {
                btnSpin.Enabled = false;
            }
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            btnR.Enabled = true;
            btnM.Enabled = true;
            btnL.Enabled = true;
            txtInput.ReadOnly = true;
            btnSpin.Enabled = false;
            btnL.Focus();
            lbRT1.Text = "Roll";
            lbRT2.Text = "Roll";
            lbRT3.Text = "Roll";
            ti1.Start();
            ti2.Start();
            ti3.Start();
        }

        private void ti1_Tick_1(object sender, EventArgs e)
        {
            //if (lbRT1.Text == "Roll")
            //{
                Random r = new Random();
                int rnd = r.Next(0, 9);
                switch (rnd)
                {
                    case 0:
                        picSlotL.Image = Image.FromFile("../Apple.bmp");
                        break;
                    case 1:
                        picSlotL.Image = Image.FromFile("../Banana.bmp");
                        break;
                    case 2:
                        picSlotL.Image = Image.FromFile("../Cherries.bmp");
                        break;
                    case 3:
                        picSlotL.Image = Image.FromFile("../Grapes.bmp");
                        break;
                    case 4:
                        picSlotL.Image = Image.FromFile("../Lemon.bmp");
                        break;
                    case 5:
                        picSlotL.Image = Image.FromFile("../Lime.bmp");
                        break;
                    case 6:
                        picSlotL.Image = Image.FromFile("../Orange.bmp");
                        break;
                    case 7:
                        picSlotL.Image = Image.FromFile("../Pear.bmp");
                        break;
                    case 8:
                        picSlotL.Image = Image.FromFile("../Strawberry.bmp");
                        break;
                    case 9:
                        picSlotL.Image = Image.FromFile("../Watermelon.bmp");
                        break;
                }
            lbRT1.Text = rnd.ToString();
            //}
        }
        private void ti2_Tick(object sender, EventArgs e)
        {
            //if (lbRT2.Text == "Roll")
            //{
                Random r = new Random();
                int rnd2 = r.Next(0, 9);
                rnd2 = r.Next(0, 9);
                switch (rnd2)
                {
                    case 0:
                        picSlotM.Image = Image.FromFile("../Apple.bmp");
                        break;
                    case 1:
                        picSlotM.Image = Image.FromFile("../Banana.bmp");
                        break;
                    case 2:
                        picSlotM.Image = Image.FromFile("../Cherries.bmp");
                        break;
                    case 3:
                        picSlotM.Image = Image.FromFile("../Grapes.bmp");
                        break;
                    case 4:
                        picSlotM.Image = Image.FromFile("../Lemon.bmp");
                        break;
                    case 5:
                        picSlotM.Image = Image.FromFile("../Lime.bmp");
                        break;
                    case 6:
                        picSlotM.Image = Image.FromFile("../Orange.bmp");
                        break;
                    case 7:
                        picSlotM.Image = Image.FromFile("../Pear.bmp");
                        break;
                    case 8:
                        picSlotM.Image = Image.FromFile("../Strawberry.bmp");
                        break;
                    case 9:
                        picSlotM.Image = Image.FromFile("../Watermelon.bmp");
                        break;
                }
            //}
            lbRT2.Text = rnd2.ToString();
        }
        private void ti3_Tick(object sender, EventArgs e)
        {
            //if (lbRT3.Text == "Roll")
            //{
                Random r = new Random();
                int rnd3 = r.Next(0, 9);
                rnd3 = r.Next(0, 9);
                rnd3 = r.Next(0, 9);

                switch (rnd3)
                {
                    case 0:
                        picSlotR.Image = Image.FromFile("../Apple.bmp");
                        break;
                    case 1:
                        picSlotR.Image = Image.FromFile("../Banana.bmp");
                        break;
                    case 2:
                        picSlotR.Image = Image.FromFile("../Cherries.bmp");
                        break;
                    case 3:
                        picSlotR.Image = Image.FromFile("../Grapes.bmp");
                        break;
                    case 4:
                        picSlotR.Image = Image.FromFile("../Lemon.bmp");
                        break;
                    case 5:
                        picSlotR.Image = Image.FromFile("../Lime.bmp");
                        break;
                    case 6:
                        picSlotR.Image = Image.FromFile("../Orange.bmp");
                        break;
                    case 7:
                        picSlotR.Image = Image.FromFile("../Pear.bmp");
                        break;
                    case 8:
                        picSlotR.Image = Image.FromFile("../Strawberry.bmp");
                        break;
                    case 9:
                        picSlotR.Image = Image.FromFile("../Watermelon.bmp");
                        break;
                }
            //}
            lbRT3.Text = rnd3.ToString();
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            ti1.Stop();
            if (all_stop()){Calculate();}
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            ti2.Stop();
            if (all_stop()){Calculate();}
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            ti3.Stop();
            if (all_stop()){Calculate();}
        }

        private bool all_stop()
        {
            return (ti1.Enabled == false && ti2.Enabled == false && ti3.Enabled == false);
        }

        private void Calculate()
        {
            lbWin.Visible = true;
            int roll_1 = Int32.Parse(lbRT1.Text);
            int roll_2 = Int32.Parse(lbRT2.Text);
            int roll_3 = Int32.Parse(lbRT3.Text);

            int match = 0;
            float input = Int32.Parse(txtInput.Text);

            if (roll_1 == roll_2 || roll_2 == roll_3 || roll_1 == roll_3)
            {
                match++;
            }
            if (roll_1 == roll_2 && roll_2 == roll_3 && roll_1 == roll_3)
            {
                match++;
            }

            switch (match)
            {
                case 0:
                    lbWin.Text = "Nothing Doing";
                    txtOutput.Text = "0";
                    break;
                case 1:
                    lbWin.Text = "Double!";

                    float o = input * 2;
                    txtOutput.Text = o.ToString();
                    break;
                case 2:
                    lbWin.Text = "Triple!";

                    float o1 = input * 3;
                    txtOutput.Text = o1.ToString();
                    break;
            }
            btnSpin.Enabled = true;
            txtInput.Enabled = true;
            txtInput.ReadOnly = false;
        }
    }
}
        
       