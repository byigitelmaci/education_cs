﻿using Polymorphism_ders_18.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism_ders_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            npc npc = new npc();
            npc.saldir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            okcu okcu = new okcu();
            okcu.saldir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buyucu buyucu = new buyucu();
            buyucu.saldir();
        }

        //polymorphism(çok biçimlilik)

    }
}
