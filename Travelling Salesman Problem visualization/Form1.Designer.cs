namespace TravellingSalesmanProblemCpppp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddPointButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SolutionButton = new System.Windows.Forms.Button();
            this.ApproximationButton = new System.Windows.Forms.Button();
            this.solutionDisplay = new System.Windows.Forms.Label();
            this.DelayMs = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRandomPoint = new System.Windows.Forms.Button();
            this.numericUpDownRandomMaxX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRandomMinX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownRandomMinY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRandomMaxY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMaxY)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPointButton
            // 
            this.AddPointButton.Enabled = false;
            this.AddPointButton.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPointButton.Location = new System.Drawing.Point(16, 80);
            this.AddPointButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(205, 28);
            this.AddPointButton.TabIndex = 0;
            this.AddPointButton.Text = "add Point";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "x value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "y value:";
            // 
            // Grid
            // 
            chartArea1.Name = "ChartArea1";
            this.Grid.ChartAreas.Add(chartArea1);
            this.Grid.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.Grid.Legends.Add(legend1);
            this.Grid.Location = new System.Drawing.Point(229, 0);
            this.Grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid.Name = "Grid";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.Legend = "Legend1";
            series1.Name = "Points";
            series1.ShadowColor = System.Drawing.Color.Gray;
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Route";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.Name = "Best Route";
            this.Grid.Series.Add(series1);
            this.Grid.Series.Add(series2);
            this.Grid.Series.Add(series3);
            this.Grid.Size = new System.Drawing.Size(1035, 767);
            this.Grid.TabIndex = 6;
            this.Grid.Text = "chart1";
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(16, 508);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(205, 28);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear Points";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SolutionButton
            // 
            this.SolutionButton.Enabled = false;
            this.SolutionButton.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolutionButton.Location = new System.Drawing.Point(16, 576);
            this.SolutionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SolutionButton.Name = "SolutionButton";
            this.SolutionButton.Size = new System.Drawing.Size(205, 62);
            this.SolutionButton.TabIndex = 8;
            this.SolutionButton.Text = "calculate solution O(n!)";
            this.SolutionButton.UseVisualStyleBackColor = true;
            this.SolutionButton.Click += new System.EventHandler(this.SolutionButton_Click);
            // 
            // ApproximationButton
            // 
            this.ApproximationButton.Enabled = false;
            this.ApproximationButton.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproximationButton.Location = new System.Drawing.Point(16, 645);
            this.ApproximationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApproximationButton.Name = "ApproximationButton";
            this.ApproximationButton.Size = new System.Drawing.Size(205, 62);
            this.ApproximationButton.TabIndex = 9;
            this.ApproximationButton.Text = "calculate approximation O(n^2)";
            this.ApproximationButton.UseVisualStyleBackColor = true;
            this.ApproximationButton.Click += new System.EventHandler(this.ApproximationButton_Click);
            // 
            // solutionDisplay
            // 
            this.solutionDisplay.AutoSize = true;
            this.solutionDisplay.Location = new System.Drawing.Point(12, 713);
            this.solutionDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.solutionDisplay.Name = "solutionDisplay";
            this.solutionDisplay.Size = new System.Drawing.Size(172, 17);
            this.solutionDisplay.TabIndex = 10;
            this.solutionDisplay.Text = "The best route\'s length is:";
            // 
            // DelayMs
            // 
            this.DelayMs.Location = new System.Drawing.Point(131, 544);
            this.DelayMs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelayMs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DelayMs.Name = "DelayMs";
            this.DelayMs.Size = new System.Drawing.Size(73, 22);
            this.DelayMs.TabIndex = 11;
            this.DelayMs.ValueChanged += new System.EventHandler(this.DelayMs_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 545);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "delay in ms:";
            // 
            // buttonRandomPoint
            // 
            this.buttonRandomPoint.Enabled = false;
            this.buttonRandomPoint.Font = new System.Drawing.Font("LEMON MILK", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomPoint.Location = new System.Drawing.Point(13, 178);
            this.buttonRandomPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRandomPoint.Name = "buttonRandomPoint";
            this.buttonRandomPoint.Size = new System.Drawing.Size(205, 28);
            this.buttonRandomPoint.TabIndex = 13;
            this.buttonRandomPoint.Text = "random Point";
            this.buttonRandomPoint.UseVisualStyleBackColor = true;
            this.buttonRandomPoint.Click += new System.EventHandler(this.buttonRandomPoint_Click);
            // 
            // numericUpDownRandomMaxX
            // 
            this.numericUpDownRandomMaxX.Location = new System.Drawing.Point(148, 116);
            this.numericUpDownRandomMaxX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownRandomMaxX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRandomMaxX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownRandomMaxX.Name = "numericUpDownRandomMaxX";
            this.numericUpDownRandomMaxX.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownRandomMaxX.TabIndex = 14;
            this.numericUpDownRandomMaxX.ValueChanged += new System.EventHandler(this.numericUpDownRandomMaxX_ValueChanged);
            // 
            // numericUpDownRandomMinX
            // 
            this.numericUpDownRandomMinX.Location = new System.Drawing.Point(37, 116);
            this.numericUpDownRandomMinX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownRandomMinX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRandomMinX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownRandomMinX.Name = "numericUpDownRandomMinX";
            this.numericUpDownRandomMinX.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownRandomMinX.TabIndex = 15;
            this.numericUpDownRandomMinX.ValueChanged += new System.EventHandler(this.numericUpDownRandomMinX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(3, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(112, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(112, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(3, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "min";
            // 
            // numericUpDownRandomMinY
            // 
            this.numericUpDownRandomMinY.Location = new System.Drawing.Point(37, 148);
            this.numericUpDownRandomMinY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownRandomMinY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRandomMinY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownRandomMinY.Name = "numericUpDownRandomMinY";
            this.numericUpDownRandomMinY.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownRandomMinY.TabIndex = 19;
            this.numericUpDownRandomMinY.ValueChanged += new System.EventHandler(this.numericUpDownRandomMinY_ValueChanged);
            // 
            // numericUpDownRandomMaxY
            // 
            this.numericUpDownRandomMaxY.Location = new System.Drawing.Point(148, 148);
            this.numericUpDownRandomMaxY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownRandomMaxY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRandomMaxY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownRandomMaxY.Name = "numericUpDownRandomMaxY";
            this.numericUpDownRandomMaxY.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownRandomMaxY.TabIndex = 18;
            this.numericUpDownRandomMaxY.ValueChanged += new System.EventHandler(this.numericUpDownRandomMaxY_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 767);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownRandomMinY);
            this.Controls.Add(this.numericUpDownRandomMaxY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownRandomMinX);
            this.Controls.Add(this.numericUpDownRandomMaxX);
            this.Controls.Add(this.buttonRandomPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelayMs);
            this.Controls.Add(this.solutionDisplay);
            this.Controls.Add(this.ApproximationButton);
            this.Controls.Add(this.SolutionButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddPointButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Travelling Salesman Problem sim (by guruguru19)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayMs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRandomMaxY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grid;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SolutionButton;
        private System.Windows.Forms.Button ApproximationButton;

        public System.Windows.Forms.DataVisualization.Charting.Chart GetGrid()
        {
            return this.Grid;
        }

        private System.Windows.Forms.Label solutionDisplay;
        private System.Windows.Forms.NumericUpDown DelayMs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRandomPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomMaxX;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomMinX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomMinY;
        private System.Windows.Forms.NumericUpDown numericUpDownRandomMaxY;
    }
}

