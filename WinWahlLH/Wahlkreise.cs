﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWahlLFH
{
    public partial class Wahlkreise : Form
    {
        public Wahlkreise()
        {
            InitializeComponent();
            UpdateWahlkreise();
        }
        private void UpdateWahlkreise()
        {
            foreach (Wahlkreis wahlkreis in Program.alleWahlkreise)
            {
                WahlkreiseListBox.Items.Add(wahlkreis.Name);
            }
        }

        private void WahlkreiseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KandidatenEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void WahlkreisOrtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrtNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void WahlkreiseBearbeitenGroup_Enter(object sender, EventArgs e)
        {

        }

        private void WahlkreisWahlberechtigtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
