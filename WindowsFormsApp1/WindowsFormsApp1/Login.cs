﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.ToLower()=="admin" && textBox2.Text == "admin")
            {
                // MessageBox.Show("login successful");
                Home h= new Home();
                Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }
    }
}
