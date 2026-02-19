using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulation2
{
    public partial class Form1 : Form
    {
        const decimal g = 9.81M;const decimal c = 0.15M; const decimal rho = 1.29M;
        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy,dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Шаг dt, с";
            dataGridView1.Columns[1].Name = "Дальность полёта, м";
            dataGridView1.Columns[2].Name = "Максимальная высота, м";
            dataGridView1.Columns[3].Name = "Скорость в конечной точке, м/с";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                t = 0;
                x= 0;
                y = inputHeight.Value;
                v0 = inputSpeed.Value;
                inputDt.DecimalPlaces = 4;   
                inputDt.Increment = 0.0001M; 
                inputDt.Minimum = 0.0001M;  
                inputDt.Maximum = 1.0M;
                dt = inputDt.Value;
                double a = (double)inputAngle.Value * Math.PI / 180;
                cosa=(decimal)Math.Cos(a);
                sina=(decimal)Math.Sin(a);
                S= inputSize.Value;
                m= inputWeight.Value;
                k = 0.5M * c * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[0].Points.AddXY(x, y);
                timer1.Start();
            }
        }

        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        double yMax, vFinal;
        public void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;
            if ((double) y > yMax) yMax = (double)y;
            chart1.Series[0].Points.AddXY((double)x, (double)y);
            double vFinal =(double) Math.Sqrt((double)(vx * vx + vy * vy));
            if (y <= 0)
            {
                timer1.Stop();
                dataGridView1.Rows.Add((double)dt, x, yMax, vFinal);
            }
        }

        
    }
}
