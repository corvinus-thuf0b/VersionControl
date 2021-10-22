
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
            this.dgvPortfolio = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolio)).BeginInit();
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
            // dgvPortfolio
            // 
            this.dgvPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortfolio.Location = new System.Drawing.Point(424, 83);
            this.dgvPortfolio.Name = "dgvPortfolio";
            this.dgvPortfolio.Size = new System.Drawing.Size(331, 242);
            this.dgvPortfolio.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPortfolio);
            this.Controls.Add(this.dgvTicks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTicks;
        private System.Windows.Forms.DataGridView dgvPortfolio;
        private System.Windows.Forms.Button btnSave;
    }
}

