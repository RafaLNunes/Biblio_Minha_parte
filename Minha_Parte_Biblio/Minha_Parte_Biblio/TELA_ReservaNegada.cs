using Aprendendo_MVC;
using Library_Project.modelo;
using Minha_Parte_Biblio;
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
using usuario;

namespace Library_Project
{
    public partial class TELA_ReservaNegada : Form
    {
        ModeloLivro modeloLivro = new ModeloLivro();
        ClUsercontrole user = new ClUsercontrole();
        ModeloLivro ModeloLivro = new ModeloLivro();
        ClUserModelo clUser = new ClUserModelo();
        ClUserModelo Modelo_User = new ClUserModelo();
        ModeloUnidade Modelo_Unidade = new ModeloUnidade();

        ClConectection cn = new ClConectection();
        string codi = "";
        public TELA_ReservaNegada(ClUserModelo user)
        {
            codi = user.ID_Aluno;
            InitializeComponent();
            DataTable DT_User = cn.obterdados("select * from Table_User where ID_Aluno = '" + codi + "'");
            Modelo_User.CD_User = (int)DT_User.Rows[0]["CD_User"];
            Modelo_User.ID_Aluno = DT_User.Rows[0]["ID_Aluno"].ToString();
            Modelo_User.UserName = DT_User.Rows[0]["NameUser"].ToString();
            Modelo_User.Index_Unidade = (int)DT_User.Rows[0]["CFK_Unidade"];
            Modelo_User.Index_Ano = (int)DT_User.Rows[0]["CFK_Ano"];
            Modelo_User.Index_Cargo = (int)DT_User.Rows[0]["CFK_Cargo"];

            label1.Text = DT_User.Rows[0]["ID_Aluno"].ToString();
            label2.Text = DT_User.Rows[0]["NameUser"].ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TELA_ReservaNegada_Load(object sender, EventArgs e)
        {
            DataTable dados_user = new DataTable();
            dados_user = cn.obterdados("Select * from Table_User where ID_Aluno = '" + codi + "'");

            label1.Text = dados_user.Rows[0]["ID_Aluno"].ToString();
            label2.Text = dados_user.Rows[0]["NameUser"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMeanC info_livro = new FrmMeanC(Modelo_User, 2);
            this.Hide();
            info_livro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMeanC info_livro = new FrmMeanC(Modelo_User, 2);
            this.Hide();
            info_livro.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
