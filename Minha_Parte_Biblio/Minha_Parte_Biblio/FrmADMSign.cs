using Minha_Parte_Biblio.Modelo;
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
    public partial class FrmADMSign : Form
    {
        ClUserModelo Model_User = new ClUserModelo();
        public FrmADMSign(ClUserModelo User)
        {
            this.Model_User = User;
            InitializeComponent();
        }

        private void FrmADMSign_Load(object sender, EventArgs e)
        {

        }
    }
}
