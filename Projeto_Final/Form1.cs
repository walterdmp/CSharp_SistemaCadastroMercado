using System.Data;

namespace Projeto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void txt_Busca_TextChanged(object sender, EventArgs e)
        {
            (dg_Produtos.DataSource as DataTable).DefaultView.RowFilter =
    string.Format("nome like '{0}%'", txt_Busca.Text);
        }
    }
}