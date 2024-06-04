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
    public partial class informacoes5 : Form
    {
        public informacoes5()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            informacoes4 informacoes4 = new informacoes4();
            informacoes4.ShowDialog();
        }
    }
}
