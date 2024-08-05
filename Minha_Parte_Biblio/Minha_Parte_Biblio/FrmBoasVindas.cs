using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class FrmBoasVindas : Form
    {
        public FrmBoasVindas(String NomeComp)
        {
            InitializeComponent();
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {

        }

        private void FrmBoasVindas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
