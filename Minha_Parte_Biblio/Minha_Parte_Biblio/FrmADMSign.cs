using Aprendendo_MVC;
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
        ClConectection conexao = new ClConectection();
        public FrmADMSign(ClUserModelo User)
        {
            this.Model_User = User;
            InitializeComponent();
        }

        private void FrmADMSign_Load(object sender, EventArgs e)
        {
            //define aparencias dos itens no design
            txtUsername.ForeColor = Color.FromArgb(164, 186, 178);//controla a cor abaixo das textbox
            txtUsername.Text = "Entre com o seu NameUser"; //cria um place holder para o user
            txtpass.ForeColor = Color.FromArgb(164, 186, 178); //controla a cor abaixo das textbox
            txtpass.Text = "Entre com a sua Senha"; //cria um place holder para a senha
        }

        private void bntCircle2_Click(object sender, EventArgs e)
        {
            FrmLogIn log = new FrmLogIn();
            this.Hide();
            log.ShowDialog();
        }

        private void bntCircle1_Click(object sender, EventArgs e)
        {
            if (conexao.LogInADM(txtUsername, txtpass, "SELECT * FROM Table_Adm WHERE NameUser _Adm = @nameuser AND Senha_Adm = @password") >=1) 
            { 


            }

        
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            //define as infos ao interagir com a textbox user

            txtUsername.ForeColor = Color.White; // redefine a cor da letra
            txtUsername.Text = ""; // limpa a por via das duvidas (Pode dar erro)
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            txtpass.ForeColor = Color.White; // redefine a cor da letra
            txtpass.Text = ""; // limpa a por via das duvidas (Pode dar erro)
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {

        }
    }
}
