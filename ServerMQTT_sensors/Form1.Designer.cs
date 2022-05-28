namespace ServerMQTT_sensors
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.lbICPU = new MetroFramework.Controls.MetroLabel();
            this.lbIRAM = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TempCPU = new System.Diagnostics.PerformanceCounter();
            this.FreqCPU = new System.Diagnostics.PerformanceCounter();
            this.lblFREQ = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarFREQ = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.FreqCPU_value = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqCPU_value)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Pamięć";
            this.pRAM.CounterName = "Zadeklarowane bajty w użyciu (%)";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Procesor";
            this.pCPU.CounterName = "Czas procesora (%)";
            this.pCPU.InstanceName = "_Total";
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(30, 99);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(35, 19);
            this.metroLabel.TabIndex = 0;
            this.metroLabel.Text = "CPU";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(82, 99);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(455, 23);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // lbICPU
            // 
            this.lbICPU.AutoSize = true;
            this.lbICPU.Location = new System.Drawing.Point(543, 102);
            this.lbICPU.Name = "lbICPU";
            this.lbICPU.Size = new System.Drawing.Size(27, 19);
            this.lbICPU.TabIndex = 2;
            this.lbICPU.Text = "0%";
            // 
            // lbIRAM
            // 
            this.lbIRAM.AutoSize = true;
            this.lbIRAM.Location = new System.Drawing.Point(543, 130);
            this.lbIRAM.Name = "lbIRAM";
            this.lbIRAM.Size = new System.Drawing.Size(27, 19);
            this.lbIRAM.TabIndex = 5;
            this.lbIRAM.Text = "0%";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(82, 128);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(455, 23);
            this.metroProgressBarRAM.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "RAM";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(82, 243);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "CPU";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "RAM";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "FREQ";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(455, 417);
            this.chart1.TabIndex = 6;
            // 
            // TempCPU
            // 
            this.TempCPU.CategoryName = "Informacje o strefach termicznych";
            this.TempCPU.CounterName = "Temperatura";
            this.TempCPU.InstanceName = "\\_TZ.TZ00";
            // 
            // FreqCPU
            // 
            this.FreqCPU.CategoryName = "Informacje o procesorze";
            this.FreqCPU.CounterName = "% maksymalnej częstotliwości";
            this.FreqCPU.InstanceName = "0,_Total";
            // 
            // lblFREQ
            // 
            this.lblFREQ.AutoSize = true;
            this.lblFREQ.Location = new System.Drawing.Point(543, 159);
            this.lblFREQ.Name = "lblFREQ";
            this.lblFREQ.Size = new System.Drawing.Size(27, 19);
            this.lblFREQ.TabIndex = 9;
            this.lblFREQ.Text = "0%";
            // 
            // metroProgressBarFREQ
            // 
            this.metroProgressBarFREQ.Location = new System.Drawing.Point(82, 157);
            this.metroProgressBarFREQ.Name = "metroProgressBarFREQ";
            this.metroProgressBarFREQ.Size = new System.Drawing.Size(455, 23);
            this.metroProgressBarFREQ.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "FREQ";
            // 
            // FreqCPU_value
            // 
            this.FreqCPU_value.CategoryName = "Informacje o procesorze";
            this.FreqCPU_value.CounterName = "Częstotliwość procesora";
            this.FreqCPU_value.InstanceName = "_Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 738);
            this.Controls.Add(this.lblFREQ);
            this.Controls.Add(this.metroProgressBarFREQ);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbIRAM);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbICPU);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.metroLabel);
            this.Name = "Form1";
            this.Text = "CPU & RAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqCPU_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel lbICPU;
        private MetroFramework.Controls.MetroLabel lbIRAM;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Diagnostics.PerformanceCounter TempCPU;
        private System.Diagnostics.PerformanceCounter FreqCPU;
        private MetroFramework.Controls.MetroLabel lblFREQ;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarFREQ;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Diagnostics.PerformanceCounter FreqCPU_value;
    }
}

