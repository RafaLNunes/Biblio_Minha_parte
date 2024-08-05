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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            PbImage_Perfil.Visible = false;
        }

        private void Image_Visivel_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '•')
            {
                txtPassWord.PasswordChar = '\0';
                Image_Visivel.Image = CbVisivel_Senha.Images[1];
            }
            else if (txtPassWord.PasswordChar == '\0')
            {
                txtPassWord.PasswordChar = '•';
                Image_Visivel.Image = CbVisivel_Senha.Images[0];
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[0];
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[1];
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[0];
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[1];
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[0];
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[1];
        }

        private void txtNomeComp_Enter(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[0];
        }

        private void txtNomeComp_Leave(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[1];
        }

        private void LbLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMLogIn fRMLogIn = new FRMLogIn();
            this.Hide();
            fRMLogIn.ShowDialog();
        }

        private void pictureBoxCircle1_Click(object sender, EventArgs e)
        {

        }


    }
}
