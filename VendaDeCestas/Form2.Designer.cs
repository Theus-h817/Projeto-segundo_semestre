namespace VendaDeCestas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_nome = new TextBox();
            textBox2 = new TextBox();
            tb_nascimento = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            tb_CEP = new TextBox();
            label8 = new Label();
            cb_confirmacao = new CheckBox();
            btn_pagamento = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 42);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(168, 92);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(168, 142);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 2;
            label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(168, 192);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(168, 293);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 4;
            label5.Text = "Nº:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(168, 242);
            label6.Name = "label6";
            label6.Size = new Size(147, 21);
            label6.TabIndex = 5;
            label6.Text = "Ponto de referência:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(275, 293);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 6;
            label7.Text = "CEP:";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(168, 66);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(215, 23);
            tb_nome.TabIndex = 8;
            tb_nome.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 23);
            textBox2.TabIndex = 9;
            // 
            // tb_nascimento
            // 
            tb_nascimento.ForeColor = SystemColors.WindowFrame;
            tb_nascimento.Location = new Point(168, 166);
            tb_nascimento.Name = "tb_nascimento";
            tb_nascimento.PlaceholderText = "DD/MM/AAAA";
            tb_nascimento.Size = new Size(147, 23);
            tb_nascimento.TabIndex = 10;
            tb_nascimento.TextChanged += tb_nascimento_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(56, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(168, 267);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 23);
            textBox6.TabIndex = 13;
            // 
            // tb_CEP
            // 
            tb_CEP.ForeColor = SystemColors.WindowFrame;
            tb_CEP.Location = new Point(275, 317);
            tb_CEP.Name = "tb_CEP";
            tb_CEP.PlaceholderText = "______-___";
            tb_CEP.Size = new Size(108, 23);
            tb_CEP.TabIndex = 14;
            tb_CEP.TextChanged += tb_CEP_TextChanged;
            // 
            // label8
            // 
            label8.BackColor = Color.Black;
            label8.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(-4, -3);
            label8.Name = "label8";
            label8.Size = new Size(400, 45);
            label8.TabIndex = 7;
            label8.Text = "Cestas Express";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cb_confirmacao
            // 
            cb_confirmacao.BackColor = Color.Transparent;
            cb_confirmacao.Location = new Point(168, 346);
            cb_confirmacao.Name = "cb_confirmacao";
            cb_confirmacao.Size = new Size(215, 24);
            cb_confirmacao.TabIndex = 15;
            cb_confirmacao.Text = "Aceito os termos de uso de dados ";
            cb_confirmacao.UseVisualStyleBackColor = false;
            cb_confirmacao.CheckedChanged += cb_confirmacao_CheckedChanged;
            // 
            // btn_pagamento
            // 
            btn_pagamento.Enabled = false;
            btn_pagamento.Location = new Point(289, 376);
            btn_pagamento.Name = "btn_pagamento";
            btn_pagamento.Size = new Size(94, 23);
            btn_pagamento.TabIndex = 16;
            btn_pagamento.Text = "Pagamento";
            btn_pagamento.UseVisualStyleBackColor = true;
            btn_pagamento.Click += btn_pagamento_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(168, 376);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(94, 23);
            btn_voltar.TabIndex = 17;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(393, 408);
            Controls.Add(btn_voltar);
            Controls.Add(btn_pagamento);
            Controls.Add(cb_confirmacao);
            Controls.Add(tb_CEP);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(tb_nascimento);
            Controls.Add(textBox2);
            Controls.Add(tb_nome);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Insira seus dados";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_nome;
        private TextBox textBox2;
        private TextBox tb_nascimento;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox tb_CEP;
        private Label label8;
        private CheckBox cb_confirmacao;
        private Button btn_pagamento;
        private Button btn_voltar;
    }
}