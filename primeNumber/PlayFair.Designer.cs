namespace primeNumber
{
    partial class PlayFair
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.GroupBox groupKey;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox inputMessage;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.TextBox output;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayFair));
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.inputMessage = new System.Windows.Forms.TextBox();
            this.groupKey = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.groupInput.SuspendLayout();
            this.groupKey.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInput
            // 
            this.groupInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupInput.Controls.Add(this.inputMessage);
            this.groupInput.Location = new System.Drawing.Point(174, 110);
            this.groupInput.Margin = new System.Windows.Forms.Padding(4);
            this.groupInput.Name = "groupInput";
            this.groupInput.Padding = new System.Windows.Forms.Padding(4);
            this.groupInput.Size = new System.Drawing.Size(323, 169);
            this.groupInput.TabIndex = 0;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input";
            // 
            // inputMessage
            // 
            this.inputMessage.BackColor = System.Drawing.SystemColors.Window;
            this.inputMessage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputMessage.Location = new System.Drawing.Point(8, 23);
            this.inputMessage.Margin = new System.Windows.Forms.Padding(4);
            this.inputMessage.Multiline = true;
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(297, 91);
            this.inputMessage.TabIndex = 0;
            // 
            // groupKey
            // 
            this.groupKey.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupKey.Controls.Add(this.textBoxKey);
            this.groupKey.Controls.Add(this.inputKey);
            this.groupKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupKey.Location = new System.Drawing.Point(497, 110);
            this.groupKey.Margin = new System.Windows.Forms.Padding(4);
            this.groupKey.Name = "groupKey";
            this.groupKey.Padding = new System.Windows.Forms.Padding(4);
            this.groupKey.Size = new System.Drawing.Size(355, 169);
            this.groupKey.TabIndex = 1;
            this.groupKey.TabStop = false;
            this.groupKey.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxKey.Location = new System.Drawing.Point(89, 55);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(181, 105);
            this.textBoxKey.TabIndex = 2;
            this.textBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputKey
            // 
            this.inputKey.BackColor = System.Drawing.SystemColors.HighlightText;
            this.inputKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputKey.Location = new System.Drawing.Point(8, 23);
            this.inputKey.Margin = new System.Windows.Forms.Padding(4);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(337, 22);
            this.inputKey.TabIndex = 1;
            // 
            // groupOutput
            // 
            this.groupOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupOutput.Controls.Add(this.output);
            this.groupOutput.Location = new System.Drawing.Point(175, 299);
            this.groupOutput.Margin = new System.Windows.Forms.Padding(4);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Padding = new System.Windows.Forms.Padding(4);
            this.groupOutput.Size = new System.Drawing.Size(677, 161);
            this.groupOutput.TabIndex = 2;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output.Location = new System.Drawing.Point(8, 23);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(660, 121);
            this.output.TabIndex = 0;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Image = global::primeNumber.Properties.Resources.pngimg_com___buttons_PNG128;
            this.buttonDecrypt.Location = new System.Drawing.Point(338, 240);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(143, 38);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Image = global::primeNumber.Properties.Resources.pngimg_com___buttons_PNG128;
            this.buttonEncrypt.Location = new System.Drawing.Point(182, 240);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(131, 38);
            this.buttonEncrypt.TabIndex = 3;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            // 
            // PlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1011, 705);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupKey);
            this.Controls.Add(this.groupInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PlayFair";
            this.Text = "Playfair";
            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupKey.ResumeLayout(false);
            this.groupKey.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}