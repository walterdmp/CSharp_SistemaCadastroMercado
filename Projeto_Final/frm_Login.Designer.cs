namespace Projeto_Final
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            btn_Login = new Button();
            txt_SenhaLogin = new TextBox();
            txt_UserLogin = new TextBox();
            lbl_Preco = new Label();
            lbl_Qtd = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.WindowText;
            btn_Login.Image = (Image)resources.GetObject("btn_Login.Image");
            btn_Login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Login.Location = new Point(268, 239);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(113, 44);
            btn_Login.TabIndex = 14;
            btn_Login.Text = "Acessar";
            btn_Login.TextAlign = ContentAlignment.MiddleRight;
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click_1;
            // 
            // txt_SenhaLogin
            // 
            txt_SenhaLogin.BorderStyle = BorderStyle.FixedSingle;
            txt_SenhaLogin.Location = new Point(210, 179);
            txt_SenhaLogin.Name = "txt_SenhaLogin";
            txt_SenhaLogin.PasswordChar = '*';
            txt_SenhaLogin.Size = new Size(236, 23);
            txt_SenhaLogin.TabIndex = 13;
            // 
            // txt_UserLogin
            // 
            txt_UserLogin.BorderStyle = BorderStyle.FixedSingle;
            txt_UserLogin.Location = new Point(210, 141);
            txt_UserLogin.Name = "txt_UserLogin";
            txt_UserLogin.Size = new Size(236, 23);
            txt_UserLogin.TabIndex = 12;
            // 
            // lbl_Preco
            // 
            lbl_Preco.AutoSize = true;
            lbl_Preco.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Preco.ForeColor = SystemColors.WindowText;
            lbl_Preco.Location = new Point(107, 177);
            lbl_Preco.Name = "lbl_Preco";
            lbl_Preco.Size = new Size(71, 25);
            lbl_Preco.TabIndex = 11;
            lbl_Preco.Text = "Senha:";
            // 
            // lbl_Qtd
            // 
            lbl_Qtd.AutoSize = true;
            lbl_Qtd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Qtd.ForeColor = SystemColors.WindowText;
            lbl_Qtd.Location = new Point(107, 139);
            lbl_Qtd.Name = "lbl_Qtd";
            lbl_Qtd.Size = new Size(86, 25);
            lbl_Qtd.TabIndex = 10;
            lbl_Qtd.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.RoyalBlue;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(582, -1);
            button1.Name = "button1";
            button1.Size = new Size(47, 32);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(628, 319);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Login);
            Controls.Add(txt_SenhaLogin);
            Controls.Add(txt_UserLogin);
            Controls.Add(lbl_Preco);
            Controls.Add(lbl_Qtd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Login";
            Load += frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private TextBox txt_SenhaLogin;
        private TextBox txt_UserLogin;
        private Label lbl_Preco;
        private Label lbl_Qtd;
        private PictureBox pictureBox1;
        private Button button1;
    }
}