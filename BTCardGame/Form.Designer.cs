namespace BTCardGame
{
    partial class Form
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.convertionButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(24, 81);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(335, 20);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Please enter your hand into the textbox above.";
            // 
            // convertionButton
            // 
            this.convertionButton.Location = new System.Drawing.Point(284, 23);
            this.convertionButton.Name = "convertionButton";
            this.convertionButton.Size = new System.Drawing.Size(89, 43);
            this.convertionButton.TabIndex = 1;
            this.convertionButton.Text = "Convert";
            this.convertionButton.UseVisualStyleBackColor = true;
            this.convertionButton.Click += new System.EventHandler(this.convertionButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(28, 31);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(250, 26);
            this.inputTextBox.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 133);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.convertionButton);
            this.Controls.Add(this.messageLabel);
            this.Name = "Form";
            this.Text = "Card Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button convertionButton;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

