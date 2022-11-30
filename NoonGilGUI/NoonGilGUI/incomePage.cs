using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoonGilGUI
{
    public partial class incomeStatus : Form
    {
 
        public incomeStatus()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void incomeStatus_Load(object sender, EventArgs e)
        {

        }
        public double Total(double housing, double transportation, double education, double food, double prepay, double other)
        {
            double total = housing + transportation + education + food + prepay + other;
            return total;
        }
        public double Angle(double total, double categorie)
        {
            double angle = (categorie * 360) / total;

            return angle;
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            try
            {
                double housing = double.Parse(housingInput.Text);
                double food = double.Parse(foodInput.Text);
                double transportation = double.Parse(tranInput.Text);
                double education = double.Parse(eduInput.Text);
                double prepay = double.Parse(preInput.Text);
                double other = double.Parse(otherInput.Text);


                double total = Total(housing, food, transportation, education, prepay, other);


                double totalAngle = 0;

                using (Graphics myGraphics = base.CreateGraphics())

                using (SolidBrush mySolidBrush = new SolidBrush(Color.White))
                {
                    myGraphics.FillEllipse(mySolidBrush, 650, 225, 200, 200);

                    //draw angle for housing
                    double angle = Angle(total, housing);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    //draw angle for transportation
                    mySolidBrush.Color = Color.Chocolate;
                    totalAngle += angle;
                    angle = Angle(total, transportation);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    //draw angle for education
                    mySolidBrush.Color = Color.MediumAquamarine;
                    totalAngle += angle;
                    angle = Angle(total, education);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    //draw angle for food
                    mySolidBrush.Color = Color.Yellow;
                    totalAngle += angle;
                    angle = Angle(total, food);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    //draw angle for prepay
                    mySolidBrush.Color = Color.Wheat;
                    totalAngle += angle;
                    angle = Angle(total, prepay);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    //draw angle for other
                    mySolidBrush.Color = Color.PeachPuff;
                    totalAngle += angle;
                    angle = Angle(total, other);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                }
            }catch(Exception z)
            {
                DialogResult result = MessageBox.Show("try again, one or more werent corectly input", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
