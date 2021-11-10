
namespace FejlesztesiMintak_IRF_08
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnBall = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnRibbonColor = new System.Windows.Forms.Button();
            this.btnBoxColor = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnBoxColor);
            this.mainPanel.Controls.Add(this.btnRibbonColor);
            this.mainPanel.Controls.Add(this.btnPresent);
            this.mainPanel.Controls.Add(this.btnBallColor);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnBall);
            this.mainPanel.Controls.Add(this.btnCar);
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 438);
            this.mainPanel.TabIndex = 0;
            // 
            // btnBallColor
            // 
            this.btnBallColor.BackColor = System.Drawing.Color.Green;
            this.btnBallColor.Location = new System.Drawing.Point(133, 236);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(75, 23);
            this.btnBallColor.TabIndex = 3;
            this.btnBallColor.UseVisualStyleBackColor = false;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(337, 146);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(68, 13);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(133, 158);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(76, 71);
            this.btnBall.TabIndex = 1;
            this.btnBall.Text = "Ball";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(51, 158);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(76, 71);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(215, 158);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(76, 71);
            this.btnPresent.TabIndex = 4;
            this.btnPresent.Text = "Present";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnRibbonColor
            // 
            this.btnRibbonColor.BackColor = System.Drawing.Color.Blue;
            this.btnRibbonColor.Location = new System.Drawing.Point(216, 264);
            this.btnRibbonColor.Name = "btnRibbonColor";
            this.btnRibbonColor.Size = new System.Drawing.Size(75, 23);
            this.btnRibbonColor.TabIndex = 5;
            this.btnRibbonColor.UseVisualStyleBackColor = false;
            this.btnRibbonColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // btnBoxColor
            // 
            this.btnBoxColor.BackColor = System.Drawing.Color.Red;
            this.btnBoxColor.Location = new System.Drawing.Point(216, 235);
            this.btnBoxColor.Name = "btnBoxColor";
            this.btnBoxColor.Size = new System.Drawing.Size(75, 23);
            this.btnBoxColor.TabIndex = 6;
            this.btnBoxColor.UseVisualStyleBackColor = false;
            this.btnBoxColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.Button btnBoxColor;
        private System.Windows.Forms.Button btnRibbonColor;
        private System.Windows.Forms.Button btnPresent;
    }
}

