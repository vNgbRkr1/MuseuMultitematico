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
    public partial class informacoes2 : Form
    {
        public informacoes2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes3 informacoes3 = new informacoes3();
            informacoes3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informacoes informacoes = new Informacoes();
            informacoes.ShowDialog();
        }
    }
}
