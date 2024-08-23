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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Minha_Parte_Biblio
{
    public partial class FrmMean : Form
    {
        ClUserModelo Modelo_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();

        DataTable DT_User = new DataTable();

        public FrmMean(ClUserModelo user)
        {
            this.Modelo_User = user;
            InitializeComponent();
        }

        private void FrmMean_Load(object sender, EventArgs e)
        {
            DT_User = conexao.obterdados($"select * from Table_User where ID_Aluno =" + "'" + Modelo_User.ID_Aluno + "'");
            Modelo_User.ID_Aluno = DT_User.Rows[0]["ID_Aluno"].ToString();
            Modelo_User.NomeComp = DT_User.Rows[0]["Nome_Completo"].ToString();
            Modelo_User.UserName = DT_User.Rows[0]["NameUser"].ToString();
            Modelo_User.Password = DT_User.Rows[0]["Senha"].ToString();
            Modelo_User.Caminho_FT = DT_User.Rows[0]["IMG_User"].ToString();
            Modelo_User.Index_Cargo = Convert.ToInt32(DT_User.Rows[0]["CFK_Unidade"]);
            Modelo_User.Index_Ano = Convert.ToInt32(DT_User.Rows[0]["CFK_Unidade"]);
            Modelo_User.Index_Unidade = Convert.ToInt32(DT_User.Rows[0]["CFK_Unidade"]);


            PbUser.Image = Image.FromFile(Modelo_User.Caminho_FT);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbUser_Click(object sender, EventArgs e)
        {

        }

        private void LbCatalogo_Click(object sender, EventArgs e)
        {

        }

        private void LbHistorico_Click(object sender, EventArgs e)
        {

        }

        private void LbReserv_Click(object sender, EventArgs e)
        {

        }

        private void LbPerguntas_Click(object sender, EventArgs e)
        {

        }

        private void LbNos_Click(object sender, EventArgs e)
        {

        }
    }
}
