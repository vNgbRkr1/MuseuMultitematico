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
    public partial class informacoes4 : Form
    {
        public informacoes4()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes3 informacoes3 = new informacoes3();
            informacoes3.ShowDialog();
        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes5 informacoes5 = new informacoes5();
            informacoes5.ShowDialog();
        }
    }
}
