﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }


        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (txt_UserLogin.Text.Equals("adm") && txt_SenhaLogin.Text.Equals("123"))
            {
                Form1 sistema = new Form1();
                this.Hide();
                sistema.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
