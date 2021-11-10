
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
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
            this.lblHeroStats.Click += new System.EventHandler(this.lblHeroStats_Click);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(197, 212);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

