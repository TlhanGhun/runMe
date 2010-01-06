using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using runMe;
using System.Net;

namespace runMe
{
    public partial class Options : Form
    {

        public Options()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private string replacePlaceholder(string toBeWorkedOnText)
        {
            toBeWorkedOnText = toBeWorkedOnText.Replace("%title%", "PLACEHOLDER TITLE");
            return toBeWorkedOnText.Replace("%text%", "PLACEHOLDER TEXT");
        }



    }
}
