using Aprendendo_MVC;
using Minha_Parte_Biblio.Controle;
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
        ClUsercontrole controle_User = new ClUsercontrole();
        ModeloAdm ModelADM = new ModeloAdm();

        int tipo = 0;
        public FrmADMSign(ClUserModelo User, int tipoabertura)
        {
            tipo = tipoabertura;
            this.Model_User = User;
            InitializeComponent();
        }

        private void FrmADMSign_Load(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                LbTipo.Text = "Acessando ADM";
            }

            if (tipo == 1)
            {
                LbTipo.Text = "Criando ADM";
            }

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
            DataTable dt_user = conexao.obterdados($"select * from Table_User where NameUser = '{Model_User.UserName}' AND Senha = '{Model_User.Password}'");
            //0 - vindo do log in

            if(tipo == 0)
            {
                LbTipo.Text = "Acessando ADM";

                DataTable dt_adm = conexao.obterdados($"Select * from Table_Adm where NameUser_Adm = '{txtUsername.Text}' AND Senha_Adm = '{txtpass.Text}' AND CFK_User = {dt_user.Rows[0]["CD_User"]}");
                if (dt_adm.Rows.Count > 0)
                {
                    //MessageBox.Show("deu, logado");


                    ModelADM.userADM = txtUsername.Text;
                    ModelADM.passADM = txtpass.Text;
                    ModelADM.index_clint = (int)dt_user.Rows[0]["CD_User"];
                    ModelADM.index_adm = (int)dt_adm.Rows[0]["CD_Adm"];
                    FrmMeanADM ADMCenter = new FrmMeanADM(ModelADM, Model_User, 0, "0");
                    this.Hide();
                    ADMCenter.ShowDialog();
                }
            }

            //1 - vindo do sign up

            if (tipo == 1)
            {
                LbTipo.Text = "Criando ADM";

                ModelADM.userADM = txtUsername.Text;
                ModelADM.passADM = txtpass.Text;
                ModelADM.index_clint = (int)dt_user.Rows[0]["CD_User"];

                if (controle_User.CreateADM(ModelADM) == true)
                {
                   //MessageBox.Show("Deu, criado");
                   DataTable dt_adms = conexao.obterdados($"Select * from Table_Adm where NameUser_Adm = '{txtUsername.Text}' AND Senha_Adm = '{txtpass.Text}' AND CFK_User = {dt_user.Rows[0]["CD_User"]}");

                    ModelADM.index_adm = (int)dt_adms.Rows[0]["CD_Adm"];
                    FrmMeanADM ADMCenter = new FrmMeanADM(ModelADM, Model_User, 0, "0");
                    this.Hide();
                    ADMCenter.ShowDialog();
                }
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
