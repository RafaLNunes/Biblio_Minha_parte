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
using static System.Net.Mime.MediaTypeNames;

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
        private string _CAM_Bnt;

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
        public string CAM_Bnt
        {
            get { return _CAM_Bnt; }
            set { _CAM_Bnt = value; }
        }
        #endregion
        private void UcConjuntoLivro_Load(object sender, EventArgs e)
        {
            
        }
    }
}