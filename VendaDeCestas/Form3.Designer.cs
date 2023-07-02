namespace VendaDeCestas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label8 = new Label();
            btn_retorno = new Button();
            btn_finalizar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.Black;
            label8.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(-3, -2);
            label8.Name = "label8";
            label8.Size = new Size(322, 45);
            label8.TabIndex = 8;
            label8.Text = "Cestas Express";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_retorno
            // 
            btn_retorno.Location = new Point(100, 188);
            btn_retorno.Name = "btn_retorno";
            btn_retorno.Size = new Size(100, 23);
            btn_retorno.TabIndex = 11;
            btn_retorno.Text = "Retornar";
            btn_retorno.UseVisualStyleBackColor = true;
            btn_retorno.Click += btn_retorno_Click;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Location = new Point(207, 188);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(100, 23);
            btn_finalizar.TabIndex = 12;
            btn_finalizar.Text = "Finalizar";
            btn_finalizar.UseVisualStyleBackColor = true;
            btn_finalizar.Click += btn_finalizar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 59);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 14;
            label1.Text = "Número do cartão";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(35, 23);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 114);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 16;
            label2.Text = "CVV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "Validade";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 23);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(317, 246);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btn_finalizar);
            Controls.Add(btn_retorno);
            Controls.Add(label8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Insira seus dados de cobrança";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button btn_retorno;
        private Button btn_finalizar;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
    }
}