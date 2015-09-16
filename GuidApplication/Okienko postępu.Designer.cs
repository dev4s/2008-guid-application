namespace GuidApplication
{
    partial class OkienkoPostepu
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
            this.PasekPostepu = new System.Windows.Forms.ProgressBar();
            this.Label = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasekPostepu
            // 
            this.PasekPostepu.Location = new System.Drawing.Point(12, 66);
            this.PasekPostepu.Name = "PasekPostepu";
            this.PasekPostepu.Size = new System.Drawing.Size(274, 26);
            this.PasekPostepu.Step = 1;
            this.PasekPostepu.TabIndex = 2;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(78, 17);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(137, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Aktualnie mail wysyłany do:";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(78, 38);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(0, 13);
            this.MailLabel.TabIndex = 1;
            // 
            // OkienkoPostepu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 107);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.PasekPostepu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OkienkoPostepu";
            this.Text = "Trwa wysyłanie:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PasekPostepu;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label MailLabel;
    }
}