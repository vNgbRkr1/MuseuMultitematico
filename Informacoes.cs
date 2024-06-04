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
    public partial class Informacoes : Form
    {
        public Informacoes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes2 informacoes2 = new informacoes2();
            informacoes2.ShowDialog();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
