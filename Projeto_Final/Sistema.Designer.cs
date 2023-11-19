namespace Projeto_Final
{
    partial class Sistema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tabAlterar = new TabPage();
            btn_ConfirmaAlteracao = new Button();
            cb_AlteraCategoria = new ComboBox();
            txt_AlteraPreco = new TextBox();
            txt_AlteraQuantidade = new TextBox();
            txt_AlteraNome = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            tabBuscar = new TabPage();
            dg_Produtos = new DataGridView();
            btn_Alterar = new Button();
            btn_RemoverProduto = new Button();
            txt_Busca = new TextBox();
            lbl_Produto = new Label();
            tabCadastrar = new TabPage();
            btn_AdicionaCategoria = new Button();
            btn_ConfirmaCadastro = new Button();
            cb_Categoria = new ComboBox();
            txt_Preco = new TextBox();
            txt_Qtd = new TextBox();
            txt_Nome = new TextBox();
            lbl_Preco = new Label();
            lbl_Qtd = new Label();
            lbl_Categoria = new Label();
            lbl_Nome = new Label();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabAlterar.SuspendLayout();
            tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Produtos).BeginInit();
            tabCadastrar.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 148);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.RoyalBlue;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(754, 0);
            button1.Name = "button1";
            button1.Size = new Size(47, 32);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(190, 47);
            label2.Name = "label2";
            label2.Size = new Size(492, 60);
            label2.TabIndex = 1;
            label2.Text = "Mercado Nova Machado";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabAlterar
            // 
            tabAlterar.BackColor = Color.DarkGray;
            tabAlterar.Controls.Add(btn_ConfirmaAlteracao);
            tabAlterar.Controls.Add(cb_AlteraCategoria);
            tabAlterar.Controls.Add(txt_AlteraPreco);
            tabAlterar.Controls.Add(txt_AlteraQuantidade);
            tabAlterar.Controls.Add(txt_AlteraNome);
            tabAlterar.Controls.Add(label7);
            tabAlterar.Controls.Add(label8);
            tabAlterar.Controls.Add(label9);
            tabAlterar.Controls.Add(label10);
            tabAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabAlterar.Location = new Point(4, 34);
            tabAlterar.Name = "tabAlterar";
            tabAlterar.Padding = new Padding(3);
            tabAlterar.Size = new Size(803, 274);
            tabAlterar.TabIndex = 2;
            tabAlterar.Text = "Alterar";
            // 
            // btn_ConfirmaAlteracao
            // 
            btn_ConfirmaAlteracao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ConfirmaAlteracao.Image = (Image)resources.GetObject("btn_ConfirmaAlteracao.Image");
            btn_ConfirmaAlteracao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ConfirmaAlteracao.Location = new Point(296, 203);
            btn_ConfirmaAlteracao.Name = "btn_ConfirmaAlteracao";
            btn_ConfirmaAlteracao.Size = new Size(205, 44);
            btn_ConfirmaAlteracao.TabIndex = 18;
            btn_ConfirmaAlteracao.Text = "Confirmar Alteração";
            btn_ConfirmaAlteracao.TextAlign = ContentAlignment.MiddleRight;
            btn_ConfirmaAlteracao.UseVisualStyleBackColor = true;
            btn_ConfirmaAlteracao.Click += btn_ConfirmaAlteracao_Click;
            // 
            // cb_AlteraCategoria
            // 
            cb_AlteraCategoria.FormattingEnabled = true;
            cb_AlteraCategoria.Location = new Point(127, 77);
            cb_AlteraCategoria.Name = "cb_AlteraCategoria";
            cb_AlteraCategoria.Size = new Size(558, 29);
            cb_AlteraCategoria.TabIndex = 17;
            // 
            // txt_AlteraPreco
            // 
            txt_AlteraPreco.BorderStyle = BorderStyle.FixedSingle;
            txt_AlteraPreco.Location = new Point(127, 168);
            txt_AlteraPreco.Name = "txt_AlteraPreco";
            txt_AlteraPreco.Size = new Size(558, 29);
            txt_AlteraPreco.TabIndex = 16;
            // 
            // txt_AlteraQuantidade
            // 
            txt_AlteraQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txt_AlteraQuantidade.Location = new Point(127, 124);
            txt_AlteraQuantidade.Name = "txt_AlteraQuantidade";
            txt_AlteraQuantidade.Size = new Size(558, 29);
            txt_AlteraQuantidade.TabIndex = 15;
            // 
            // txt_AlteraNome
            // 
            txt_AlteraNome.BorderStyle = BorderStyle.FixedSingle;
            txt_AlteraNome.Location = new Point(127, 35);
            txt_AlteraNome.Name = "txt_AlteraNome";
            txt_AlteraNome.Size = new Size(558, 29);
            txt_AlteraNome.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 170);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 13;
            label7.Text = "Preço:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(11, 127);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 12;
            label8.Text = "Quantidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(11, 80);
            label9.Name = "label9";
            label9.Size = new Size(85, 21);
            label9.TabIndex = 11;
            label9.Text = "Categoria:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(11, 38);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 10;
            label10.Text = "Nome: ";
            // 
            // tabBuscar
            // 
            tabBuscar.BackColor = Color.DarkGray;
            tabBuscar.Controls.Add(dg_Produtos);
            tabBuscar.Controls.Add(btn_Alterar);
            tabBuscar.Controls.Add(btn_RemoverProduto);
            tabBuscar.Controls.Add(txt_Busca);
            tabBuscar.Controls.Add(lbl_Produto);
            tabBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabBuscar.Location = new Point(4, 34);
            tabBuscar.Name = "tabBuscar";
            tabBuscar.Padding = new Padding(3);
            tabBuscar.Size = new Size(803, 274);
            tabBuscar.TabIndex = 1;
            tabBuscar.Text = "Buscar";
            // 
            // dg_Produtos
            // 
            dg_Produtos.BackgroundColor = Color.LightGray;
            dg_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Produtos.Location = new Point(39, 66);
            dg_Produtos.Name = "dg_Produtos";
            dg_Produtos.RowTemplate.Height = 25;
            dg_Produtos.Size = new Size(715, 195);
            dg_Produtos.TabIndex = 4;
            // 
            // btn_Alterar
            // 
            btn_Alterar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Alterar.Image = (Image)resources.GetObject("btn_Alterar.Image");
            btn_Alterar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Alterar.Location = new Point(621, 15);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(106, 45);
            btn_Alterar.TabIndex = 3;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.TextAlign = ContentAlignment.MiddleRight;
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_RemoverProduto
            // 
            btn_RemoverProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_RemoverProduto.Image = (Image)resources.GetObject("btn_RemoverProduto.Image");
            btn_RemoverProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RemoverProduto.Location = new Point(477, 15);
            btn_RemoverProduto.Name = "btn_RemoverProduto";
            btn_RemoverProduto.Size = new Size(114, 45);
            btn_RemoverProduto.TabIndex = 2;
            btn_RemoverProduto.Text = "Remover";
            btn_RemoverProduto.TextAlign = ContentAlignment.MiddleRight;
            btn_RemoverProduto.UseVisualStyleBackColor = true;
            btn_RemoverProduto.Click += btn_RemoverProduto_Click;
            // 
            // txt_Busca
            // 
            txt_Busca.BorderStyle = BorderStyle.FixedSingle;
            txt_Busca.Location = new Point(114, 23);
            txt_Busca.Name = "txt_Busca";
            txt_Busca.Size = new Size(283, 29);
            txt_Busca.TabIndex = 1;
            txt_Busca.TextChanged += txt_Busca_TextChanged;
            // 
            // lbl_Produto
            // 
            lbl_Produto.AutoSize = true;
            lbl_Produto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Produto.Location = new Point(39, 26);
            lbl_Produto.Name = "lbl_Produto";
            lbl_Produto.Size = new Size(74, 21);
            lbl_Produto.TabIndex = 0;
            lbl_Produto.Text = "Produto:";
            // 
            // tabCadastrar
            // 
            tabCadastrar.BackColor = Color.DarkGray;
            tabCadastrar.Controls.Add(btn_AdicionaCategoria);
            tabCadastrar.Controls.Add(btn_ConfirmaCadastro);
            tabCadastrar.Controls.Add(cb_Categoria);
            tabCadastrar.Controls.Add(txt_Preco);
            tabCadastrar.Controls.Add(txt_Qtd);
            tabCadastrar.Controls.Add(txt_Nome);
            tabCadastrar.Controls.Add(lbl_Preco);
            tabCadastrar.Controls.Add(lbl_Qtd);
            tabCadastrar.Controls.Add(lbl_Categoria);
            tabCadastrar.Controls.Add(lbl_Nome);
            tabCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabCadastrar.ForeColor = SystemColors.ControlText;
            tabCadastrar.Location = new Point(4, 34);
            tabCadastrar.Name = "tabCadastrar";
            tabCadastrar.Padding = new Padding(3);
            tabCadastrar.RightToLeft = RightToLeft.No;
            tabCadastrar.Size = new Size(803, 274);
            tabCadastrar.TabIndex = 0;
            tabCadastrar.Text = "Cadastrar";
            // 
            // btn_AdicionaCategoria
            // 
            btn_AdicionaCategoria.BackColor = Color.DarkGray;
            btn_AdicionaCategoria.BackgroundImageLayout = ImageLayout.None;
            btn_AdicionaCategoria.FlatAppearance.BorderColor = Color.DarkGray;
            btn_AdicionaCategoria.FlatStyle = FlatStyle.Flat;
            btn_AdicionaCategoria.ForeColor = Color.DarkGray;
            btn_AdicionaCategoria.Image = (Image)resources.GetObject("btn_AdicionaCategoria.Image");
            btn_AdicionaCategoria.Location = new Point(695, 73);
            btn_AdicionaCategoria.Name = "btn_AdicionaCategoria";
            btn_AdicionaCategoria.Size = new Size(47, 37);
            btn_AdicionaCategoria.TabIndex = 10;
            btn_AdicionaCategoria.UseVisualStyleBackColor = false;
            btn_AdicionaCategoria.Click += btn_AdicionaCategoria_Click;
            // 
            // btn_ConfirmaCadastro
            // 
            btn_ConfirmaCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ConfirmaCadastro.Image = (Image)resources.GetObject("btn_ConfirmaCadastro.Image");
            btn_ConfirmaCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ConfirmaCadastro.Location = new Point(327, 213);
            btn_ConfirmaCadastro.Name = "btn_ConfirmaCadastro";
            btn_ConfirmaCadastro.Size = new Size(127, 44);
            btn_ConfirmaCadastro.TabIndex = 9;
            btn_ConfirmaCadastro.Text = "Cadastrar";
            btn_ConfirmaCadastro.TextAlign = ContentAlignment.MiddleRight;
            btn_ConfirmaCadastro.UseVisualStyleBackColor = true;
            btn_ConfirmaCadastro.Click += btn_ConfirmaCadastro_Click;
            // 
            // cb_Categoria
            // 
            cb_Categoria.FormattingEnabled = true;
            cb_Categoria.Location = new Point(127, 78);
            cb_Categoria.Name = "cb_Categoria";
            cb_Categoria.Size = new Size(558, 29);
            cb_Categoria.TabIndex = 8;
            // 
            // txt_Preco
            // 
            txt_Preco.BorderStyle = BorderStyle.FixedSingle;
            txt_Preco.Location = new Point(127, 169);
            txt_Preco.Name = "txt_Preco";
            txt_Preco.Size = new Size(558, 29);
            txt_Preco.TabIndex = 7;
            // 
            // txt_Qtd
            // 
            txt_Qtd.BorderStyle = BorderStyle.FixedSingle;
            txt_Qtd.Location = new Point(127, 125);
            txt_Qtd.Name = "txt_Qtd";
            txt_Qtd.Size = new Size(558, 29);
            txt_Qtd.TabIndex = 6;
            // 
            // txt_Nome
            // 
            txt_Nome.BorderStyle = BorderStyle.FixedSingle;
            txt_Nome.Location = new Point(127, 36);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(558, 29);
            txt_Nome.TabIndex = 4;
            // 
            // lbl_Preco
            // 
            lbl_Preco.AutoSize = true;
            lbl_Preco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Preco.Location = new Point(11, 171);
            lbl_Preco.Name = "lbl_Preco";
            lbl_Preco.Size = new Size(56, 21);
            lbl_Preco.TabIndex = 3;
            lbl_Preco.Text = "Preço:";
            // 
            // lbl_Qtd
            // 
            lbl_Qtd.AutoSize = true;
            lbl_Qtd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Qtd.Location = new Point(11, 128);
            lbl_Qtd.Name = "lbl_Qtd";
            lbl_Qtd.Size = new Size(99, 21);
            lbl_Qtd.TabIndex = 2;
            lbl_Qtd.Text = "Quantidade:";
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Categoria.Location = new Point(11, 81);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(85, 21);
            lbl_Categoria.TabIndex = 1;
            lbl_Categoria.Text = "Categoria:";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nome.Location = new Point(11, 39);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(63, 21);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome: ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCadastrar);
            tabControl1.Controls.Add(tabBuscar);
            tabControl1.Controls.Add(tabAlterar);
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(100, 30);
            tabControl1.Location = new Point(-7, 147);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(811, 312);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Mercado Nova Machado";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabAlterar.ResumeLayout(false);
            tabAlterar.PerformLayout();
            tabBuscar.ResumeLayout(false);
            tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Produtos).EndInit();
            tabCadastrar.ResumeLayout(false);
            tabCadastrar.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private TabPage tabAlterar;
        private Button btn_ConfirmaAlteracao;
        private ComboBox cb_AlteraCategoria;
        private TextBox txt_AlteraPreco;
        private TextBox txt_AlteraQuantidade;
        private TextBox txt_AlteraNome;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TabPage tabBuscar;
        private DataGridView dg_Produtos;
        private Button btn_Alterar;
        private Button btn_RemoverProduto;
        private TextBox txt_Busca;
        private Label lbl_Produto;
        private TabPage tabCadastrar;
        private Button btn_AdicionaCategoria;
        private Button btn_ConfirmaCadastro;
        private ComboBox cb_Categoria;
        private TextBox txt_Preco;
        private TextBox txt_Qtd;
        private TextBox txt_Nome;
        private Label lbl_Preco;
        private Label lbl_Qtd;
        private Label lbl_Categoria;
        private Label lbl_Nome;
        private TabControl tabControl1;
        private Button button1;
    }
}