using Aprendendo_MVC;
using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using System.Data;

namespace usuario
{
    public partial class Frmusuario : Form
    {

        // // // // // // VOU POR BNT REAIS SEM PAINEL, 
        int codigo;

        ClConectection conexao = new ClConectection();
        DataTable dt = new DataTable();
        ClUserModelo Modelo_User = new ClUserModelo();
        ClUserModelo Modelo_User_New = new ClUserModelo();

        string ID_Aluno;
        string nameuser;
        string nomecompleto;
        string senha;
        string IMG_User;
        int CFK_Ano;
        int CFK_Cargo;
        int CFK_Unidade;

        public Frmusuario(ClUserModelo Usuario)
        {


            Modelo_User = Usuario;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

            dt = conexao.obterdados("select*from Table_User where ID_Aluno= " + Modelo_User.ID_Aluno);

           

            Modelo_User.CD_User = Convert.ToInt32(dt.Rows[0]["CD_User"]);

            string username;
            
            username = dt.Rows[0]["NameUser"].ToString();

            cbcargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            cbcargo.DisplayMember = "Cargo";
            cbcargo.ValueMember = "CD_Cargo";

            cbanoescolar.DataSource = conexao.obterdados("select * from Table_Ano_Escolar");
            cbanoescolar.DisplayMember = "Ano_Escolar";
            cbanoescolar.ValueMember = "CD_Ano_Escolar";

            cbunidade.DataSource = conexao.obterdados("select * from Table_Unidade");
            cbunidade.DisplayMember = "Nome_Unidade";
            cbunidade.ValueMember = "CD_Unidade";

            txtusername.Text = username;

            nameuser = dt.Rows[0]["NameUser"].ToString();
            ID_Aluno = dt.Rows[0]["ID_Aluno"].ToString();
            nomecompleto = dt.Rows[0]["Nome_Completo"].ToString();
            senha = dt.Rows[0]["Senha"].ToString();
            IMG_User = dt.Rows[0]["IMG_User"].ToString();
            CFK_Ano = Convert.ToInt32(dt.Rows[0]["CFK_Ano"]);
            CFK_Cargo = Convert.ToInt32(dt.Rows[0]["CFK_Cargo"]);
            CFK_Unidade = Convert.ToInt32(dt.Rows[0]["CFK_Unidade"]);


            txtusername.Text = nameuser;
            txtidaluno.Text = ID_Aluno;
            txtnomecompleto.Text = nomecompleto;
            txtsenha.Text = senha;
            fotousuario.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", dt.Rows[0]["IMG_User"].ToString()));

            cbanoescolar.SelectedIndex = CFK_Ano - 1;

            cbcargo.SelectedIndex = CFK_Cargo - 1;
            cbunidade.SelectedIndex = CFK_Unidade - 1;


            MessageBox.Show("Cargo"+cbcargo.FindStringExact(cbcargo.Text).ToString()); ;
            MessageBox.Show("ANO"+cbanoescolar.FindStringExact(cbanoescolar.Text).ToString()); ;
            MessageBox.Show("Unit"+cbunidade.FindStringExact(cbunidade.Text).ToString());


        }

        private void btnsalvaralteracao_Click(object sender, EventArgs e)
        {

            Modelo_User.ID_Aluno = txtidaluno.Text;
            Modelo_User.NomeComp = txtnomecompleto.Text;
            Modelo_User.UserName = txtusername.Text;
            Modelo_User.Password = txtsenha.Text;



            Modelo_User.Index_Cargo = cbcargo.FindStringExact(cbcargo.Text)+1;
            Modelo_User.Index_Ano = cbanoescolar.FindStringExact(cbanoescolar.Text)+1;
            Modelo_User.Index_Unidade = cbunidade.FindStringExact(cbunidade.Text)+1;
            ClUsercontrole clUsercontrole = new ClUsercontrole();
            if (clUsercontrole.editar(Modelo_User) == true)
            {
                MessageBox.Show("Atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar os dados");
            }

        }
    }
}
