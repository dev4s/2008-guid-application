using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Mail;


namespace GuidApplication
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Funkcja do otwarcia pliku
        /// zwraca tablicê string[]
        /// </summary>
        /// <param name="file">wczytywany plik</param>
        /// <returns></returns>
        private ArrayList Read(string file)
        {
            StreamReader reader = new StreamReader(file);
            //dynamiczna tablica
            ArrayList Table = new ArrayList();
            //dopóki nie bêdzie koñca strumienia
            //EndOfStream zwraca false dopóki nie ma koñca strumienia
            while (!reader.EndOfStream)
            {
                //dodaj do tablicy GuidTable kolejn¹ liniê
                Table.Add(reader.ReadLine());
            }
            //zamknij strumieñ reader
            reader.Close();
            return Table;
        }

        /// <summary>
        /// Funkcja do zamkniêcia pliku
        /// nic nie zwraca
        /// </summary>
        /// <param name="file">Nazwa pliku</param>
        /// <param name="data">Dane zapisywane linia po linii</param>
        /// <param name="append">Czy ma byæ dopisywany?</param>
        private void Save(string file, string data, Boolean append)
        {
            try
            {
                StreamWriter writer = new StreamWriter(file, append);
                writer.WriteLine(data);
                writer.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Plik jest akuratnie u¿ywany!", "Uwaga!!!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void WczytajGuid_Click(object sender, EventArgs e)
        {
            //domyœlnie wczytywane bêd¹ pliki *.csv
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            //zwracanie rezultatu otwarcia okienka dialogowego
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //je¿eli rezultat jest w porz¹dku to wykona siê poni¿szy kod
                ArrayList GuidTable = Read(openFileDialog1.FileName);
                //pomijam pierwszy i ostatni wpis w tablicy - interesuj¹ mnie tylko guid-y
                for (int i = 1; i < GuidTable.Count - 1; i++)
                {
                    GuidListBox.Items.Add(GuidTable[i]);
                }
            }
        }

        private void WczytajMaile_Click(object sender, EventArgs e)
        {
            //domyœlnie wczytywane bêd¹ pliki *.txt
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = "";
            //zwracanie rezultatu otwarcia okienka dialogowego
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //je¿eli rezultat jest w porz¹dku to wykona siê poni¿szy kod
                ArrayList MailTable = Read(openFileDialog1.FileName);
                MailTable.Sort();
                for (int i = 0; i < MailTable.Count; i++)
                {
                    MailListBox.Items.Add(MailTable[i]);
                }
            }
        }

        private void WyslijMaile_Click(object sender, EventArgs e)
        {
            OkienkoPostepu Okienko = new OkienkoPostepu();
            int Counter = 0;

            if (GuidListBox.Items.Count == 0 || MailListBox.Items.Count == 0)
            {
                MessageBox.Show("Nie zosta³ wczytany ¿aden Guid i/lub E-mail", "Uwaga!!!");
                return;
            }

            Okienko.Show();
            Okienko.PasekPostepuSetMax = MailListBox.Items.Count;

            //wysy³anie maila
            for (int i = 0; i < MailListBox.Items.Count; i++)
            {
                Okienko.MailLabelSet = MailListBox.Items[i].ToString();
                Okienko.PasekPostepuSetValue = i + 1;
                string TextToSend = BodyRichEdit.Text + "\n\n" + GuidListBox.Items[i].ToString();
                MailMessage MailToSend = new MailMessage(MailTextBox.Text, MailListBox.Items[i].ToString(), SubjectTextBox.Text, TextToSend);

                SmtpClient ClientSmtp = new SmtpClient();
                ClientSmtp.Host = ServerTextBox.Text;
                ClientSmtp.Port = Int32.Parse(PortTextBox.Text);
                //domyœlnie w³¹czony ssl
                ClientSmtp.EnableSsl = true;
                ClientSmtp.Timeout = 15000;
                ClientSmtp.Credentials = new NetworkCredential(UserNameTextBox.Text, PasswordTextBox.Text);
                try
                {
                    ClientSmtp.Send(MailToSend);
                }
                catch (SmtpException)
                {
                    MessageBox.Show("Program nie móg³ wys³aæ e-maila", "Uwaga!!!");
                }
                Counter++;
                //ToDo: w razie niepowodzenia, co ma program robiæ
            }

            Counter -= 1;

            for (; Counter >= 0; Counter--)
            {
                GuidListBox.Items.RemoveAt(Counter);
                MailListBox.Items.RemoveAt(Counter);
            }

            MessageBox.Show("Program zakoñczy³ wysy³anie maili.\nNie zapomnij zapisaæ ustawieñ i Guidów!", "Koniec");
            Okienko.Close();
        }

        private void CzyscGuid_Click(object sender, EventArgs e)
        {
            GuidListBox.Items.Clear();
            CzyscGuid.Enabled = false;
            openFileDialog1.FileName = "";
        }

        private void CzyscMaile_Click(object sender, EventArgs e)
        {
            MailListBox.Items.Clear();
            CzyscMaile.Enabled = false;
            openFileDialog1.FileName = "";
        }

        private void ZapiszGuid_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string File = saveFileDialog1.FileName.ToString();
                string FirsLine = "<!-- Poczatek Guid -->";
                string LastLine = "<!-- Koniec Guid -->";
                Save(File, FirsLine, true);
                for (int i = 0; i < GuidListBox.Items.Count; i++)
                    Save(File, GuidListBox.Items[i].ToString(), true);
                Save(File, LastLine, true);
            }
        }

        private void ZapiszUstawienia_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.FileName = "";

            ArrayList TempArray = new ArrayList();
            string CodedPassword = null;
            TempArray.AddRange(PasswordTextBox.Text.ToCharArray());
            for (int i = 0; i < TempArray.Count; i++)
            {
                char TempChar;
                char.TryParse(TempArray[i].ToString(), out TempChar);
                TempChar += '\x01';
                CodedPassword += TempChar;
            }

            string SettingsToSave = SubjectTextBox.Text.ToString() + "\n" 
                + MailTextBox.Text.ToString() + "\n" 
                + UserNameTextBox.Text.ToString() + "\n" 
                + CodedPassword + "\n" 
                + ServerTextBox.Text.ToString() + "\n" 
                + PortTextBox.Text.ToString() + "\n<!-- Body -->\n" 
                + BodyRichEdit.Text.ToString() + "\n<!-- EndOfBody -->\n";

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string File = saveFileDialog1.FileName.ToString();
                Save(File, SettingsToSave, false);
            }
        }

        private void WczytajUstawienia_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                ArrayList SettingsTable = Read(openFileDialog1.FileName);
                SubjectTextBox.Text = SettingsTable[0].ToString();
                MailTextBox.Text = SettingsTable[1].ToString();
                UserNameTextBox.Text = SettingsTable[2].ToString();

                string UnCodedPassword = null;
                string TempPassword = SettingsTable[3].ToString();
                ArrayList TempArrayPass = new ArrayList();
                TempArrayPass.AddRange(TempPassword.ToCharArray());
                for (int i = 0; i < TempArrayPass.Count; i++)
                {
                    char TempChar;
                    char.TryParse(TempArrayPass[i].ToString(), out TempChar);
                    TempChar -= '\x01';
                    UnCodedPassword += TempChar;
                }

                PasswordTextBox.Text = UnCodedPassword;
                ServerTextBox.Text = SettingsTable[4].ToString();
                PortTextBox.Text = SettingsTable[5].ToString();

                int j = 7;
                string BodySetting = null;
                while(!(SettingsTable[j].ToString() == "<!-- EndOfBody -->"))
                {
                    BodySetting += SettingsTable[j].ToString() + "\n";
                    j++;
                }

                BodyRichEdit.Text = BodySetting;
                MessageBox.Show("Ustawienia wczytane!", "Ustawienia");
            }
        }
    }
}