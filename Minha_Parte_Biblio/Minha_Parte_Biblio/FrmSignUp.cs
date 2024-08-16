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
        String Nome_Ft = "";

        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92);
            PnBarId.BackColor = Color.FromArgb(43, 59, 92);
            PnBarNomeComp.BackColor = Color.FromArgb(43, 59, 92);

            txtPassWord.PasswordChar = '\0';

            txtID.Text = "Entre com o seu ID";
            txtNomeComp.Text = "Entre com o Nome Completo";
            txtPassWord.Text = "Entre com sua Senha";
            txtUser.Text = "Entre com o NameUser";

            txtID.ForeColor = Color.FromArgb(164, 186, 188);
            txtNomeComp.ForeColor = Color.FromArgb(164, 186, 188);
            txtPassWord.ForeColor = Color.FromArgb(164, 186, 188);
            txtUser.ForeColor = Color.FromArgb(164, 186, 188);


            CbCargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            CbCargo.DisplayMember = "Cargo";
            CbCargo.ValueMember = "CD_Cargo";
            CbCargo.Text = String.Empty;

            CbAno.DataSource = conexao.obterdados("select * from Table_Ano_Escolar");
            CbAno.DisplayMember = "Ano_Escolar";
            CbAno.ValueMember = "CD_Ano_Escolar";
            CbAno.Text = String.Empty;

            CbUnidade.DataSource = conexao.obterdados("select * from Table_Unidade");
            CbUnidade.DisplayMember = "Nome_Unidade";
            CbUnidade.ValueMember = "CD_Unidade";
            CbUnidade.Text = String.Empty;

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
            PnBarPass.BackColor = Color.FromArgb(9, 90, 162);
            txtPassWord.Text = "";
            txtPassWord.PasswordChar = '•';
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[1];
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[0];
            PnBarUser.BackColor = Color.FromArgb(9, 90, 162);
            txtUser.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[1];
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92);
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[0];
            PnBarId.BackColor = Color.FromArgb(9, 90, 162);
            txtID.Text = "";
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[1];
            PnBarId.BackColor = Color.FromArgb(43, 59, 92);
        }

        private void txtNomeComp_Enter(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[0];
            PnBarNomeComp.BackColor = Color.FromArgb(9, 90, 162);
            txtNomeComp.Text = "";
        }

        private void txtNomeComp_Leave(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[1];
            PnBarNomeComp.BackColor = Color.FromArgb(43, 59, 92);
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



        private void BntSignUp_Click(object sender, EventArgs e)
        {

            try
            {

                if (!String.IsNullOrEmpty(txtID.Text) || !String.IsNullOrEmpty(txtNomeComp.Text) || !String.IsNullOrEmpty(txtUser.Text) || !String.IsNullOrEmpty(txtPassWord.Text))
                {
                    Modelo_User.Index_Cargo = CbCargo.SelectedIndex + 1;
                    Modelo_User.Index_Ano = CbAno.SelectedIndex + 1;
                    Modelo_User.Index_Unidade = CbUnidade.SelectedIndex + 1;
                    Modelo_User.NomeComp = txtNomeComp.Text;
                    Modelo_User.ID_Aluno = txtID.Text;
                    Modelo_User.UserName = txtUser.Text;
                    Modelo_User.Password = txtPassWord.Text;
                    Modelo_User.Caminho_FT = Nome_Ft;
                    if (controle_User.SignUp(Modelo_User) == true)
                    {

                        Cam_origin = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(Cam_FT));
                        File.Copy(Cam_FT, Cam_origin, true);
                        MessageBox.Show(Cam_origin);
                        MessageBox.Show(Cam_origin);
                        FrmBoasVindas boVindam = new FrmBoasVindas(Modelo_User);
                        this.Hide();
                        boVindam.ShowDialog();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BntEscolher_Image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ft = new OpenFileDialog();
                ft.Filter = "image file(*.jpg;*.png;*.gif;*.jpeg;*.webp)|*.jpg;*.png;*.gif;*.jpeg;*.webp";
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    PbImage_Perfil.Image = Image.FromFile(ft.FileName);
                    Cam_FT = ft.FileName.Replace("\\", "\\\\");
                    Nome_Ft = ft.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
