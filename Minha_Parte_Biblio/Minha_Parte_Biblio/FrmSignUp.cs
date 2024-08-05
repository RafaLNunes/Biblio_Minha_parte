﻿using Aprendendo_MVC;
using Minha_Parte_Biblio.Controle;
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

namespace Minha_Parte_Biblio
{
    public partial class FrmSignUp : Form
    {

        ClConectection conexao = new ClConectection();
        ClUsercontrole controle_User = new ClUsercontrole();
        ClUserModelo Modelo_User = new ClUserModelo();



        String Cam_FT = "";
        String Cam_origin = "";

        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            PbImage_Perfil.Visible = false;

            CbCargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            CbCargo.DisplayMember = "Cargo";
            CbCargo.ValueMember = "CD_Cargo";
            CbCargo.Text = String.Empty;

            CbAno.DataSource = conexao.obterdados("select * from Table_Ano_Escolar");
            CbAno.DisplayMember = "Ano_Escolar";
            CbAno.ValueMember = "CD_Ano_Escolar";
            CbAno.Text = String.Empty;

        }

        private void Image_Visivel_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '•')
            {
                txtPassWord.PasswordChar = '\0';
                Image_Visivel.Image = CbVisivel_Senha.Images[1];
            }
            else if (txtPassWord.PasswordChar == '\0')
            {
                txtPassWord.PasswordChar = '•';
                Image_Visivel.Image = CbVisivel_Senha.Images[0];
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[0];
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[1];
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[0];
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[1];
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[0];
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[1];
        }

        private void txtNomeComp_Enter(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[0];
        }

        private void txtNomeComp_Leave(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[1];
        }

        private void LbLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMLogIn fRMLogIn = new FRMLogIn();
            this.Hide();
            fRMLogIn.ShowDialog();
        }

        private void pictureBoxCircle1_Click(object sender, EventArgs e)
        {

        }

        private void LbNomeComp_Click(object sender, EventArgs e)
        {
            LbFTPerfil.Visible = false;
            PbImage_Perfil.Visible = true;

            try
            {
                OpenFileDialog ft = new OpenFileDialog();
                ft.Filter = "image file(*.jpg;*.png;*.gif;*.jpeg;*.webp)|*.jpg;*.png;*.gif;*.jpeg;*.webp";
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    PbImage_Perfil.Image = Image.FromFile(ft.FileName);
                    Cam_FT = ft.FileName.Replace("\\", "\\\\");
                    Cam_origin = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(Cam_FT));
                    File.Copy(Cam_FT, Cam_origin, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BntSignUp_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            FrmBoasVindas boVindam = new FrmBoasVindas(txtNomeComp.Text);
            this.Hide();
            boVindam.ShowDialog();
        }
    }
}
