
namespace CSharpGame
{
    partial class AdventureGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHitPoints = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelXP = new System.Windows.Forms.Label();
            this.labelLVL = new System.Windows.Forms.Label();
            this.labelExperiance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // labelHitPoints
            // 
            this.labelHitPoints.AutoSize = true;
            this.labelHitPoints.Location = new System.Drawing.Point(82, 13);
            this.labelHitPoints.Name = "labelHitPoints";
            this.labelHitPoints.Size = new System.Drawing.Size(0, 15);
            this.labelHitPoints.TabIndex = 4;
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(82, 43);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(0, 15);
            this.labelGold.TabIndex = 5;
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.Location = new System.Drawing.Point(82, 74);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(0, 15);
            this.labelXP.TabIndex = 6;
            // 
            // labelLVL
            // 
            this.labelLVL.AutoSize = true;
            this.labelLVL.Location = new System.Drawing.Point(82, 103);
            this.labelLVL.Name = "labelLVL";
            this.labelLVL.Size = new System.Drawing.Size(0, 15);
            this.labelLVL.TabIndex = 7;
            // 
            // labelExperiance
            // 
            this.labelExperiance.AutoSize = true;
            this.labelExperiance.Location = new System.Drawing.Point(13, 74);
            this.labelExperiance.Name = "labelExperiance";
            this.labelExperiance.Size = new System.Drawing.Size(67, 15);
            this.labelExperiance.TabIndex = 8;
            this.labelExperiance.Text = "Experiance:";
            // 
            // AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 610);
            this.Controls.Add(this.labelExperiance);
            this.Controls.Add(this.labelLVL);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.labelHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdventureGame";
            this.Text = "Adventure Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHitPoints;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.Label labelLVL;
        private System.Windows.Forms.Label labelExperiance;
    }
}

