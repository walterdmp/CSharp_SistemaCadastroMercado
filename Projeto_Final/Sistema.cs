using System.Data;

namespace Projeto_Final
{
    public partial class Sistema : Form
    {
        int idAlterar;

        public Sistema()
        {
            InitializeComponent();
        }

        private void btn_ConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.Nome = txt_AlteraNome.Text;
            novoProduto.Quantidade = Convert.ToInt32(txt_AlteraQuantidade.Text);
            novoProduto.Preco = double.Parse(txt_AlteraPreco.Text);
            novoProduto.Categoria = Convert.ToInt32(cb_AlteraCategoria.SelectedValue.ToString());
            bool retorno = con.alteraProduto(novoProduto, idAlterar);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Alteração realizada com sucesso!");

            limpaCampos();
            lista_GridProdutos();
        }

        private void limpaCampos()
        {
            txt_Nome.Clear();
            txt_Qtd.Clear();
            txt_Preco.Clear();
            cb_Categoria.Text = "";
            txt_Nome.Focus();

            txt_AlteraNome.Clear();
            txt_AlteraQuantidade.Clear();
            txt_AlteraPreco.Clear();
            cb_AlteraCategoria.Text = "";
        }
        private void btn_ConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.Nome = txt_Nome.Text;
            novoProduto.Quantidade = int.Parse(txt_Qtd.Text);
            novoProduto.Preco = double.Parse(txt_Preco.Text);
            novoProduto.Categoria = int.Parse(cb_Categoria.SelectedValue.ToString());

            bool retorno = con.insereProduto(novoProduto);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }

            limpaCampos();
            lista_GridProdutos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaCBCategorias();
            limpaCampos();
            lista_GridProdutos();
        }

        public void listaCBCategorias()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaCategorias();
            cb_Categoria.DataSource = tabelaDados;
            cb_Categoria.DisplayMember = "categoria";
            cb_Categoria.ValueMember = "idcategoria";

            cb_AlteraCategoria.DataSource = tabelaDados;
            cb_AlteraCategoria.DisplayMember = "categoria";
            cb_AlteraCategoria.ValueMember = "idcategoria";
        }

        public void lista_GridProdutos()
        {
            ConectaBanco con = new ConectaBanco();
            dg_Produtos.DataSource = con.listaProdutos();
            dg_Produtos.Columns["idproduto"].Visible = false;
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            (dg_Produtos.DataSource as DataTable).DefaultView.RowFilter =
    string.Format("nome like '{0}%'", txt_Busca.Text);
        }

        private void btn_RemoverProduto_Click(object sender, EventArgs e)
        {
            int linha = dg_Produtos.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dg_Produtos.Rows[linha].Cells["idproduto"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaProduto(id);
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluido com sucesso!");
                    lista_GridProdutos();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btn_AdicionaCategoria_Click(object sender, EventArgs e)
        {
            frm_AddCategoria formCategoria = new frm_AddCategoria(this); // Passando a referência do Sistema para frm_AddCategoria
            this.Hide();
            formCategoria.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            int linha = dg_Produtos.CurrentRow.Index;// pega a linha selecionada
            idAlterar = Convert.ToInt32(
              dg_Produtos.Rows[linha].Cells["idproduto"].Value.ToString());
            txt_AlteraNome.Text =
                 dg_Produtos.Rows[linha].Cells["nome"].Value.ToString();
            txt_AlteraQuantidade.Text =
                dg_Produtos.Rows[linha].Cells["quantidade"].Value.ToString();
            txt_AlteraPreco.Text =
                dg_Produtos.Rows[linha].Cells["preco"].Value.ToString();
            cb_AlteraCategoria.Text =
                dg_Produtos.Rows[linha].Cells["categoria"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;// muda aba
        }
    }
}