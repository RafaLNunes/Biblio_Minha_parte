﻿using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using Microsoft.VisualBasic.ApplicationServices;
using Minha_Parte_Biblio;
using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using Mysqlx.Session;
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
        /* =====Importação das class de modelo===== */
        ClUserModelo Model_User = new ClUserModelo(); // responsavel por importar info dos users
        Model_Livro Model_Livro = new Model_Livro(); // responsavel por importar info dos livros
        ModeloReservas Model_Reserv = new ModeloReservas(); // resposavel por importar info das reservas
        ModeloUnidade Model_Unit = new ModeloUnidade(); // responsavel por importar info das unidades 

        ClConectection conexao = new ClConectection(); // responsavel pela conexao com a dt

        /* =====Importação das class de controle===== */
        ClUsercontrole Controle_User = new ClUsercontrole();
        ControleLivro Controle_Livro = new ControleLivro();
        ControleReservas Controle_Reserv = new ControleReservas();

        public FrmCatalogo(Model_Livro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;

            InitializeComponent();

            DataTable DT_Livros = new DataTable();
            DT_Livros = conexao.obterdados("select * from Table_Livro");
            UcConjuntoLivro[] Conj_Livro = new UcConjuntoLivro[36];

            for (int i = 0; i < 24; i++)//DT_Livros.Rows.Count
            {

                Conj_Livro[i] = new UcConjuntoLivro(Model_User);

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