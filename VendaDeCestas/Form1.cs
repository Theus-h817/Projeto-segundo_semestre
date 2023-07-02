using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace VendaDeCestas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            check_produtos.Enabled = true;
            check_produtos.BackColor = SystemColors.Window;
            check_produtos.ForeColor = SystemColors.WindowText;
        }

        int validador = 0;

        string alternativa1 = "Esta opção é a mais acessivel e vem  com os seguintes produtos: " +
        "\n\nSucos, cereais, bolachas e chocolates.";

        string alternativa2 = "Esta opção é a mais acessivel e vem  com os seguintes produtos: " +
        "\n\nSucos, cereais, bolachas, frutas, salame e vinho.";

        string alternativa3 = "Esta opção é a mais acessivel e vem  com os seguintes produtos: " +
        "\n\nSucos, cereais, biscoitos, frutas, salame, vinho e ursinho de pelúcia.";

        private void btn_1_Click(object sender, EventArgs e)
        {
            check_produtos.Enabled = false;
            check_produtos.BackColor = SystemColors.ControlLight;
            check_produtos.ForeColor = SystemColors.GrayText;

            MessageBox.Show(alternativa1, "Opção 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            validador = 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            check_produtos.Enabled = false;
            check_produtos.BackColor = SystemColors.ControlLight;
            check_produtos.ForeColor = SystemColors.GrayText;

            MessageBox.Show(alternativa2, "Opção 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            validador = 1;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            check_produtos.Enabled = false;
            check_produtos.BackColor = SystemColors.ControlLight;
            check_produtos.ForeColor = SystemColors.GrayText;
            MessageBox.Show(alternativa3, "Opção 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            validador = 1;


        }

        private void btn_form_2_Click(object sender, EventArgs e)
        {
            if (validador == 1)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                if (check_produtos.CheckedItems.Count > 0 || validador != 0)
                {
                    string mensagem = "Itens selecionados:\n";
                    foreach (var item in check_produtos.CheckedItems)
                    {
                        mensagem += "- " + item.ToString() + "\n";
                    }
                    MessageBox.Show(mensagem, "Opção personalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    // Mostre uma mensagem de erro se nenhum item estiver marcado
                    MessageBox.Show("Selecione pelo menos um item.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}