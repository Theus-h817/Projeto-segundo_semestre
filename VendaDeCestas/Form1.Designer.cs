namespace VendaDeCestas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btn_1 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_personal = new Button();
            check_produtos = new CheckedListBox();
            btn_form_2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Font = new Font("Baskerville Old Face", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(400, 56);
            label1.TabIndex = 0;
            label1.Text = "Cestas Express";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Baskerville Old Face", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-2, 373);
            label2.Name = "label2";
            label2.Size = new Size(400, 22);
            label2.TabIndex = 1;
            label2.Text = "© Cestas Expess ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_1
            // 
            btn_1.ForeColor = SystemColors.ActiveCaptionText;
            btn_1.Location = new Point(156, 91);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(75, 23);
            btn_1.TabIndex = 2;
            btn_1.Text = "Cesta 1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // btn_3
            // 
            btn_3.ForeColor = SystemColors.ActiveCaptionText;
            btn_3.Location = new Point(156, 247);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(75, 23);
            btn_3.TabIndex = 3;
            btn_3.Text = "Cesta 3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.ForeColor = SystemColors.ActiveCaptionText;
            btn_2.Location = new Point(156, 168);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(75, 23);
            btn_2.TabIndex = 4;
            btn_2.Text = "Cesta 2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_personal
            // 
            btn_personal.ForeColor = SystemColors.ActiveCaptionText;
            btn_personal.Location = new Point(156, 309);
            btn_personal.Name = "btn_personal";
            btn_personal.Size = new Size(227, 23);
            btn_personal.TabIndex = 5;
            btn_personal.Text = "Personalize a sua cesta";
            btn_personal.UseVisualStyleBackColor = true;
            btn_personal.Click += btn_personal_Click;
            // 
            // check_produtos
            // 
            check_produtos.BackColor = SystemColors.ControlLight;
            check_produtos.Enabled = false;
            check_produtos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            check_produtos.ForeColor = SystemColors.GrayText;
            check_produtos.FormattingEnabled = true;
            check_produtos.Items.AddRange(new object[] { "Biscoitos", "Frutas", "Vinhos", "Sucos", "Salame", "Cereais", "Baguete", "Bolachas", "Chocolates", "Doces variados", "Ursinho de pelúcia" });
            check_produtos.Location = new Point(246, 72);
            check_produtos.Name = "check_produtos";
            check_produtos.RightToLeft = RightToLeft.No;
            check_produtos.Size = new Size(137, 220);
            check_produtos.TabIndex = 6;
            // 
            // btn_form_2
            // 
            btn_form_2.ForeColor = Color.Black;
            btn_form_2.Location = new Point(156, 347);
            btn_form_2.Name = "btn_form_2";
            btn_form_2.Size = new Size(227, 23);
            btn_form_2.TabIndex = 8;
            btn_form_2.Text = "Finalizar a compra";
            btn_form_2.UseVisualStyleBackColor = true;
            btn_form_2.Click += btn_form_2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(395, 397);
            Controls.Add(btn_form_2);
            Controls.Add(check_produtos);
            Controls.Add(btn_personal);
            Controls.Add(btn_2);
            Controls.Add(btn_3);
            Controls.Add(btn_1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Escolha a sua cesta ou monte uma";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_1;
        private Button btn_3;
        private Button btn_2;
        private Button btn_personal;
        private CheckedListBox check_produtos;
        private Button btn_form_2;
    }
}