using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace VendaDeCestas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tb_nascimento_TextChanged(object sender, EventArgs e)
        {
            if (tb_nascimento.Text == "DD / MM / AAAA")
            {
                tb_nascimento.Text = "";
            }
        }

        private void tb_CEP_TextChanged(object sender, EventArgs e)
        {
            if (tb_CEP.Text == "DD / MM / AAAA")
            {
                tb_CEP.Text = "";
            }
        }

        private void cb_confirmacao_CheckedChanged(object sender, EventArgs e)
        {
            btn_pagamento.Enabled = cb_confirmacao.Checked;
        }

        private void btn_pagamento_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Texto = tb_nome.Text + " agora é so aguardar";
            form3.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
