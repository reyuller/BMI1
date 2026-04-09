using System.Diagnostics.Eventing.Reader;

namespace BMI_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 40;
            progressBar1.Minimum = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight;
            if (double.TryParse(textBox1.Text, out height))
            {
                if (double.TryParse(textBox2.Text, out weight))
                {
                    double BMI = (weight / (height * height));
                    label3.Text = BMI.ToString("0.00");
                    label6.Text = BMI.ToString("0.00");

                    if (BMI >= 40)
                    {
                        progressBar1.Value = 40;
                        label3.Text = "severe  obesity";
                    }
                    else if (BMI <= 10)
                    {
                        progressBar1.Value = 10;
                        label3.Text = "starvation";
                    }
                    else
                    {
                        progressBar1.Value = (int)BMI;
                    }
                    if (BMI > 10 && BMI <= 18)
                    {
                        label3.Text = "underweight";
                    }
                    if (BMI > 18 && BMI <= 25)
                    {
                        label3.Text = "healthy weight";
                    }
                    if (BMI > 25 && BMI <= 30)
                    {
                        label3.Text = "overweight";
                    }
                    if (BMI > 30 && BMI <= 35)
                    {
                        label3.Text = "class 1 obesity";
                    }
                    if (BMI > 35 && BMI < 40)
                    {
                        label3.Text = "class 2 obesity";
                    }
                }
            }
            else
            {
                MessageBox.Show("wype³nij oba pola i podaj liczbê");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
