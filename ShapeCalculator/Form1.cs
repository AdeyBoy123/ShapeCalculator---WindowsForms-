using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAreaCalc_Click(object sender, EventArgs e) //Rectangle Area Button
        {
            int length, height, area;

            if(int.TryParse(textBoxLength.Text, out length) && int.TryParse(textBoxHeight.Text, out height))
            {
                area = length * height;
                textBoxArea.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for length and height");
            }
            //length = Convert.ToInt32(textBoxLength.Text);
           // height = Convert.ToInt32(textBoxHeight.Text);
        }

        private void button1_Click(object sender, EventArgs e) //Clear Button for all
        {
            textBoxHeight.Clear();
            textBoxLength.Clear();
            textBoxArea.Clear();
            textBoxPerimeter.Clear();
            textBoxCircleCircumference.Clear();
            textBoxCircleArea.Clear();
            textBoxRadius.Clear();
            textBoxTriangleArea.Clear();
            textBoxTriangleBase.Clear();
            textBoxTriangleHeight.Clear();
            textBoxTrianglePerimeter.Clear();
            textBoxTriangleSide1.Clear();
            textBoxTriangleSide2.Clear();
            textBoxTriangleSide3.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //Rectangle Perimeter Button
        {
            int length, height, perimeter;
            length = Convert.ToInt32(textBoxLength.Text);
            height = Convert.ToInt32(textBoxHeight.Text);
            perimeter = 2 * (length + height);
            textBoxPerimeter.Text = perimeter.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //Circle Area Button
        {
            double radius, area;
            radius = Convert.ToDouble(textBoxRadius.Text);
            area = Math.PI*radius*radius;
            textBoxCircleArea.Text = area.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //Circle Perimeter Button
        {
            double radius, circumference;
            radius = Convert.ToDouble(textBoxRadius.Text);
            circumference = 2*Math.PI*radius;
            textBoxCircleCircumference.Text = circumference.ToString();


        }

        private void buttonTriangleArea_Click(object sender, EventArgs e) //Triangle Area Button
        {
            double height, Base, area;
            Base = Convert.ToDouble(textBoxTriangleBase.Text);
            height = Convert.ToDouble(textBoxTriangleHeight.Text);
            area = (Base * height)/2;
            textBoxTriangleArea.Text = area.ToString();
        }

        private void buttonTrianglePerimeter_Click(object sender, EventArgs e)
        {
            double side1, side2, side3, perimeter;
            side1 = Convert.ToDouble(textBoxTriangleSide1.Text);
            side2 = Convert.ToDouble(textBoxTriangleSide2.Text);
            side3 = Convert.ToDouble(textBoxTriangleSide3.Text);
            perimeter = side1+side2+side3;
            textBoxTrianglePerimeter.Text = perimeter.ToString();

        }
    }
}
