
namespace VaR_IRF_05
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
            this.dgvTicks = new System.Windows.Forms.DataGridView();
            this.dgrPortfolio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPortfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTicks
            // 
            this.dgvTicks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicks.Location = new System.Drawing.Point(39, 83);
            this.dgvTicks.Name = "dgvTicks";
            this.dgvTicks.Size = new System.Drawing.Size(331, 242);
            this.dgvTicks.TabIndex = 0;
            // 
            // dgrPortfolio
            // 
            this.dgrPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPortfolio.Location = new System.Drawing.Point(424, 83);
            this.dgrPortfolio.Name = "dgrPortfolio";
            this.dgrPortfolio.Size = new System.Drawing.Size(331, 242);
            this.dgrPortfolio.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrPortfolio);
            this.Controls.Add(this.dgvTicks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPortfolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicks;
        private System.Windows.Forms.DataGridView dgrPortfolio;
    }
}

