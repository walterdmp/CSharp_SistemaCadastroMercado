using System.Data;

namespace Projeto_Final
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void btn_ConfirmaAlteracao_Click(object sender, EventArgs e)
        {

        }

        private void limpaCampos()
        {
            txt_Nome.Clear();
            txt_Qtd.Clear();
            txt_Preco.Clear();
            cb_Categoria.Text = "";
            txt_Nome.Focus();
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
    }
}