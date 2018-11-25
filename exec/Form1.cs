using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace exec
{

    /// <summary>
    /// delta(ni) * e^(-kti)
    /// </summary>
    public struct FirstEvaluate
    {
        public static double evaluate(double delta, double k, double ti)
        {
            return delta * Math.Exp(-k * ti);
        }
    }
    /// <summary>
    /// ti*e^(-kti2)
    /// </summary>
    public struct SecondEvaluate
    {
        public static double evaluate(double ti, double k)
        {
            return ti * Math.Exp(2 * (-k) * ti);
        }
    }
    /// <summary>
    /// (e^(-kti))2
    /// </summary>
    public struct ThirdEvaluate
    {
        public static double evaluate(double k, double ti)
        {
            return Math.Pow(Math.Exp(-k * ti), 2);
        }
    }
    /// <summary>
    /// delta(ni) * ti * e^(-kti)
    /// </summary>
    public struct FourthEvaluate
    {
        public static double evaluate(double delta, double k, double ti)
        {
            return FirstEvaluate.evaluate(delta, k, ti) * ti;
        }
    }

    public partial class Form1 : Form
    {
        private double K;
        private double N0;
        private double A;
        private double B;
        private int days = 7;
        private List<double> deltaDzhMr = new List<double>();
        private List<double> deltaDzhMrSqr = new List<double>();
        private List<double> deltaMMC = new List<double>();
        private List<double> deltaMMCSqr = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void generateTable(int rowCount)
        {
            dataGrid.Rows.Clear();
            dataGrid.Rows.Add(rowCount);
            for (int i = 0; i < rowCount; i++)
                dataGrid.Rows[i].SetValues(new object[] { i + 1, 0 });
        }

        private bool drawed;

        private void Form1_Load(object sender, EventArgs e)
        {
            generateTable(days);
        }

        private void buttonExtractK_Click(object sender, EventArgs e)
        {
            double leftPart = 1.0, rightPart = 0.0, eps, currentK;
            try
            {
                eps = double.Parse(textEps.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            double delta, ti, first = 0, second = 0, third = 0, fourth = 0, plusK = double.Parse(textPlusK.Text);
            days = int.Parse(textDay.Text);

            for (currentK = 0.0; Math.Abs(leftPart - rightPart) > eps && currentK < 1.0; currentK += plusK)
            {
                leftPart = rightPart = first = second = third = fourth = 0.0;
                for(int i = 0, j = days; i < j; i++)
                {
                    delta = int.Parse(dataGrid[1, i].Value.ToString());
                    ti = int.Parse(dataGrid[0, i].Value.ToString());
                    first += FirstEvaluate.evaluate(delta, currentK, ti);
                    second += SecondEvaluate.evaluate(ti, currentK);
                    third += ThirdEvaluate.evaluate(currentK, ti);
                    fourth += FourthEvaluate.evaluate(delta, currentK, ti);
                }
                leftPart = fourth;
                rightPart = first * second / third;
            }
            if (currentK >= 1.0)
            {
                MessageBox.Show("Не могу вычислить K");
                return;
            }
            textK.Text = currentK.ToString("0.########");
            K = currentK;
            first = second = third = 0.0;
            for (int i = 0, j = days; i < j; i++)
            {
                delta = int.Parse(dataGrid[1, i].Value.ToString());
                ti = int.Parse(dataGrid[0, i].Value.ToString());
                first += FourthEvaluate.evaluate(delta, currentK, ti);
                second += SecondEvaluate.evaluate(ti, currentK);
            }
            second *= currentK;
            third = first / second;
            N0 = third;
            textN0.Text = third.ToString("0.########");
            first = second = third = fourth = 0;
            for (int i = 0, j = days; i < j; i++)
            {
                delta = int.Parse(dataGrid[1, i].Value.ToString());
                ti = int.Parse(dataGrid[0, i].Value.ToString());
                first += delta*ti;
                second += ti;
                third += delta;
                fourth += ti*ti;
            }
            A = ((days * first) - (second * third)) /
                ((days * fourth) - (second * second));
            B = (third - (A*second)) / days;
            textBox3.Text = A.ToString();
            textBox4.Text = B.ToString();
            drawed = true;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            days = int.Parse(textDay.Text);
            generateTable(days);
        }

        private void fillDelta(List<double> deltas, List<double> sqrDeltas, int realValue, double funcValue)
        {
            double nevyazkaSqr = (double)realValue - funcValue;
            deltas.Add(nevyazkaSqr);
            nevyazkaSqr = Math.Pow(nevyazkaSqr, 2);
            sqrDeltas.Add(nevyazkaSqr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double functionValueDzhMr, functionValueMMC;
            if(drawed)
            {
                foreach (Series s in chart.Series)
                    s.Points.Clear();
                deltaDzhMr.Clear();
                deltaDzhMrSqr.Clear();
                deltaMMC.Clear();
                deltaMMCSqr.Clear();
                for (int i = 0, j = days; i < j; i++)
                {
                    chart.Series[0].Points.AddXY(i + 1, int.Parse(dataGrid[1, i].Value.ToString()));
                    chart1.Series[0].Points.AddXY(i + 1, int.Parse(dataGrid[1, i].Value.ToString()));
                }
                for(int x = 0; x <= 10; x++)
                {
                    functionValueDzhMr = N0 * K * Math.Pow(Math.E, -K * x);
                    functionValueMMC = A*x+B;
                    chart.Series[1].Points.AddXY(x, functionValueDzhMr);
                    if (x > 0)
                    {
                        if (x <= days)
                        {
                            fillDelta(deltaDzhMr, deltaDzhMrSqr, (int)(dataGrid.Rows.Count > x ? int.Parse(dataGrid[1, x].Value.ToString()) : 0), functionValueDzhMr);
                            chart.Series[2].Points.AddXY(x, deltaDzhMr.Last());
                            chart.Series[3].Points.AddXY(x, deltaDzhMrSqr.Last());
                            fillDelta(deltaMMC, deltaMMCSqr, (int)(dataGrid.Rows.Count > x ? int.Parse(dataGrid[1, x].Value.ToString()) : 0), functionValueMMC);
                            //chart.Series[5].Points.AddXY(x, deltaMMC.Last());
                            //chart.Series[6].Points.AddXY(x, deltaMMCSqr.Last());
                            chart1.Series[2].Points.AddXY(x, deltaMMC.Last());
                            chart1.Series[3].Points.AddXY(x, deltaMMCSqr.Last());
                        }
                        //chart.Series[2].Points.AddXY(x, functionValueMMC);
                        chart1.Series[1].Points.AddXY(x, functionValueMMC);
                    }
                }
                textBox1.Text = deltaDzhMrSqr.Sum().ToString();
                textBox2.Text = deltaMMCSqr.Sum().ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            deltaDzhMr.ForEach((x) => listBox2.Items.Add(x));
            deltaDzhMrSqr.ForEach((x) => listBox1.Items.Add(x));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            deltaMMC.ForEach((x) => listBox2.Items.Add(x));
            deltaMMCSqr.ForEach((x) => listBox1.Items.Add(x));
        }
    }
}
