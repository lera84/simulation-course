namespace FlightSimulation2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.height = new System.Windows.Forms.Label();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.inputAngle = new System.Windows.Forms.NumericUpDown();
            this.angle = new System.Windows.Forms.Label();
            this.inputSpeed = new System.Windows.Forms.NumericUpDown();
            this.speed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.weight = new System.Windows.Forms.Label();
            this.inputSize = new System.Windows.Forms.NumericUpDown();
            this.size = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputDt = new System.Windows.Forms.NumericUpDown();
            this.step = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(41, 154);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(566, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(41, 26);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(55, 16);
            this.height.TabIndex = 1;
            this.height.Text = "Высота";
            this.height.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(126, 26);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(120, 22);
            this.inputHeight.TabIndex = 2;
            // 
            // inputAngle
            // 
            this.inputAngle.Location = new System.Drawing.Point(126, 54);
            this.inputAngle.Name = "inputAngle";
            this.inputAngle.Size = new System.Drawing.Size(120, 22);
            this.inputAngle.TabIndex = 4;
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(41, 54);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(38, 16);
            this.angle.TabIndex = 3;
            this.angle.Text = "Угол";
            // 
            // inputSpeed
            // 
            this.inputSpeed.Location = new System.Drawing.Point(126, 82);
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.Size = new System.Drawing.Size(120, 22);
            this.inputSpeed.TabIndex = 6;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(38, 82);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(68, 16);
            this.speed.TabIndex = 5;
            this.speed.Text = "Скорость";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(381, 54);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(120, 22);
            this.inputWeight.TabIndex = 11;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(296, 56);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(31, 16);
            this.weight.TabIndex = 10;
            this.weight.Text = "Вес";
            // 
            // inputSize
            // 
            this.inputSize.Location = new System.Drawing.Point(381, 26);
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(120, 22);
            this.inputSize.TabIndex = 9;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(296, 26);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(57, 16);
            this.size.TabIndex = 8;
            this.size.Text = "Размер";
            this.size.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputDt
            // 
            this.inputDt.Location = new System.Drawing.Point(381, 82);
            this.inputDt.Name = "inputDt";
            this.inputDt.Size = new System.Drawing.Size(120, 22);
            this.inputDt.TabIndex = 13;
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(296, 84);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(18, 16);
            this.step.TabIndex = 12;
            this.step.Text = "dt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(657, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 300);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inputDt);
            this.Controls.Add(this.step);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.inputSize);
            this.Controls.Add(this.size);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.inputAngle);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.NumericUpDown inputAngle;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.NumericUpDown inputSpeed;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown inputWeight;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.NumericUpDown inputSize;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown inputDt;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

