﻿using Minha_Parte_Biblio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuario;

namespace Minha_Parte_Biblio
{
    public partial class FrmMeanC : Form
    {

        ClUserModelo Modelo_User = new ClUserModelo();
        public void ArredondaCantosdoForm()
        {
            // ARREDONDAMENTO DE BORDA
            //GraphicsPath PastaGrafica = new GraphicsPath();
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            ////Arredondar canto superior esquerdo        
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            //PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            ////Arredondar canto superior direito
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            //PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            ////Arredondar canto inferior esquerdo
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            //PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            ////Arredondar canto inferior direito
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            //PastaGrafica.AddPie(this.Width, this.Height - 26, 24, 26, 0, 90);

            //PastaGrafica.SetMarkers();
            //this.Region = new Region(PastaGrafica);
        }


        private void AddFormsParent(Form form1)
        {
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(form1);
            form1.BringToFront();
        }


        public FrmMeanC(ClUserModelo user, int pag)
        {
            this.Modelo_User = user;
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Font = new Font("Chakra Petch", 12); // adjust font size as needed
                }
            }

            PnMenu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnMenu.Width, PnMenu.Height, 20, 20));
            PnUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnUser.Width, PnUser.Height, 20, 20));
            PnCatalogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnCatalogo.Width, PnCatalogo.Height, 20, 20));
            PnHist.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnHist.Width, PnHist.Height, 20, 20));
            PnReserv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnReserv.Width, PnReserv.Height, 20, 20));
            PnPerguntas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnPerguntas.Width, PnPerguntas.Height, 20, 20));
            PnNos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnNos.Width, PnNos.Height, 20, 20));

            this.IsMdiContainer = true;

            switch (pag)
            {
                case 0:
                    //0 - vazio
                    FPnContenedor.Controls.Clear();
                    break;
                case 1:
                    //1 - usuario
                    Frmusuario Frmuser = new Frmusuario(Modelo_User);
                    Frmuser.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(Frmuser);
                    Frmuser.Show();
                    break;
                case 2:
                    //2 - catalogo
                    FrmCatalogo cat = new FrmCatalogo(Modelo_User);
                    cat.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(cat);
                    cat.Show();
                    break;
                case 3:
                    //3 - historicolivros
                    FrmhistLivros hist = new FrmhistLivros(Modelo_User);
                    hist.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(hist);
                    hist.Show();
                    break;
                case 4:
                    //4 - sobre nos
                    Frmsobrenos sobr = new Frmsobrenos();
                    sobr.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(sobr);
                    sobr.Show();
                    break;
                default:
                    //Vazio
                    FPnContenedor.Controls.Clear();
                    break;
            }
        }

        [DllImport("Gdi32")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void FrmMeanC_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BntMenu_Click(object sender, EventArgs e)
        {
            FPnContenedor.Controls.Clear();
        }

        private void PbUser_Click(object sender, EventArgs e)
        {

        }

        private void LbName_User_Click(object sender, EventArgs e)
        {

        }

        private void BntUser_Click(object sender, EventArgs e)
        {
            Frmusuario user = new Frmusuario(Modelo_User);
            user.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(user);
            user.Show();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BntCatalogo_Click(object sender, EventArgs e)
        {
            FrmCatalogo cat = new FrmCatalogo(Modelo_User);
            cat.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(cat);
            cat.Show();
        }

        private void BntHist_Click(object sender, EventArgs e)
        {
            FrmhistLivros hist = new FrmhistLivros(Modelo_User);
            hist.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(hist);
            hist.Show();
        }

        private void BntNos_Click(object sender, EventArgs e)
        {
            Frmsobrenos sobr = new Frmsobrenos();
            sobr.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(sobr);
            sobr.Show();
        }

        private void FPnContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
