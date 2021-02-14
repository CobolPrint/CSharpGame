
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWeapons = new System.Windows.Forms.ComboBox();
            this.comboBoxPotions = new System.Windows.Forms.ComboBox();
            this.buttonUseWeapon = new System.Windows.Forms.Button();
            this.buttonUsePotion = new System.Windows.Forms.Button();
            this.buttonNorth = new System.Windows.Forms.Button();
            this.buttonEast = new System.Windows.Forms.Button();
            this.buttonSouth = new System.Windows.Forms.Button();
            this.buttonWest = new System.Windows.Forms.Button();
            this.richTextBoxLocation = new System.Windows.Forms.RichTextBox();
            this.richMessages = new System.Windows.Forms.RichTextBox();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1109, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Action";
            // 
            // comboBoxWeapons
            // 
            this.comboBoxWeapons.FormattingEnabled = true;
            this.comboBoxWeapons.Location = new System.Drawing.Point(859, 526);
            this.comboBoxWeapons.Name = "comboBoxWeapons";
            this.comboBoxWeapons.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWeapons.TabIndex = 10;
            // 
            // comboBoxPotions
            // 
            this.comboBoxPotions.FormattingEnabled = true;
            this.comboBoxPotions.Location = new System.Drawing.Point(859, 564);
            this.comboBoxPotions.Name = "comboBoxPotions";
            this.comboBoxPotions.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPotions.TabIndex = 11;
            // 
            // buttonUseWeapon
            // 
            this.buttonUseWeapon.Location = new System.Drawing.Point(996, 525);
            this.buttonUseWeapon.Name = "buttonUseWeapon";
            this.buttonUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.buttonUseWeapon.TabIndex = 12;
            this.buttonUseWeapon.Text = "Use";
            this.buttonUseWeapon.UseVisualStyleBackColor = true;
            // 
            // buttonUsePotion
            // 
            this.buttonUsePotion.Location = new System.Drawing.Point(996, 563);
            this.buttonUsePotion.Name = "buttonUsePotion";
            this.buttonUsePotion.Size = new System.Drawing.Size(75, 23);
            this.buttonUsePotion.TabIndex = 13;
            this.buttonUsePotion.Text = "Use";
            this.buttonUsePotion.UseVisualStyleBackColor = true;
            // 
            // buttonNorth
            // 
            this.buttonNorth.Location = new System.Drawing.Point(1036, 375);
            this.buttonNorth.Name = "buttonNorth";
            this.buttonNorth.Size = new System.Drawing.Size(75, 23);
            this.buttonNorth.TabIndex = 14;
            this.buttonNorth.Text = "North";
            this.buttonNorth.UseVisualStyleBackColor = true;
            // 
            // buttonEast
            // 
            this.buttonEast.Location = new System.Drawing.Point(944, 408);
            this.buttonEast.Name = "buttonEast";
            this.buttonEast.Size = new System.Drawing.Size(75, 23);
            this.buttonEast.TabIndex = 15;
            this.buttonEast.Text = "East";
            this.buttonEast.UseVisualStyleBackColor = true;
            // 
            // buttonSouth
            // 
            this.buttonSouth.Location = new System.Drawing.Point(1036, 443);
            this.buttonSouth.Name = "buttonSouth";
            this.buttonSouth.Size = new System.Drawing.Size(75, 23);
            this.buttonSouth.TabIndex = 16;
            this.buttonSouth.Text = "South";
            this.buttonSouth.UseVisualStyleBackColor = true;
            // 
            // buttonWest
            // 
            this.buttonWest.Location = new System.Drawing.Point(1122, 408);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(75, 23);
            this.buttonWest.TabIndex = 17;
            this.buttonWest.Text = "West";
            this.buttonWest.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLocation
            // 
            this.richTextBoxLocation.Location = new System.Drawing.Point(206, 24);
            this.richTextBoxLocation.Name = "richTextBoxLocation";
            this.richTextBoxLocation.ReadOnly = true;
            this.richTextBoxLocation.Size = new System.Drawing.Size(705, 83);
            this.richTextBoxLocation.TabIndex = 18;
            this.richTextBoxLocation.Text = "";
            // 
            // richMessages
            // 
            this.richMessages.Location = new System.Drawing.Point(256, 219);
            this.richMessages.Name = "richMessages";
            this.richMessages.ReadOnly = true;
            this.richMessages.Size = new System.Drawing.Size(498, 235);
            this.richMessages.TabIndex = 19;
            this.richMessages.Text = "";
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewInventory.Location = new System.Drawing.Point(13, 219);
            this.dataGridViewInventory.MultiSelect = false;
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowTemplate.Height = 25;
            this.dataGridViewInventory.Size = new System.Drawing.Size(240, 235);
            this.dataGridViewInventory.TabIndex = 20;
            // 
            // dataGridViewQuests
            // 
            this.dataGridViewQuests.AllowUserToAddRows = false;
            this.dataGridViewQuests.AllowUserToDeleteRows = false;
            this.dataGridViewQuests.AllowUserToResizeRows = false;
            this.dataGridViewQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewQuests.Location = new System.Drawing.Point(13, 460);
            this.dataGridViewQuests.MultiSelect = false;
            this.dataGridViewQuests.Name = "dataGridViewQuests";
            this.dataGridViewQuests.ReadOnly = true;
            this.dataGridViewQuests.RowTemplate.Height = 25;
            this.dataGridViewQuests.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewQuests.TabIndex = 21;
            // 
            // AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 610);
            this.Controls.Add(this.dataGridViewQuests);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.richMessages);
            this.Controls.Add(this.richTextBoxLocation);
            this.Controls.Add(this.buttonWest);
            this.Controls.Add(this.buttonSouth);
            this.Controls.Add(this.buttonEast);
            this.Controls.Add(this.buttonNorth);
            this.Controls.Add(this.buttonUsePotion);
            this.Controls.Add(this.buttonUseWeapon);
            this.Controls.Add(this.comboBoxPotions);
            this.Controls.Add(this.comboBoxWeapons);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWeapons;
        private System.Windows.Forms.ComboBox comboBoxPotions;
        private System.Windows.Forms.Button buttonUseWeapon;
        private System.Windows.Forms.Button buttonUsePotion;
        private System.Windows.Forms.Button buttonNorth;
        private System.Windows.Forms.Button buttonEast;
        private System.Windows.Forms.Button buttonSouth;
        private System.Windows.Forms.Button buttonWest;
        private System.Windows.Forms.RichTextBox richTextBoxLocation;
        private System.Windows.Forms.RichTextBox richMessages;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.DataGridView dataGridViewQuests;
    }
}

