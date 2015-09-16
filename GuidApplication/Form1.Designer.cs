namespace GuidApplication
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MailListBox = new System.Windows.Forms.ListBox();
            this.WczytajMail = new System.Windows.Forms.Button();
            this.WczytajGuid = new System.Windows.Forms.Button();
            this.GuidListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.WczytajUstawienia = new System.Windows.Forms.Button();
            this.ZapiszUstawienia = new System.Windows.Forms.Button();
            this.WyslijMaile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BodyRichEdit = new System.Windows.Forms.RichTextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CzyscGuid = new System.Windows.Forms.Button();
            this.CzyscMaile = new System.Windows.Forms.Button();
            this.ZapiszGuid = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Plik CSV (*.csv)|*.csv|Plik tekstowy (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            // 
            // MailListBox
            // 
            this.MailListBox.FormattingEnabled = true;
            this.MailListBox.Location = new System.Drawing.Point(326, 41);
            this.MailListBox.Name = "MailListBox";
            this.MailListBox.Size = new System.Drawing.Size(307, 303);
            this.MailListBox.TabIndex = 16;
            // 
            // WczytajMail
            // 
            this.WczytajMail.Location = new System.Drawing.Point(326, 12);
            this.WczytajMail.Name = "WczytajMail";
            this.WczytajMail.Size = new System.Drawing.Size(82, 23);
            this.WczytajMail.TabIndex = 3;
            this.WczytajMail.Text = "Wczytaj Maile";
            this.WczytajMail.UseVisualStyleBackColor = true;
            this.WczytajMail.Click += new System.EventHandler(this.WczytajMaile_Click);
            // 
            // WczytajGuid
            // 
            this.WczytajGuid.Location = new System.Drawing.Point(12, 12);
            this.WczytajGuid.Name = "WczytajGuid";
            this.WczytajGuid.Size = new System.Drawing.Size(82, 23);
            this.WczytajGuid.TabIndex = 0;
            this.WczytajGuid.Text = "Wczytaj Guid";
            this.WczytajGuid.UseVisualStyleBackColor = true;
            this.WczytajGuid.Click += new System.EventHandler(this.WczytajGuid_Click);
            // 
            // GuidListBox
            // 
            this.GuidListBox.FormattingEnabled = true;
            this.GuidListBox.Location = new System.Drawing.Point(12, 41);
            this.GuidListBox.Name = "GuidListBox";
            this.GuidListBox.Size = new System.Drawing.Size(307, 303);
            this.GuidListBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nazwa u¿ytkownika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Serwer SMTP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Port:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(125, 402);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.UserNameTextBox.TabIndex = 7;
            this.UserNameTextBox.Text = "adres@serwer.pl";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(125, 454);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(151, 20);
            this.ServerTextBox.TabIndex = 9;
            this.ServerTextBox.Text = "serwer SMPT";
            // 
            // WczytajUstawienia
            // 
            this.WczytajUstawienia.Location = new System.Drawing.Point(75, 535);
            this.WczytajUstawienia.Name = "WczytajUstawienia";
            this.WczytajUstawienia.Size = new System.Drawing.Size(110, 23);
            this.WczytajUstawienia.TabIndex = 14;
            this.WczytajUstawienia.Text = "Wczytaj ustawienia";
            this.WczytajUstawienia.UseVisualStyleBackColor = true;
            this.WczytajUstawienia.Click += new System.EventHandler(this.WczytajUstawienia_Click);
            // 
            // ZapiszUstawienia
            // 
            this.ZapiszUstawienia.Location = new System.Drawing.Point(75, 506);
            this.ZapiszUstawienia.Name = "ZapiszUstawienia";
            this.ZapiszUstawienia.Size = new System.Drawing.Size(110, 23);
            this.ZapiszUstawienia.TabIndex = 13;
            this.ZapiszUstawienia.Text = "Zapisz ustawienia";
            this.ZapiszUstawienia.UseVisualStyleBackColor = true;
            this.ZapiszUstawienia.Click += new System.EventHandler(this.ZapiszUstawienia_Click);
            // 
            // WyslijMaile
            // 
            this.WyslijMaile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyslijMaile.Location = new System.Drawing.Point(191, 506);
            this.WyslijMaile.Name = "WyslijMaile";
            this.WyslijMaile.Size = new System.Drawing.Size(85, 52);
            this.WyslijMaile.TabIndex = 12;
            this.WyslijMaile.Text = "Wyœlij maile";
            this.WyslijMaile.UseVisualStyleBackColor = true;
            this.WyslijMaile.Click += new System.EventHandler(this.WyslijMaile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Has³o:";
            // 
            // BodyRichEdit
            // 
            this.BodyRichEdit.Location = new System.Drawing.Point(282, 350);
            this.BodyRichEdit.Name = "BodyRichEdit";
            this.BodyRichEdit.Size = new System.Drawing.Size(351, 208);
            this.BodyRichEdit.TabIndex = 11;
            this.BodyRichEdit.Text = "Tutaj wpisz treœæ przyk³adowego maila, np:\nGuidy do ankiet:";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(125, 376);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(151, 20);
            this.MailTextBox.TabIndex = 6;
            this.MailTextBox.Text = "adres@serwer.pl";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(125, 350);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(151, 20);
            this.SubjectTextBox.TabIndex = 5;
            this.SubjectTextBox.Text = "Tutaj wpisz temat wiadomoœci";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Temat:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(125, 428);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(151, 20);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.Text = "jakieœ has³o";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(125, 480);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(151, 20);
            this.PortTextBox.TabIndex = 10;
            this.PortTextBox.Text = "25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adres E-mail:";
            // 
            // CzyscGuid
            // 
            this.CzyscGuid.Location = new System.Drawing.Point(100, 12);
            this.CzyscGuid.Name = "CzyscGuid";
            this.CzyscGuid.Size = new System.Drawing.Size(75, 23);
            this.CzyscGuid.TabIndex = 1;
            this.CzyscGuid.Text = "Czyœæ Guid";
            this.CzyscGuid.UseVisualStyleBackColor = true;
            this.CzyscGuid.Click += new System.EventHandler(this.CzyscGuid_Click);
            // 
            // CzyscMaile
            // 
            this.CzyscMaile.Location = new System.Drawing.Point(414, 12);
            this.CzyscMaile.Name = "CzyscMaile";
            this.CzyscMaile.Size = new System.Drawing.Size(75, 23);
            this.CzyscMaile.TabIndex = 4;
            this.CzyscMaile.Text = "Czyœæ Maile";
            this.CzyscMaile.UseVisualStyleBackColor = true;
            this.CzyscMaile.Click += new System.EventHandler(this.CzyscMaile_Click);
            // 
            // ZapiszGuid
            // 
            this.ZapiszGuid.Location = new System.Drawing.Point(181, 12);
            this.ZapiszGuid.Name = "ZapiszGuid";
            this.ZapiszGuid.Size = new System.Drawing.Size(75, 23);
            this.ZapiszGuid.TabIndex = 2;
            this.ZapiszGuid.Text = "Zapisz Guid";
            this.ZapiszGuid.UseVisualStyleBackColor = true;
            this.ZapiszGuid.Click += new System.EventHandler(this.ZapiszGuid_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Plik CSV (*.csv)|*.csv|Plik tekstowy (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 572);
            this.Controls.Add(this.ZapiszGuid);
            this.Controls.Add(this.CzyscMaile);
            this.Controls.Add(this.CzyscGuid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.BodyRichEdit);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WyslijMaile);
            this.Controls.Add(this.ZapiszUstawienia);
            this.Controls.Add(this.WczytajUstawienia);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailListBox);
            this.Controls.Add(this.WczytajMail);
            this.Controls.Add(this.WczytajGuid);
            this.Controls.Add(this.GuidListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Guid Wysy³acz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox MailListBox;
        private System.Windows.Forms.Button WczytajMail;
        private System.Windows.Forms.Button WczytajGuid;
        private System.Windows.Forms.ListBox GuidListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Button WczytajUstawienia;
        private System.Windows.Forms.Button ZapiszUstawienia;
        private System.Windows.Forms.Button WyslijMaile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox BodyRichEdit;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CzyscGuid;
        private System.Windows.Forms.Button CzyscMaile;
        private System.Windows.Forms.Button ZapiszGuid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

