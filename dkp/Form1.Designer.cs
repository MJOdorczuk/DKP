namespace dkp
{
    partial class DKP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
            this.RouletteCheck = new System.Windows.Forms.CheckBox();
            this.JoustCheck = new System.Windows.Forms.CheckBox();
            this.RankCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupSize = new System.Windows.Forms.Label();
            this.JousSlider = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DoublePointCheck = new System.Windows.Forms.CheckBox();
            this.SinglePointCheck = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MutateGradeBox = new System.Windows.Forms.TextBox();
            this.BreedingGradeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CurrentGenLabel = new System.Windows.Forms.Label();
            this.NumOfGensBox = new System.Windows.Forms.TextBox();
            this.PopSizeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LootValueLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BagFillLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxMassBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LootSizeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JousSlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartGraphic
            // 
            chartArea8.Name = "ChartArea1";
            this.chartGraphic.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartGraphic.Legends.Add(legend8);
            this.chartGraphic.Location = new System.Drawing.Point(12, 211);
            this.chartGraphic.Name = "chartGraphic";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartGraphic.Series.Add(series8);
            this.chartGraphic.Size = new System.Drawing.Size(887, 300);
            this.chartGraphic.TabIndex = 0;
            this.chartGraphic.Text = "chart1";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(905, 488);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RouletteCheck
            // 
            this.RouletteCheck.AutoSize = true;
            this.RouletteCheck.Checked = true;
            this.RouletteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RouletteCheck.Location = new System.Drawing.Point(6, 19);
            this.RouletteCheck.Name = "RouletteCheck";
            this.RouletteCheck.Size = new System.Drawing.Size(72, 17);
            this.RouletteCheck.TabIndex = 2;
            this.RouletteCheck.Text = "ruletkowa";
            this.RouletteCheck.UseVisualStyleBackColor = true;
            this.RouletteCheck.Click += new System.EventHandler(this.RouletteCheck_Click);
            // 
            // JoustCheck
            // 
            this.JoustCheck.AutoSize = true;
            this.JoustCheck.Location = new System.Drawing.Point(6, 42);
            this.JoustCheck.Name = "JoustCheck";
            this.JoustCheck.Size = new System.Drawing.Size(74, 17);
            this.JoustCheck.TabIndex = 3;
            this.JoustCheck.Text = "turniejowa";
            this.JoustCheck.UseVisualStyleBackColor = true;
            this.JoustCheck.Click += new System.EventHandler(this.JoustCheck_Click);
            // 
            // RankCheck
            // 
            this.RankCheck.AutoSize = true;
            this.RankCheck.Location = new System.Drawing.Point(4, 65);
            this.RankCheck.Name = "RankCheck";
            this.RankCheck.Size = new System.Drawing.Size(81, 17);
            this.RankCheck.TabIndex = 4;
            this.RankCheck.Text = "rankingowa";
            this.RankCheck.UseVisualStyleBackColor = true;
            this.RankCheck.Click += new System.EventHandler(this.RankCheck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RankCheck);
            this.groupBox1.Controls.Add(this.RouletteCheck);
            this.groupBox1.Controls.Add(this.JoustCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rodzaj selekcji";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GroupSize);
            this.groupBox2.Controls.Add(this.JousSlider);
            this.groupBox2.Location = new System.Drawing.Point(6, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 61);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rozmiar grupy turniejowej";
            // 
            // GroupSize
            // 
            this.GroupSize.AutoSize = true;
            this.GroupSize.Location = new System.Drawing.Point(116, 22);
            this.GroupSize.Name = "GroupSize";
            this.GroupSize.Size = new System.Drawing.Size(13, 13);
            this.GroupSize.TabIndex = 6;
            this.GroupSize.Text = "2";
            // 
            // JousSlider
            // 
            this.JousSlider.Location = new System.Drawing.Point(6, 22);
            this.JousSlider.Minimum = 2;
            this.JousSlider.Name = "JousSlider";
            this.JousSlider.Size = new System.Drawing.Size(104, 45);
            this.JousSlider.TabIndex = 6;
            this.JousSlider.Value = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DoublePointCheck);
            this.groupBox3.Controls.Add(this.SinglePointCheck);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rodzaj krzyżowania";
            // 
            // DoublePointCheck
            // 
            this.DoublePointCheck.AutoSize = true;
            this.DoublePointCheck.Location = new System.Drawing.Point(6, 42);
            this.DoublePointCheck.Name = "DoublePointCheck";
            this.DoublePointCheck.Size = new System.Drawing.Size(93, 17);
            this.DoublePointCheck.TabIndex = 9;
            this.DoublePointCheck.Text = "dwupunktowe";
            this.DoublePointCheck.UseVisualStyleBackColor = true;
            this.DoublePointCheck.Click += new System.EventHandler(this.DoublePointCheck_Click);
            // 
            // SinglePointCheck
            // 
            this.SinglePointCheck.AutoSize = true;
            this.SinglePointCheck.Checked = true;
            this.SinglePointCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SinglePointCheck.Location = new System.Drawing.Point(6, 19);
            this.SinglePointCheck.Name = "SinglePointCheck";
            this.SinglePointCheck.Size = new System.Drawing.Size(99, 17);
            this.SinglePointCheck.TabIndex = 8;
            this.SinglePointCheck.Text = "jednopunktowe";
            this.SinglePointCheck.UseVisualStyleBackColor = true;
            this.SinglePointCheck.Click += new System.EventHandler(this.SinglePointCheck_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MutateGradeBox);
            this.groupBox4.Controls.Add(this.BreedingGradeBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(424, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 82);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prawdopodobieństwa";
            // 
            // MutateGradeBox
            // 
            this.MutateGradeBox.Location = new System.Drawing.Point(94, 42);
            this.MutateGradeBox.Name = "MutateGradeBox";
            this.MutateGradeBox.Size = new System.Drawing.Size(100, 20);
            this.MutateGradeBox.TabIndex = 9;
            this.MutateGradeBox.TextChanged += new System.EventHandler(this.MutateGradeBox_TextChanged);
            // 
            // BreedingGradeBox
            // 
            this.BreedingGradeBox.Location = new System.Drawing.Point(94, 16);
            this.BreedingGradeBox.Name = "BreedingGradeBox";
            this.BreedingGradeBox.Size = new System.Drawing.Size(100, 20);
            this.BreedingGradeBox.TabIndex = 8;
            this.BreedingGradeBox.TextChanged += new System.EventHandler(this.BreedingGradeBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mutacja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Krzyżowanie:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CurrentGenLabel);
            this.groupBox5.Controls.Add(this.NumOfGensBox);
            this.groupBox5.Controls.Add(this.PopSizeBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(724, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(256, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ewolucja";
            // 
            // CurrentGenLabel
            // 
            this.CurrentGenLabel.AutoSize = true;
            this.CurrentGenLabel.Location = new System.Drawing.Point(147, 69);
            this.CurrentGenLabel.Name = "CurrentGenLabel";
            this.CurrentGenLabel.Size = new System.Drawing.Size(13, 13);
            this.CurrentGenLabel.TabIndex = 14;
            this.CurrentGenLabel.Text = "0";
            // 
            // NumOfGensBox
            // 
            this.NumOfGensBox.Location = new System.Drawing.Point(150, 46);
            this.NumOfGensBox.Name = "NumOfGensBox";
            this.NumOfGensBox.Size = new System.Drawing.Size(100, 20);
            this.NumOfGensBox.TabIndex = 13;
            this.NumOfGensBox.TextChanged += new System.EventHandler(this.NumOfGensBox_TextChanged);
            // 
            // PopSizeBox
            // 
            this.PopSizeBox.Location = new System.Drawing.Point(150, 16);
            this.PopSizeBox.Name = "PopSizeBox";
            this.PopSizeBox.Size = new System.Drawing.Size(100, 20);
            this.PopSizeBox.TabIndex = 10;
            this.PopSizeBox.TextChanged += new System.EventHandler(this.PopSizeBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aktualna generacja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liczba generacji:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rozmiar populacji:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.LootValueLabel);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.BagFillLabel);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.MaxMassBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.LootSizeBox);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(224, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(494, 100);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dyskretny problem plecakowy";
            // 
            // LootValueLabel
            // 
            this.LootValueLabel.AutoSize = true;
            this.LootValueLabel.Location = new System.Drawing.Point(338, 53);
            this.LootValueLabel.Name = "LootValueLabel";
            this.LootValueLabel.Size = new System.Drawing.Size(13, 13);
            this.LootValueLabel.TabIndex = 16;
            this.LootValueLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Wartość przedmiotów:";
            // 
            // BagFillLabel
            // 
            this.BagFillLabel.AutoSize = true;
            this.BagFillLabel.Location = new System.Drawing.Point(338, 24);
            this.BagFillLabel.Name = "BagFillLabel";
            this.BagFillLabel.Size = new System.Drawing.Size(13, 13);
            this.BagFillLabel.TabIndex = 14;
            this.BagFillLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Wypełnienie plecaka:";
            // 
            // MaxMassBox
            // 
            this.MaxMassBox.Location = new System.Drawing.Point(115, 50);
            this.MaxMassBox.Name = "MaxMassBox";
            this.MaxMassBox.Size = new System.Drawing.Size(100, 20);
            this.MaxMassBox.TabIndex = 12;
            this.MaxMassBox.TextChanged += new System.EventHandler(this.MaxMassBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Max rozmiar plecaka:";
            // 
            // LootSizeBox
            // 
            this.LootSizeBox.Location = new System.Drawing.Point(115, 24);
            this.LootSizeBox.Name = "LootSizeBox";
            this.LootSizeBox.Size = new System.Drawing.Size(100, 20);
            this.LootSizeBox.TabIndex = 10;
            this.LootSizeBox.TextChanged += new System.EventHandler(this.LootSizeBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Liczba przedmiotów:";
            // 
            // DKP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.chartGraphic);
            this.Name = "DKP";
            this.Text = "DKP";
            this.Load += new System.EventHandler(this.DKP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JousSlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.CheckBox RouletteCheck;
        private System.Windows.Forms.CheckBox JoustCheck;
        private System.Windows.Forms.CheckBox RankCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label GroupSize;
        private System.Windows.Forms.TrackBar JousSlider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox DoublePointCheck;
        private System.Windows.Forms.CheckBox SinglePointCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox MutateGradeBox;
        private System.Windows.Forms.TextBox BreedingGradeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label CurrentGenLabel;
        private System.Windows.Forms.TextBox NumOfGensBox;
        private System.Windows.Forms.TextBox PopSizeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label LootValueLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label BagFillLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaxMassBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LootSizeBox;
        private System.Windows.Forms.Label label6;
    }
}

