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

namespace Minha_Parte_Biblio
{
    public partial class UcConjuntoLivro : UserControl
    {
        string Cam_FT;
        //margin: 20
        public UcConjuntoLivro()
        {
            InitializeComponent();
        }


        

        #region Properties
        private string _NomeLivro;
        private string _Autor;
        private Image _IMG_cam;
        private Button _CAM_Bnt;

        private int _Cod_Livro;

        [Category("Custom Props")]
        public string NomeLivro
        {
            get { return _NomeLivro; }
            set { _NomeLivro = value; }
        }

        [Category("Custom Props")]
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        [Category("Custom Props")]
        public Image IMG_cam
        {
            get { return _IMG_cam; }
            set { _IMG_cam = value; PbLivro.Image = value; }
        }

        [Category("Custom Props")]
        public Button CAM_Bnt
        {
            get { return _CAM_Bnt; }
            set { _CAM_Bnt = value; }
        }

        [Category("Custom Props")]
        public int Cod_Livro
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

        }
    }
}