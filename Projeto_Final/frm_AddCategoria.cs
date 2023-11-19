using System;
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
    public partial class frm_AddCategoria : Form
    {
        public frm_AddCategoria()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Form1 formSistema = new Form1();
            this.Close();
            formSistema.Show();
        }

        private void btn_AddCategoria_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereCategoria(txt_AddCategoria.Text);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
            else
            {
                MessageBox.Show("Categoria adicionada com sucesso!");
                txt_AddCategoria.Clear();
                txt_AddCategoria.Focus();

            }

        }
    }
}
