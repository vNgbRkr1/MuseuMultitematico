using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museu_multitematico
{
    public partial class Comprar_Ingresso : Form
    {
        public Comprar_Ingresso()
        {
            InitializeComponent();
        }
        public static class Globals
        {
            public const float valor_ingresso = 20;
        }
        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {
            if (txt_idade.Text == "")
            {
                return;
            }
            if (!Regex.IsMatch(txt_idade.Text, @"^\d+$"))            
            {
                System.Windows.Forms.MessageBox.Show("Digite uma idade válida");
                txt_idade.Text = "";
                return;
            };
            int idade = int.Parse(txt_idade.Text);
            if (idade <=16 && idade >2)
            {
                lbl_valor.Text = (Globals.valor_ingresso / 2).ToString();
            }
            else if (idade > 16 && idade <60)
            {
                lbl_valor.Text = (Globals.valor_ingresso).ToString();
            }
            else 
            {
                lbl_valor.Text = "Isento";
            }
        }

        private void lbl_valor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show($"###############################\n\n Comprovante de Compra\n\n Você adquiriu um ingresso para o museu\n\n Nome: {txt_nome.Text}\n E-mail: {textBox1.Text}\n Valor: {lbl_valor.Text}\n\n###############################");
            Program.ingressos_vendidos += 1;
            this.Close();
            
        }

        private void Comprar_Ingresso_Load(object sender, EventArgs e)
        {

        }
    }
}
