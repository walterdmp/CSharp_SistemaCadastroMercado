namespace Projeto_Final
{
    partial class frm_AddCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddCategoria));
            panel1 = new Panel();
            btn_fechar = new Button();
            label1 = new Label();
            btn_AddCategoria = new Button();
            txt_AddCategoria = new TextBox();
            lbl_Categoria = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_fechar);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 46);
            panel1.TabIndex = 0;
            // 
            // btn_fechar
            // 
            btn_fechar.BackgroundImageLayout = ImageLayout.None;
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.ForeColor = Color.RoyalBlue;
            btn_fechar.Image = (Image)resources.GetObject("btn_fechar.Image");
            btn_fechar.Location = new Point(535, 0);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(47, 32);
            btn_fechar.TabIndex = 4;
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 64);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
            label1.TabIndex = 1;
            label1.Text = "Adicionar Categoria";
            // 
            // btn_AddCategoria
            // 
            btn_AddCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddCategoria.Image = (Image)resources.GetObject("btn_AddCategoria.Image");
            btn_AddCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddCategoria.Location = new Point(222, 177);
            btn_AddCategoria.Name = "btn_AddCategoria";
            btn_AddCategoria.Size = new Size(127, 44);
            btn_AddCategoria.TabIndex = 10;
            btn_AddCategoria.Text = "Cadastrar";
            btn_AddCategoria.TextAlign = ContentAlignment.MiddleRight;
            btn_AddCategoria.UseVisualStyleBackColor = true;
            btn_AddCategoria.Click += btn_AddCategoria_Click;
            // 
            // txt_AddCategoria
            // 
            txt_AddCategoria.BorderStyle = BorderStyle.FixedSingle;
            txt_AddCategoria.Location = new Point(143, 123);
            txt_AddCategoria.Name = "txt_AddCategoria";
            txt_AddCategoria.Size = new Size(365, 23);
            txt_AddCategoria.TabIndex = 11;
            // 
            // lbl_Categoria
            // 
            lbl_Categoria.AutoSize = true;
            lbl_Categoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Categoria.Location = new Point(37, 125);
            lbl_Categoria.Name = "lbl_Categoria";
            lbl_Categoria.Size = new Size(85, 21);
            lbl_Categoria.TabIndex = 12;
            lbl_Categoria.Text = "Categoria:";
            // 
            // frm_AddCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(575, 246);
            Controls.Add(lbl_Categoria);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txt_AddCategoria);
            Controls.Add(btn_AddCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_AddCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_AddCategoria";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_AddCategoria;
        private TextBox txt_AddCategoria;
        private Label lbl_Categoria;
        private Button btn_fechar;
    }
}