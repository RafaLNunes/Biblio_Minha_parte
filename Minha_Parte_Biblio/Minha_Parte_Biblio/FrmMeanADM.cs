using Aprendendo_MVC;
using Library_Project.modelo;
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

namespace Minha_Parte_Biblio
{
    public partial class FrmMeanADM : Form
    {
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();

        int Pagina_Abertura = 0;
        String extra_item = "";

        public FrmMeanADM(ModeloAdm admmodel, ClUserModelo Model_User, int pagina, String extra)
        {
            ModelADM = admmodel;
            this.Model_User = Model_User;
            Pagina_Abertura = pagina;
            extra_item = extra;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selctColor()
        {
            switch (Pagina_Abertura)
            {
                case 0:
                    //0 - MENU
                    BntMenu.BackColor = Color.FromArgb(9, 90, 59);
                    BntUsers.BackColor = Color.FromArgb(9, 90, 162);
                    BntReserv.BackColor = Color.FromArgb(9, 90, 162);
                    BntBooks.BackColor = Color.FromArgb(9, 90, 162);
                    break;
                case 1:
                    //1 - User
                    BntMenu.BackColor = Color.FromArgb(9, 90, 162);
                    BntUsers.BackColor = Color.FromArgb(9, 90, 59);
                    BntReserv.BackColor = Color.FromArgb(9, 90, 162);
                    BntBooks.BackColor = Color.FromArgb(9, 90, 162);
                    break;
                case 2:
                    //2 - Reserv
                    BntMenu.BackColor = Color.FromArgb(9, 90, 162);
                    BntUsers.BackColor = Color.FromArgb(9, 90, 162);
                    BntReserv.BackColor = Color.FromArgb(9, 90, 59);
                    BntBooks.BackColor = Color.FromArgb(9, 90, 162);
                    break;
                case 3:
                    //3 - Livro
                    BntMenu.BackColor = Color.FromArgb(9, 90, 162);
                    BntUsers.BackColor = Color.FromArgb(9, 90, 162);
                    BntReserv.BackColor = Color.FromArgb(9, 90, 162);
                    BntBooks.BackColor = Color.FromArgb(9, 90, 59);
                    break;
                default:
                    //Outras situações

                    break;
            }
        }

        private void FrmMeanADM_Load(object sender, EventArgs e)
        {
            //84; 21; 38 - clicado
            UserAdm.Text = ModelADM.userADM.ToString();
            UserClint.Text = Model_User.UserName;

            selctColor();

            DataTable dt_user = conexao.obterdados($"select * from Table_User where CD_User = {Model_User.CD_User}");

            String imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", Path.GetFileName(Model_User.Caminho_FT));

            if (File.Exists(imagePath))
            {
                var img = Image.FromFile(imagePath);
                PbcUser.Image = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
                img.Dispose();
            }

            this.IsMdiContainer = true;

            switch (Pagina_Abertura)
            {
                case 0:
                    //0 - MENU
                    FPnContenedor.Controls.Clear();
                    break;
                case 1:
                    //1 - User
                    FrmUserADM Frmuser = new FrmUserADM(Model_User, ModelADM);
                    Frmuser.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(Frmuser);
                    Frmuser.Show();
                    break;
                case 2:
                    //2 - Reserv
                    FrmReservADM reserv = new FrmReservADM(Model_User, ModelADM);
                    reserv.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(reserv);
                    reserv.Show();
                    break;
                case 3:
                    //3 - Livro
                    FrmLivrosADM booksview = new FrmLivrosADM(Model_User, ModelADM);
                    booksview.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(booksview);
                    booksview.Show();
                    break;
                default:
                    //Outras situações

                    break;
            }



        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BntMenu_Click(object sender, EventArgs e)
        {
            Pagina_Abertura = 0;
            FPnContenedor.Controls.Clear();
            selctColor();
        }

        private void BntUsers_Click(object sender, EventArgs e)
        {
            Pagina_Abertura = 1;
            selctColor();

            FrmUserADM Frmuser = new FrmUserADM(Model_User, ModelADM);
            Frmuser.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(Frmuser);
            Frmuser.Show();
        }

        private void BntReserv_Click(object sender, EventArgs e)
        {
            Pagina_Abertura = 2;
            selctColor();

            FrmReservADM reserv = new FrmReservADM(Model_User, ModelADM);
            reserv.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(reserv);
            reserv.Show();
        }

        private void BntBooks_Click(object sender, EventArgs e)
        {
            Pagina_Abertura = 3;
            selctColor();

            FrmLivrosADM booksview = new FrmLivrosADM(Model_User, ModelADM);
            booksview.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(booksview);
            booksview.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntCircle1_Click(object sender, EventArgs e)
        {
            FrmMeanC mean_User = new FrmMeanC(Model_User, 0, "0");
            this.Hide();
            mean_User.ShowDialog();
        }
    }
}
