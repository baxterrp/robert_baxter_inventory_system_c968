namespace robert_baxter_inventory_system
{
    partial class AddPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.InHouseRadioOption = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadioOption = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UniquePartDescripter = new System.Windows.Forms.Label();
            this.PartSaveButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PartId = new System.Windows.Forms.TextBox();
            this.PartName = new System.Windows.Forms.TextBox();
            this.PartInventoryCount = new System.Windows.Forms.TextBox();
            this.PartPrice = new System.Windows.Forms.TextBox();
            this.PartMax = new System.Windows.Forms.TextBox();
            this.PartMin = new System.Windows.Forms.TextBox();
            this.UniquePartValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // InHouseRadioOption
            // 
            this.InHouseRadioOption.AutoSize = true;
            this.InHouseRadioOption.Checked = true;
            this.InHouseRadioOption.Location = new System.Drawing.Point(105, 31);
            this.InHouseRadioOption.Name = "InHouseRadioOption";
            this.InHouseRadioOption.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadioOption.TabIndex = 1;
            this.InHouseRadioOption.TabStop = true;
            this.InHouseRadioOption.Text = "In-House";
            this.InHouseRadioOption.UseVisualStyleBackColor = true;
            this.InHouseRadioOption.CheckedChanged += new System.EventHandler(this.InHouseRadioOptionCheckedChanged);
            // 
            // OutsourcedRadioOption
            // 
            this.OutsourcedRadioOption.AutoSize = true;
            this.OutsourcedRadioOption.Location = new System.Drawing.Point(191, 31);
            this.OutsourcedRadioOption.Name = "OutsourcedRadioOption";
            this.OutsourcedRadioOption.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadioOption.TabIndex = 2;
            this.OutsourcedRadioOption.Text = "Outsourced";
            this.OutsourcedRadioOption.UseVisualStyleBackColor = true;
            this.OutsourcedRadioOption.CheckedChanged += new System.EventHandler(this.OutsourcedRadioOptionCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min";
            // 
            // UniquePartDescripter
            // 
            this.UniquePartDescripter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniquePartDescripter.AutoSize = true;
            this.UniquePartDescripter.Location = new System.Drawing.Point(49, 268);
            this.UniquePartDescripter.Name = "UniquePartDescripter";
            this.UniquePartDescripter.Size = new System.Drawing.Size(62, 13);
            this.UniquePartDescripter.TabIndex = 9;
            this.UniquePartDescripter.Text = "Machine ID";
            // 
            // PartSaveButton
            // 
            this.PartSaveButton.Location = new System.Drawing.Point(105, 303);
            this.PartSaveButton.Name = "PartSaveButton";
            this.PartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.PartSaveButton.TabIndex = 10;
            this.PartSaveButton.Text = "Save";
            this.PartSaveButton.UseVisualStyleBackColor = true;
            this.PartSaveButton.Click += new System.EventHandler(this.SavePartClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddPartExitClick);
            // 
            // PartId
            // 
            this.PartId.Location = new System.Drawing.Point(134, 68);
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            this.PartId.Size = new System.Drawing.Size(137, 20);
            this.PartId.TabIndex = 12;
            // 
            // PartName
            // 
            this.PartName.BackColor = System.Drawing.Color.Salmon;
            this.PartName.Location = new System.Drawing.Point(134, 107);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(137, 20);
            this.PartName.TabIndex = 13;
            this.PartName.TextChanged += new System.EventHandler(this.PartName_TextChanged);
            // 
            // PartInventoryCount
            // 
            this.PartInventoryCount.BackColor = System.Drawing.Color.Salmon;
            this.PartInventoryCount.Location = new System.Drawing.Point(134, 146);
            this.PartInventoryCount.Name = "PartInventoryCount";
            this.PartInventoryCount.Size = new System.Drawing.Size(137, 20);
            this.PartInventoryCount.TabIndex = 14;
            this.PartInventoryCount.TextChanged += new System.EventHandler(this.PartInventoryCount_TextChanged);
            // 
            // PartPrice
            // 
            this.PartPrice.BackColor = System.Drawing.Color.Salmon;
            this.PartPrice.Location = new System.Drawing.Point(134, 183);
            this.PartPrice.Name = "PartPrice";
            this.PartPrice.Size = new System.Drawing.Size(137, 20);
            this.PartPrice.TabIndex = 15;
            this.PartPrice.TextChanged += new System.EventHandler(this.PartPrice_TextChanged);
            // 
            // PartMax
            // 
            this.PartMax.BackColor = System.Drawing.Color.Salmon;
            this.PartMax.Location = new System.Drawing.Point(117, 222);
            this.PartMax.Name = "PartMax";
            this.PartMax.Size = new System.Drawing.Size(63, 20);
            this.PartMax.TabIndex = 16;
            this.PartMax.TextChanged += new System.EventHandler(this.PartMax_TextChanged);
            // 
            // PartMin
            // 
            this.PartMin.BackColor = System.Drawing.Color.Salmon;
            this.PartMin.Location = new System.Drawing.Point(208, 222);
            this.PartMin.Name = "PartMin";
            this.PartMin.Size = new System.Drawing.Size(63, 20);
            this.PartMin.TabIndex = 17;
            this.PartMin.TextChanged += new System.EventHandler(this.PartMin_TextChanged);
            // 
            // UniquePartValue
            // 
            this.UniquePartValue.BackColor = System.Drawing.Color.Salmon;
            this.UniquePartValue.Location = new System.Drawing.Point(134, 261);
            this.UniquePartValue.Name = "UniquePartValue";
            this.UniquePartValue.Size = new System.Drawing.Size(137, 20);
            this.UniquePartValue.TabIndex = 18;
            this.UniquePartValue.TextChanged += new System.EventHandler(this.UniquePartValue_TextChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 347);
            this.Controls.Add(this.UniquePartValue);
            this.Controls.Add(this.PartMin);
            this.Controls.Add(this.PartMax);
            this.Controls.Add(this.PartPrice);
            this.Controls.Add(this.PartInventoryCount);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.PartId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PartSaveButton);
            this.Controls.Add(this.UniquePartDescripter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutsourcedRadioOption);
            this.Controls.Add(this.InHouseRadioOption);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseRadioOption;
        private System.Windows.Forms.RadioButton OutsourcedRadioOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label UniquePartDescripter;
        private System.Windows.Forms.Button PartSaveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PartId;
        private System.Windows.Forms.TextBox PartName;
        private System.Windows.Forms.TextBox PartInventoryCount;
        private System.Windows.Forms.TextBox PartPrice;
        private System.Windows.Forms.TextBox PartMax;
        private System.Windows.Forms.TextBox PartMin;
        private System.Windows.Forms.TextBox UniquePartValue;
    }
}