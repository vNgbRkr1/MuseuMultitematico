using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museu_multitematico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comprar_Ingresso comprar_Ingresso  = new Comprar_Ingresso();
            comprar_Ingresso.ShowDialog();
            lbl_ingressos.Text = $"Ingressos vendidos: {Program.ingressos_vendidos}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Informacoes informacoes = new Informacoes();
            informacoes.ShowDialog();
        }
    }
}
