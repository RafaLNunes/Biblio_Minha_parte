using Aprendendo_MVC;
using Minha_Parte_Biblio;
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

namespace usuario
{
    public partial class FrmCatalogo : Form
    {
        ClUserModelo Modelo_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();
        public FrmCatalogo(ClUserModelo User)
        {
            this.Modelo_User = User;
            InitializeComponent();

            DataTable DT_Livros = new DataTable();
            DT_Livros = conexao.obterdados("select * from Table_Livro");
            UcConjuntoLivro[] Conj_Livro = new UcConjuntoLivro[36];

            for (int i = 0; i < 24; i++)//DT_Livros.Rows.Count
            {

                Conj_Livro[i] = new UcConjuntoLivro();

                Conj_Livro[i].NomeLivro = DT_Livros.Rows[i]["Nome_Livro"].ToString();
                Conj_Livro[i].Autor = DT_Livros.Rows[i]["Autor_Livro"].ToString();

                Conj_Livro[i].Cod_Livro = DT_Livros.Rows[i]["CD_Livro"].ToString();
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Books\\\\", DT_Livros.Rows[i]["IMG_Livro"].ToString());

                // Verifica se a imagem existe
                if (File.Exists(imagePath))
                {
                    var img = Image.FromFile(imagePath);
                    
                        Conj_Livro[i].IMG_cam = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
                        img.Dispose();
                    
                }
                FPConteinerCat.Controls.Add(Conj_Livro[i]);
            }

            /*
             * 
             * DataTable DT_Livros = conexao.obterdados("select * from Table_Livro");
UcConjuntoLivro[] Conj_Livro = new UcConjuntoLivro[DT_Livros.Rows.Count];

for (int i = 0; i < DT_Livros.Rows.Count; i++)
{
    Conj_Livro[i] = new UcConjuntoLivro
    {
        Cod_Livro = (int)DT_Livros.Rows[i]["Order_Livro"],
        NomeLivro = DT_Livros.Rows[i]["Nome_Livro"].ToString(),
        Autor = DT_Livros.Rows[i]["Autor_Livro"].ToString()
    };

    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Books", DT_Livros.Rows[i]["IMG_Livro"].ToString());
    
    // Verifica se a imagem existe
    if (File.Exists(imagePath))
    {   
        using (var img = Image.FromFile(imagePath))
        {
            Conj_Livro[i].IMG_cam = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
        }
    }

    FPConteinerCat.Controls.Add(Conj_Livro[i]);
}
             * 
             */

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FPConteinerCat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {

        }
    }
}
