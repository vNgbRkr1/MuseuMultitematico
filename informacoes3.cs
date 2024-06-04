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
    public partial class informacoes3 : Form
    {
        public informacoes3()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes2 informacoes2 = new informacoes2();
            informacoes2.ShowDialog();
        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes4 informacoes4 = new informacoes4();
            informacoes4.ShowDialog();
        }
    }
}
