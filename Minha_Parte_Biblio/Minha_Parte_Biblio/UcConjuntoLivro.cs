using Library_Project.modelo;
using Library_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Aprendendo_MVC;
using Minha_Parte_Biblio.Modelo;

namespace Minha_Parte_Biblio
{
    public partial class UcConjuntoLivro : UserControl
    {
        string Cam_FT;
        //margin: 20

        ModeloLivro modeloLivro = new ModeloLivro();
        ModeloUnidade unidade = new ModeloUnidade();
        ModeloReservas Modeloreserva = new ModeloReservas();
        ClUserModelo clUser = new ClUserModelo();
        ClConectection cn = new ClConectection();

        public UcConjuntoLivro()


        {
            InitializeComponent();
        }


        

        #region Properties
        private string _NomeLivro;
        private string _Autor;
        private Image _IMG_cam;

        private string _Cod_Livro;

        [Category("Custom Props")]
        public string NomeLivro
        {
            get { return _NomeLivro; }
            set { _NomeLivro = value; LbNomeLivro.Text = value; }
        }

        [Category("Custom Props")]
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; LbNomeAutor.Text = value; }
        }

        [Category("Custom Props")]
        public Image IMG_cam
        {
            get { return _IMG_cam; }
            set { _IMG_cam = value; PbLivro.Image = value; }
        }

        [Category("Custom Props")]
        public string Cod_Livro
        {
            get { return _Cod_Livro; }
            set { _Cod_Livro = value; }
        }

        #endregion
        private void UcConjuntoLivro_Load(object sender, EventArgs e)
        {

        }

        private void BntReserva_Click(object sender, EventArgs e)
        {
            // abri o form deo livor especifico com cod do livro

            // terá um var que recebera individualmente cada cod


            //INFO_Livro frmLivroEx = new INFO_Livro(Cod_Livro);
            //frmLivroEx.ShowDialog();

            modeloLivro.CD_Livro = Cod_Livro;
            // modeloLivro.CD_Livro = "320C111L2021";
            DataTable dt_unit = cn.obterdados("Select * from Table_Livro where CD_Livro = '" + modeloLivro.CD_Livro + "'");
            modeloLivro.Index_Unidade = (int)dt_unit.Rows[0]["CFK_Unidade"];
            unidade.CD_Unidade = modeloLivro.Index_Unidade;
            INFO_Livro info = new INFO_Livro(modeloLivro, clUser, unidade);
            info.ShowDialog();


        }
    }
}