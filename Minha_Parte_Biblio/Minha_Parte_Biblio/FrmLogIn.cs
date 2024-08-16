using Aprendendo_MVC;
using Minha_Parte_Biblio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class FRMLogIn : Form
    {

        ClConectection conexao = new ClConectection();
        ClUserModelo Modelo_User = new ClUserModelo();
        public FRMLogIn()
        {
            InitializeComponent();
        }

        private void FRMLogIn_Load(object sender, EventArgs e)
        {
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92);
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);
            txtUser.ForeColor = Color.FromArgb(164, 186, 178);
            txtUser.Text = "Entre com o seu NameUser";
            txtPassWord.ForeColor = Color.FromArgb(164, 186, 178);
            txtPassWord.Text = "Entre com a sua Senha";
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

        private void txtUser_Enter(object sender, EventArgs e)
        {
            Image_User.Image = Cbimage_User.Images[0];
            PnBarUser.BackColor = Color.FromArgb(9, 90, 162);
            txtUser.ForeColor = Color.Black;
            txtUser.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            Image_User.Image = Cbimage_User.Images[1];
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92);
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            Image_PassWord.Image = Cbimage_PassWord.Images[0];
            PnBarPass.BackColor = Color.FromArgb(9, 90, 162);
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.Text = "";

        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            Image_PassWord.Image = Cbimage_PassWord.Images[1];
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);
        }

        private void LbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp signUpForm = new FrmSignUp();
            this.Hide();
            signUpForm.ShowDialog();
        }

        private void BntLogIn_Click(object sender, EventArgs e)
        {

            Modelo_User.UserName = txtUser.Text;
            Modelo_User.Password = txtPassWord.Text;

            DataTable DT_logIn = conexao.LogIn(Modelo_User);

            Modelo_User.ID_Aluno = DT_logIn.Rows[0]["ID_Aluno"].ToString();

            MessageBox.Show($"ID Logado: {DT_logIn.Rows[0]["ID_Aluno"].ToString()}\nUser Name: {DT_logIn.Rows[0]["NameUser"].ToString()}");

            if (Convert.ToInt32(DT_logIn.Rows[0][0]) > 0)
            {
                this.Hide();
                FrmBoasVindas Boa_Vinda = new FrmBoasVindas(Modelo_User);
                MessageBox.Show($"Seja bem vindo {DT_logIn.Rows[0]["Nome_Completo"].ToString()}");
                Boa_Vinda.ShowDialog();
            }
        }
    }
}
