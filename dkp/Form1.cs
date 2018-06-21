using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace dkp
{
    public partial class DKP : Form
    {
        private DKPs dkp;
        private int maxVal;
        public DKP()
        {
            InitializeComponent();
        }

        private void DKP_Load(object sender, EventArgs e)
        {
            dkp = new DKPs();
            maxVal = 10;
            BreedingGradeBox.Text = "" + dkp.Breedgrade;
            MutateGradeBox.Text = "" + dkp.Mutategrade;
            PopSizeBox.Text = "" + dkp.Popsize;
            NumOfGensBox.Text = "" + dkp.Numofgens;
            LootSizeBox.Text = "" + dkp.Lootsize;
            MaxMassBox.Text = "" + dkp.BagLimit;

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            dkp.Restart();
            chartGraphic.Series.Clear();
            chartGraphic.Series.Add("Median");
            chartGraphic.Series.Add("Maximum");
            chartGraphic.Series["Maximum"].Points.Clear();
            chartGraphic.Series["Median"].Points.Clear();
            var chart = chartGraphic.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 10;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 3000;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 10;


            chartGraphic.Series["Maximum"].ChartType = SeriesChartType.Line;
            chartGraphic.Series["Median"].ChartType = SeriesChartType.Line;
            chartGraphic.Series["Maximum"].Color = Color.Blue;
            chartGraphic.Series["Median"].Color = Color.Orange;
            chartGraphic.Series["Maximum"].IsVisibleInLegend = true;
            chartGraphic.Series["Median"].IsVisibleInLegend = true;
            maxVal = 50;
            while (!dkp.LastGen)
            {
                Tuple<int, float> maxnmed = dkp.NextStep();
                if (maxVal < maxnmed.Item1) maxVal = maxnmed.Item1;
                chartGraphic.Series["Maximum"].Points.AddY(maxnmed.Item1);
                chartGraphic.Series["Median"].Points.AddY((int)maxnmed.Item2);
                ResizeChart();
                chartGraphic.DataBind();
                chartGraphic.Update();
                CurrentGenLabel.Text = "" + dkp.GenCnt;
                CurrentGenLabel.Update();
                BagFillLabel.Text = "" + ((float)dkp.SpaceTaken/(float)dkp.BagLimit);
                BagFillLabel.Update();
                LootValueLabel.Text = "" + maxnmed.Item1;
                LootValueLabel.Update();
            }
            
        }

        private void ResizeChart()
        {
            var chart = chartGraphic.ChartAreas[0];
            chart.AxisX.Maximum = chartGraphic.Series["Maximum"].Points.Count;
            chart.AxisY.Maximum = maxVal + 5;
            chart.AxisX.Interval = Math.Ceiling(chart.AxisX.Maximum / 5);
            chart.AxisY.Interval = chart.AxisY.Maximum / 5;
        }

        private void RouletteCheck_Click(object sender, EventArgs e)
        {
            RouletteCheck.Checked = true;
            JoustCheck.Checked = false;
            RankCheck.Checked = false;
            dkp.Selection = dkp.RankGenerator();
        }

        private void JoustCheck_Click(object sender, EventArgs e)
        {
            RouletteCheck.Checked = false;
            JoustCheck.Checked = true;
            RankCheck.Checked = false;
            dkp.Selection = dkp.JoustGenerator(JousSlider.Value);
        }

        private void RankCheck_Click(object sender, EventArgs e)
        {
            RouletteCheck.Checked = false;
            JoustCheck.Checked = false;
            RankCheck.Checked = true;
            dkp.Selection = dkp.RankGenerator();
        }

        private void SinglePointCheck_Click(object sender, EventArgs e)
        {
            SinglePointCheck.Checked = true;
            DoublePointCheck.Checked = false;
            dkp.Breeder = dkp.BreederGenerator(1);
        }

        private void DoublePointCheck_Click(object sender, EventArgs e)
        {
            SinglePointCheck.Checked = false;
            DoublePointCheck.Checked = true;
            dkp.Breeder = dkp.BreederGenerator(2);
        }

        private void BreedingGradeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dkp.Breedgrade = float.Parse(BreedingGradeBox.Text);
            }
            catch (Exception) { };
        }

        private void MutateGradeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dkp.Mutategrade = float.Parse(MutateGradeBox.Text);
            }
            catch (Exception) { };
        }

        private void PopSizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dkp.Popsize = int.Parse(PopSizeBox.Text);
            }
            catch (Exception) { };
        }

        private void NumOfGensBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dkp.Numofgens = int.Parse(NumOfGensBox.Text);
            }
            catch (Exception) { };
        }

        private void LootSizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dkp.Lootsize = int.Parse(LootSizeBox.Text);
            }
            catch (Exception) { };
            dkp.Fitness = dkp.FitnessGenerator(dkp.BagLimit, dkp.Lootsize);
        }

        private void MaxMassBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dkp.BagLimit = int.Parse(MaxMassBox.Text);
            }
            catch (Exception) { };
            dkp.Fitness = dkp.FitnessGenerator(dkp.BagLimit, dkp.Lootsize);
        }
    }
}
