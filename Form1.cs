﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var characterName = "MerindaPlac";
            var characterPower = "Speed";
            var characterHistory = "She is an elve who lives in NYC";

            lblMessage.Text += "Are you gamed already?";

            lblCharacterName.Text = characterName;

            lblCharacterPower.Text = characterPower;
            lblCharacterHistory.Text = characterHistory;

            
        }

        private void lblCharacterName_Click(object sender, EventArgs e)
        {

        }

        private void lblCharacterPower_Click(object sender, EventArgs e)
        {

        }

        private void lblCharacterHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
