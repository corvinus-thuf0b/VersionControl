﻿
namespace Webszolgaltatas_IRF_07
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
            this.dgwRates = new System.Windows.Forms.DataGridView();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRates
            // 
            this.dgwRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRates.Location = new System.Drawing.Point(47, 66);
            this.dgwRates.Name = "dgwRates";
            this.dgwRates.Size = new System.Drawing.Size(327, 345);
            this.dgwRates.TabIndex = 0;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(47, 443);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(688, 122);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // chartRateData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRateData.Legends.Add(legend1);
            this.chartRateData.Location = new System.Drawing.Point(408, 66);
            this.chartRateData.Name = "chartRateData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRateData.Series.Add(series1);
            this.chartRateData.Size = new System.Drawing.Size(327, 345);
            this.chartRateData.TabIndex = 2;
            this.chartRateData.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.dgwRates);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRates;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
    }
}

