using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuidApplication
{
    public partial class OkienkoPostepu : Form
    {
        public OkienkoPostepu()
        {
            InitializeComponent();
        }
        public string MailLabelSet
        {
            set { MailLabel.Text = value; }
        }
        public int PasekPostepuSetMax
        {
            set { PasekPostepu.Maximum = value; }
        }
        public int PasekPostepuSetValue
        {
            set { PasekPostepu.Value = value; }
        }
    }
}