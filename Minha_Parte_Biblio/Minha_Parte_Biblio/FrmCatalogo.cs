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

            for (int i = 1; i <= DT_Livros.Rows.Count; i++)
            {

                Conj_Livro[i].LbNomeLivro = DT_Livros.Rows[i]["Nome_Livro"].ToString();
            }



        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FPConteinerCat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
