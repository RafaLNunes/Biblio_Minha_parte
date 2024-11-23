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
    public partial class FrmUserADM : Form
    {
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();

        public FrmUserADM(ClUserModelo Model_User, ModeloAdm ModelADM)
        {
            this.ModelADM = ModelADM;
            this.Model_User = Model_User;
            InitializeComponent();
        }
    }
}
