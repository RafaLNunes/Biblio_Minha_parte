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

namespace usuario
{
    public partial class FrmCatalogo : Form
    {
        ClUserModelo Modelo_User = new ClUserModelo();
        public FrmCatalogo(ClUserModelo User)
        {
            this.Modelo_User = User;
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
