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
    public partial class FrmBoasVindas : Form
    {
        ClUserModelo Modelo_User = new ClUserModelo();
        public FrmBoasVindas(ClUserModelo Usuario)
        {
            Modelo_User = Usuario;
            InitializeComponent();
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {
            String Cam_origin = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(Modelo_User.Caminho_FT));
            PbImage_User.Image = Image.FromFile(Cam_origin);
            LbNomeComp.Text = Modelo_User.NomeComp.ToString();
        }

        private void FrmBoasVindas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PbImage_User_Click(object sender, EventArgs e)
        {

        }

        private void BntViajar_Click(object sender, EventArgs e)
        {
            //FrmUsuario
        }
    }
}
