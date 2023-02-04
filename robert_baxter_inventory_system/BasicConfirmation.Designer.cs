namespace robert_baxter_inventory_system
{
    partial class BasicConfirmation
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
            this.ConfirmationCloseButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmationCloseButton
            // 
            this.ConfirmationCloseButton.Location = new System.Drawing.Point(220, 59);
            this.ConfirmationCloseButton.Name = "ConfirmationCloseButton";
            this.ConfirmationCloseButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmationCloseButton.TabIndex = 0;
            this.ConfirmationCloseButton.Text = "Okay";
            this.ConfirmationCloseButton.UseVisualStyleBackColor = true;
            this.ConfirmationCloseButton.Click += new System.EventHandler(this.ConfirmationCloseButtonClick);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(36, 31);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(143, 13);
            this.Message.TabIndex = 1;
            this.Message.Text = "Something needs confirming.";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 89);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ConfirmationCloseButton);
            this.Name = "Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmationCloseButton;
        private System.Windows.Forms.Label Message;
    }
}