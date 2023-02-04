namespace robert_baxter_inventory_system
{
    partial class AddProductLayout
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductIdInput = new System.Windows.Forms.TextBox();
            this.ProductMaxInput = new System.Windows.Forms.TextBox();
            this.ProductPriceInput = new System.Windows.Forms.TextBox();
            this.ProductInventoryInput = new System.Windows.Forms.TextBox();
            this.ProductNameInput = new System.Windows.Forms.TextBox();
            this.ProductMinInput = new System.Windows.Forms.TextBox();
            this.AllPartsDisplay = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartsAssociatedToProduct = new System.Windows.Forms.DataGridView();
            this.AssociaterdPartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssociatedPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddPartToProductButton = new System.Windows.Forms.Button();
            this.DeleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SaveProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsAssociatedToProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // ProductIdInput
            // 
            this.ProductIdInput.Location = new System.Drawing.Point(110, 160);
            this.ProductIdInput.Name = "ProductIdInput";
            this.ProductIdInput.ReadOnly = true;
            this.ProductIdInput.Size = new System.Drawing.Size(100, 20);
            this.ProductIdInput.TabIndex = 7;
            // 
            // ProductMaxInput
            // 
            this.ProductMaxInput.BackColor = System.Drawing.Color.Salmon;
            this.ProductMaxInput.Location = new System.Drawing.Point(81, 330);
            this.ProductMaxInput.Name = "ProductMaxInput";
            this.ProductMaxInput.Size = new System.Drawing.Size(61, 20);
            this.ProductMaxInput.TabIndex = 9;
            this.ProductMaxInput.TextChanged += new System.EventHandler(this.ProductMaxInput_TextChanged);
            // 
            // ProductPriceInput
            // 
            this.ProductPriceInput.BackColor = System.Drawing.Color.Salmon;
            this.ProductPriceInput.Location = new System.Drawing.Point(110, 289);
            this.ProductPriceInput.Name = "ProductPriceInput";
            this.ProductPriceInput.Size = new System.Drawing.Size(100, 20);
            this.ProductPriceInput.TabIndex = 10;
            this.ProductPriceInput.TextChanged += new System.EventHandler(this.ProductPriceInput_TextChanged);
            // 
            // ProductInventoryInput
            // 
            this.ProductInventoryInput.BackColor = System.Drawing.Color.Salmon;
            this.ProductInventoryInput.Location = new System.Drawing.Point(110, 248);
            this.ProductInventoryInput.Name = "ProductInventoryInput";
            this.ProductInventoryInput.Size = new System.Drawing.Size(100, 20);
            this.ProductInventoryInput.TabIndex = 11;
            this.ProductInventoryInput.TextChanged += new System.EventHandler(this.ProductInventoryInput_TextChanged);
            // 
            // ProductNameInput
            // 
            this.ProductNameInput.BackColor = System.Drawing.Color.Salmon;
            this.ProductNameInput.Location = new System.Drawing.Point(110, 201);
            this.ProductNameInput.Name = "ProductNameInput";
            this.ProductNameInput.Size = new System.Drawing.Size(100, 20);
            this.ProductNameInput.TabIndex = 12;
            this.ProductNameInput.TextChanged += new System.EventHandler(this.ProductNameInput_TextChanged);
            // 
            // ProductMinInput
            // 
            this.ProductMinInput.BackColor = System.Drawing.Color.Salmon;
            this.ProductMinInput.Location = new System.Drawing.Point(178, 330);
            this.ProductMinInput.Name = "ProductMinInput";
            this.ProductMinInput.Size = new System.Drawing.Size(61, 20);
            this.ProductMinInput.TabIndex = 13;
            this.ProductMinInput.TextChanged += new System.EventHandler(this.ProductMinInput_TextChanged);
            // 
            // AllPartsDisplay
            // 
            this.AllPartsDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllPartsDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllPartsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.ProductName,
            this.InStock});
            this.AllPartsDisplay.Location = new System.Drawing.Point(297, 71);
            this.AllPartsDisplay.MultiSelect = false;
            this.AllPartsDisplay.Name = "AllPartsDisplay";
            this.AllPartsDisplay.ReadOnly = true;
            this.AllPartsDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsDisplay.Size = new System.Drawing.Size(462, 150);
            this.AllPartsDisplay.TabIndex = 14;
            this.AllPartsDisplay.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AllPartsDisplay_DataBindingComplete);
            // 
            // PartId
            // 
            this.PartId.DataPropertyName = "PartId";
            this.PartId.HeaderText = "Part ID";
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // InStock
            // 
            this.InStock.DataPropertyName = "InStock";
            this.InStock.HeaderText = "Inventory";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            // 
            // PartsAssociatedToProduct
            // 
            this.PartsAssociatedToProduct.ReadOnly = true;
            this.PartsAssociatedToProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsAssociatedToProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PartsAssociatedToProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsAssociatedToProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsAssociatedToProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssociaterdPartId,
            this.AssociatedPartName,
            this.AssociatedInStock,
            this.AssociatedPartPrice,
            this.AssociatedPartMin,
            this.AssociatedPartMax});
            this.PartsAssociatedToProduct.Location = new System.Drawing.Point(297, 307);
            this.PartsAssociatedToProduct.Name = "PartsAssociatedToProduct";
            this.PartsAssociatedToProduct.Size = new System.Drawing.Size(462, 150);
            this.PartsAssociatedToProduct.TabIndex = 15;
            // 
            // AssociaterdPartId
            // 
            this.AssociaterdPartId.DataPropertyName = "PartId";
            this.AssociaterdPartId.HeaderText = "Part ID";
            this.AssociaterdPartId.Name = "AssociaterdPartId";
            // 
            // AssociatedPartName
            // 
            this.AssociatedPartName.DataPropertyName = "Name";
            this.AssociatedPartName.HeaderText = "Name";
            this.AssociatedPartName.Name = "AssociatedPartName";
            // 
            // AssociatedInStock
            // 
            this.AssociatedInStock.DataPropertyName = "InStock";
            this.AssociatedInStock.HeaderText = "Inventory";
            this.AssociatedInStock.Name = "AssociatedInStock";
            // 
            // AssociatedPartPrice
            // 
            this.AssociatedPartPrice.DataPropertyName = "Price";
            this.AssociatedPartPrice.HeaderText = "Price";
            this.AssociatedPartPrice.Name = "AssociatedPartPrice";
            // 
            // AssociatedPartMin
            // 
            this.AssociatedPartMin.DataPropertyName = "Min";
            this.AssociatedPartMin.HeaderText = "Min";
            this.AssociatedPartMin.Name = "AssociatedPartMin";
            // 
            // AssociatedPartMax
            // 
            this.AssociatedPartMax.DataPropertyName = "Max";
            this.AssociatedPartMax.HeaderText = "Max";
            this.AssociatedPartMax.Name = "AssociatedPartMax";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(588, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(171, 20);
            this.textBox7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "All candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddPartToProductButton
            // 
            this.AddPartToProductButton.Location = new System.Drawing.Point(684, 238);
            this.AddPartToProductButton.Name = "AddPartToProductButton";
            this.AddPartToProductButton.Size = new System.Drawing.Size(75, 30);
            this.AddPartToProductButton.TabIndex = 20;
            this.AddPartToProductButton.Text = "Add";
            this.AddPartToProductButton.UseVisualStyleBackColor = true;
            this.AddPartToProductButton.Click += new System.EventHandler(this.AddPartToProductButton_Click);
            // 
            // DeleteAssociatedPartButton
            // 
            this.DeleteAssociatedPartButton.Location = new System.Drawing.Point(684, 478);
            this.DeleteAssociatedPartButton.Name = "DeleteAssociatedPartButton";
            this.DeleteAssociatedPartButton.Size = new System.Drawing.Size(75, 30);
            this.DeleteAssociatedPartButton.TabIndex = 21;
            this.DeleteAssociatedPartButton.Text = "Delete";
            this.DeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.DeleteAssociatedPartButton.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.Location = new System.Drawing.Point(588, 524);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(75, 30);
            this.SaveProductButton.TabIndex = 23;
            this.SaveProductButton.Text = "Save";
            this.SaveProductButton.UseVisualStyleBackColor = true;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // AddProductLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 569);
            this.Controls.Add(this.SaveProductButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteAssociatedPartButton);
            this.Controls.Add(this.AddPartToProductButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.PartsAssociatedToProduct);
            this.Controls.Add(this.AllPartsDisplay);
            this.Controls.Add(this.ProductMinInput);
            this.Controls.Add(this.ProductNameInput);
            this.Controls.Add(this.ProductInventoryInput);
            this.Controls.Add(this.ProductPriceInput);
            this.Controls.Add(this.ProductMaxInput);
            this.Controls.Add(this.ProductIdInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsAssociatedToProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductIdInput;
        private System.Windows.Forms.TextBox ProductMaxInput;
        private System.Windows.Forms.TextBox ProductPriceInput;
        private System.Windows.Forms.TextBox ProductInventoryInput;
        private System.Windows.Forms.TextBox ProductNameInput;
        private System.Windows.Forms.TextBox ProductMinInput;
        private System.Windows.Forms.DataGridView AllPartsDisplay;
        private System.Windows.Forms.DataGridView PartsAssociatedToProduct;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddPartToProductButton;
        private System.Windows.Forms.Button DeleteAssociatedPartButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociaterdPartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedPartMax;
    }
}