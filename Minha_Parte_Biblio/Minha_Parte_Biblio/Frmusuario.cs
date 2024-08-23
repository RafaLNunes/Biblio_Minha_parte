using Aprendendo_MVC;
using Minha_Parte_Biblio.Modelo;
using System.Data;

namespace usuario
{
    public partial class Frmusuario : Form
    {

        // // // // // // VOU POR BNT REAIS SEM PAINEL, 
        int codigo;

        ClConectection conexao = new ClConectection();
        ClUserModelo Modelo_User = new ClUserModelo();
        public Frmusuario(ClUserModelo Usuario)
        {


            Modelo_User = Usuario;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fotousuario_Click(object sender, EventArgs e)
        {

        }

        private void Frmusuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vhrusuario1_Click(object sender, EventArgs e)
        {
            FrmhistLivros frmhistLivros = new FrmhistLivros();
            this.Hide();
            frmhistLivros.ShowDialog();
        }

        private void Frmusuario_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            string username;
            dt= conexao.obterdados("select*from Table_User where ID_Aluno= "+ Modelo_User.ID_Aluno);
            username= dt.Rows[0][1].ToString();

            cbcargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            cbcargo.DisplayMember = "Cargo";
            cbcargo.ValueMember = "CD_Cargo";

            cbanoescolar.DataSource = conexao.obterdados("select * from Table_Ano_Escolar");
            cbanoescolar.DisplayMember = "Ano_Escolar";
            cbanoescolar.ValueMember = "CD_Ano_Escolar";

            txtusername.Text = username;
            
           
            
        }
    }
}
