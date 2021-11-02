
namespace Hein_Kroese_GADE6112_POE
{
    partial class frmGame
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
            this.lblMap = new System.Windows.Forms.Label();
            this.lblHeroStats = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(14, 10);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(177, 170);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "XXXXXXXXXXXXXX\r\nX......G.....X\r\nX......G.....X\r\nX............X\r\nX....G.G.....X\r\nX" +
    ".....GH.....X\r\nX............X\r\nXXXXXXXXXXXXXX ";
            this.lblMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeroStats
            // 
            this.lblHeroStats.AutoSize = true;
            this.lblHeroStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeroStats.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroStats.Location = new System.Drawing.Point(197, 10);
            this.lblHeroStats.Name = "lblHeroStats";
            this.lblHeroStats.Size = new System.Drawing.Size(140, 20);
            this.lblHeroStats.TabIndex = 1;
            this.lblHeroStats.Text = "{Placeholder}";
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemy.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemy.Location = new System.Drawing.Point(197, 160);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(140, 20);
            this.lblEnemy.TabIndex = 2;
            this.lblEnemy.Text = "{Placeholder}";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblHeroStats);
            this.Controls.Add(this.lblMap);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblHeroStats;
        private System.Windows.Forms.Label lblEnemy;
    }
}

