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
        Sistema formSistema;
        public frm_AddCategoria()
        {
            InitializeComponent();
        }
        public frm_AddCategoria(Sistema sistema)
        {
            InitializeComponent();
            formSistema = sistema;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
            formSistema.Show(); // Mostra o formulário Sistema novamente
        }

        private void btn_AddCategoria_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereCategoria(txt_AddCategoria.Text, formSistema);
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

        private void frm_AddCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
