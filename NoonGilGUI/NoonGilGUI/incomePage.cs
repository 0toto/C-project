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

                double angle = Angle(total, housing);

                double totalAngle = 0;

                using (Graphics myGraphics = base.CreateGraphics())

                using (SolidBrush mySolidBrush = new SolidBrush(Color.DarkBlue))
                {
                    myGraphics.FillEllipse(mySolidBrush, 650, 225, 200, 200);

                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    mySolidBrush.Color = Color.Chocolate;
                    totalAngle += angle;
                    angle = Angle(total, food);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    mySolidBrush.Color = Color.Cyan;
                    totalAngle += angle;
                    angle = Angle(total, transportation);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    mySolidBrush.Color = Color.Yellow;
                    totalAngle += angle;
                    angle = Angle(total, education);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    mySolidBrush.Color = Color.DarkGreen;
                    totalAngle += angle;
                    angle = Angle(total, prepay);
                    myGraphics.FillPie(mySolidBrush, 650, 225, 200, 200, (float)totalAngle, (float)angle);

                    mySolidBrush.Color = Color.Lime;
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
    }
}
