﻿using System;
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
    public partial class FRMLogIn : Form
    {
        public FRMLogIn()
        {
            InitializeComponent();
        }

        private void FRMLogIn_Load(object sender, EventArgs e)
        {

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

        private void txtUser_Enter(object sender, EventArgs e)
        {
            Image_User.Image = Cbimage_User.Images[0];
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            Image_User.Image = Cbimage_User.Images[1];
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            Image_PassWord.Image = Cbimage_PassWord.Images[0];
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            Image_PassWord.Image = Cbimage_PassWord.Images[1];
        }

        private void LbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignUp signUpForm = new FrmSignUp();
            this.Hide();
            signUpForm.ShowDialog();
        }
    }
}
