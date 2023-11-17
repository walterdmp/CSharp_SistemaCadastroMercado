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

        private void btn_ConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Produto novoProduto = new Produto();
            novoProduto.Nome = txt_Nome.Text;
            novoProduto.Quantidade = int.Parse(txt_Qtd.Text);
            novoProduto.Preco = double.Parse(txt_Preco.Text);
            novoProduto.Categoria = 1;

            bool retorno = con.insereProduto(novoProduto);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
        }
    }
}