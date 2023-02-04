namespace robert_baxter_inventory_system
{
    partial class DeleteConfirm
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
            this.DeleteConfirmationMessage = new System.Windows.Forms.Label();
            this.CancelDelete = new System.Windows.Forms.Button();
            this.ConfirmDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteConfirmationMessage
            // 
            this.DeleteConfirmationMessage.AutoSize = true;
            this.DeleteConfirmationMessage.Location = new System.Drawing.Point(21, 24);
            this.DeleteConfirmationMessage.Name = "DeleteConfirmationMessage";
            this.DeleteConfirmationMessage.Size = new System.Drawing.Size(203, 13);
            this.DeleteConfirmationMessage.TabIndex = 0;
            this.DeleteConfirmationMessage.Text = "Are you sure you want to delete this item?";
            // 
            // CancelDelete
            // 
            this.CancelDelete.Location = new System.Drawing.Point(149, 61);
            this.CancelDelete.Name = "CancelDelete";
            this.CancelDelete.Size = new System.Drawing.Size(75, 23);
            this.CancelDelete.TabIndex = 1;
            this.CancelDelete.Text = "Cancel";
            this.CancelDelete.UseVisualStyleBackColor = true;
            this.CancelDelete.Click += new System.EventHandler(this.CancelDeleteClick);
            // 
            // ConfirmDelete
            // 
            this.ConfirmDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmDelete.Location = new System.Drawing.Point(68, 61);
            this.ConfirmDelete.Name = "ConfirmDelete";
            this.ConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDelete.TabIndex = 2;
            this.ConfirmDelete.Text = "Delete";
            this.ConfirmDelete.UseVisualStyleBackColor = true;
            this.ConfirmDelete.Click += new System.EventHandler(this.ConfirmDeleteClick);
            // 
            // DeleteConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 96);
            this.Controls.Add(this.ConfirmDelete);
            this.Controls.Add(this.CancelDelete);
            this.Controls.Add(this.DeleteConfirmationMessage);
            this.Name = "DeleteConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteConfirmationMessage;
        private System.Windows.Forms.Button CancelDelete;
        private System.Windows.Forms.Button ConfirmDelete;
    }
}