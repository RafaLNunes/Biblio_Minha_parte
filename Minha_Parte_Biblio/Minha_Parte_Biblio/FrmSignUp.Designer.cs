﻿namespace Minha_Parte_Biblio
{
    partial class FrmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            LbLogIn = new LinkLabel();
            Lbtext = new Label();
            Image_Visivel = new PictureBox();
            txtPassWord = new TextBox();
            PbPassWord = new PictureBox();
            txtUser = new TextBox();
            PbUser = new PictureBox();
            txtID = new TextBox();
            PbID = new PictureBox();
            txtNomeComp = new TextBox();
            PbNomeComp = new PictureBox();
            CbCargo = new ComboBox();
            CbAno = new ComboBox();
            CbVisivel_Senha = new ImageList(components);
            Cbimage_PassWord = new ImageList(components);
            Cbimage_User = new ImageList(components);
            CbImage_NomeComp = new ImageList(components);
            CbImage_ID = new ImageList(components);
            PnBntSignUp = new Panel();
            BntSignUp = new Button();
            PbImage_Perfil = new Aprendendo_MVC.PictureBoxCircle();
            PnImage_Escolha = new Panel();
            BntEscolher_Image = new Button();
            FpUser = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            PnBarUser = new Panel();
            FpPass = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            PnBarPass = new Panel();
            FpNomeComp = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            PnBarNomeComp = new Panel();
            FpId = new FlowLayoutPanel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            PnBarId = new Panel();
            CbUnidade = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbNomeComp).BeginInit();
            PnBntSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImage_Perfil).BeginInit();
            PnImage_Escolha.SuspendLayout();
            FpUser.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            FpPass.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            FpNomeComp.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            FpId.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // LbLogIn
            // 
            LbLogIn.AutoSize = true;
            LbLogIn.BackColor = Color.Transparent;
            LbLogIn.Font = new Font("Arial Black", 17F, FontStyle.Bold | FontStyle.Italic);
            LbLogIn.LinkColor = Color.Black;
            LbLogIn.Location = new Point(362, 482);
            LbLogIn.Name = "LbLogIn";
            LbLogIn.Size = new Size(312, 41);
            LbLogIn.TabIndex = 9;
            LbLogIn.TabStop = true;
            LbLogIn.Text = "Clique aqui: Log In";
            LbLogIn.LinkClicked += LbLogIn_LinkClicked;
            // 
            // Lbtext
            // 
            Lbtext.AutoSize = true;
            Lbtext.BackColor = Color.Transparent;
            Lbtext.Font = new Font("Arial", 17F);
            Lbtext.Location = new Point(219, 487);
            Lbtext.Name = "Lbtext";
            Lbtext.Size = new Size(159, 33);
            Lbtext.TabIndex = 8;
            Lbtext.Text = "Tem conta ";
            // 
            // Image_Visivel
            // 
            Image_Visivel.BackColor = Color.Transparent;
            Image_Visivel.Image = (Image)resources.GetObject("Image_Visivel.Image");
            Image_Visivel.Location = new Point(382, 3);
            Image_Visivel.Name = "Image_Visivel";
            Image_Visivel.Size = new Size(54, 50);
            Image_Visivel.SizeMode = PictureBoxSizeMode.Zoom;
            Image_Visivel.TabIndex = 15;
            Image_Visivel.TabStop = false;
            Image_Visivel.Click += Image_Visivel_Click;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.FromArgb(242, 203, 17);
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Location = new Point(3, 27);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '•';
            txtPassWord.Size = new Size(301, 20);
            txtPassWord.TabIndex = 14;
            txtPassWord.Enter += txtPassWord_Enter;
            txtPassWord.Leave += txtPassWord_Leave;
            // 
            // PbPassWord
            // 
            PbPassWord.BackColor = Color.Transparent;
            PbPassWord.Image = (Image)resources.GetObject("PbPassWord.Image");
            PbPassWord.Location = new Point(3, 3);
            PbPassWord.Name = "PbPassWord";
            PbPassWord.Size = new Size(54, 50);
            PbPassWord.SizeMode = PictureBoxSizeMode.Zoom;
            PbPassWord.TabIndex = 13;
            PbPassWord.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(242, 203, 17);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(3, 27);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(301, 20);
            txtUser.TabIndex = 17;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // PbUser
            // 
            PbUser.BackColor = Color.Transparent;
            PbUser.Image = (Image)resources.GetObject("PbUser.Image");
            PbUser.Location = new Point(3, 3);
            PbUser.Name = "PbUser";
            PbUser.Size = new Size(54, 50);
            PbUser.SizeMode = PictureBoxSizeMode.Zoom;
            PbUser.TabIndex = 16;
            PbUser.TabStop = false;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(242, 203, 17);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(3, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(301, 20);
            txtID.TabIndex = 19;
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // PbID
            // 
            PbID.BackColor = Color.Transparent;
            PbID.Image = (Image)resources.GetObject("PbID.Image");
            PbID.Location = new Point(3, 3);
            PbID.Name = "PbID";
            PbID.Size = new Size(54, 50);
            PbID.SizeMode = PictureBoxSizeMode.Zoom;
            PbID.TabIndex = 18;
            PbID.TabStop = false;
            // 
            // txtNomeComp
            // 
            txtNomeComp.BackColor = Color.FromArgb(242, 203, 17);
            txtNomeComp.BorderStyle = BorderStyle.None;
            txtNomeComp.Location = new Point(3, 27);
            txtNomeComp.Name = "txtNomeComp";
            txtNomeComp.Size = new Size(301, 20);
            txtNomeComp.TabIndex = 21;
            txtNomeComp.Enter += txtNomeComp_Enter;
            txtNomeComp.Leave += txtNomeComp_Leave;
            // 
            // PbNomeComp
            // 
            PbNomeComp.BackColor = Color.Transparent;
            PbNomeComp.Image = (Image)resources.GetObject("PbNomeComp.Image");
            PbNomeComp.Location = new Point(3, 3);
            PbNomeComp.Name = "PbNomeComp";
            PbNomeComp.Size = new Size(54, 50);
            PbNomeComp.SizeMode = PictureBoxSizeMode.Zoom;
            PbNomeComp.TabIndex = 20;
            PbNomeComp.TabStop = false;
            // 
            // CbCargo
            // 
            CbCargo.BackColor = Color.White;
            CbCargo.FlatStyle = FlatStyle.Popup;
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(35, 418);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(220, 28);
            CbCargo.TabIndex = 22;
            CbCargo.SelectedIndexChanged += CbCargo_SelectedIndexChanged;
            // 
            // CbAno
            // 
            CbAno.BackColor = Color.White;
            CbAno.FlatStyle = FlatStyle.Popup;
            CbAno.FormattingEnabled = true;
            CbAno.Location = new Point(629, 418);
            CbAno.Name = "CbAno";
            CbAno.Size = new Size(220, 28);
            CbAno.TabIndex = 23;
            // 
            // CbVisivel_Senha
            // 
            CbVisivel_Senha.ColorDepth = ColorDepth.Depth32Bit;
            CbVisivel_Senha.ImageStream = (ImageListStreamer)resources.GetObject("CbVisivel_Senha.ImageStream");
            CbVisivel_Senha.TransparentColor = Color.Transparent;
            CbVisivel_Senha.Images.SetKeyName(0, "Olho_Visivel.png");
            CbVisivel_Senha.Images.SetKeyName(1, "Olhp_Invisivel.png");
            // 
            // Cbimage_PassWord
            // 
            Cbimage_PassWord.ColorDepth = ColorDepth.Depth32Bit;
            Cbimage_PassWord.ImageStream = (ImageListStreamer)resources.GetObject("Cbimage_PassWord.ImageStream");
            Cbimage_PassWord.TransparentColor = Color.Transparent;
            Cbimage_PassWord.Images.SetKeyName(0, "PassWord_Click.png");
            Cbimage_PassWord.Images.SetKeyName(1, "PassWord_UnClick.png");
            // 
            // Cbimage_User
            // 
            Cbimage_User.ColorDepth = ColorDepth.Depth32Bit;
            Cbimage_User.ImageStream = (ImageListStreamer)resources.GetObject("Cbimage_User.ImageStream");
            Cbimage_User.TransparentColor = Color.Transparent;
            Cbimage_User.Images.SetKeyName(0, "User_Click.png");
            Cbimage_User.Images.SetKeyName(1, "User_UnClick.png");
            // 
            // CbImage_NomeComp
            // 
            CbImage_NomeComp.ColorDepth = ColorDepth.Depth32Bit;
            CbImage_NomeComp.ImageStream = (ImageListStreamer)resources.GetObject("CbImage_NomeComp.ImageStream");
            CbImage_NomeComp.TransparentColor = Color.Transparent;
            CbImage_NomeComp.Images.SetKeyName(0, "NomeComp_Click.png");
            CbImage_NomeComp.Images.SetKeyName(1, "NomeComp_UnClick.png");
            // 
            // CbImage_ID
            // 
            CbImage_ID.ColorDepth = ColorDepth.Depth32Bit;
            CbImage_ID.ImageStream = (ImageListStreamer)resources.GetObject("CbImage_ID.ImageStream");
            CbImage_ID.TransparentColor = Color.Transparent;
            CbImage_ID.Images.SetKeyName(0, "ID_Click.png");
            CbImage_ID.Images.SetKeyName(1, "ID_UnClick.png");
            // 
            // PnBntSignUp
            // 
            PnBntSignUp.BackColor = Color.Transparent;
            PnBntSignUp.Controls.Add(BntSignUp);
            PnBntSignUp.Location = new Point(248, 661);
            PnBntSignUp.Name = "PnBntSignUp";
            PnBntSignUp.Size = new Size(386, 78);
            PnBntSignUp.TabIndex = 24;
            // 
            // BntSignUp
            // 
            BntSignUp.BackColor = Color.Transparent;
            BntSignUp.FlatStyle = FlatStyle.Popup;
            BntSignUp.Location = new Point(-15, -15);
            BntSignUp.Name = "BntSignUp";
            BntSignUp.Size = new Size(478, 116);
            BntSignUp.TabIndex = 6;
            BntSignUp.Text = "   ";
            BntSignUp.UseVisualStyleBackColor = false;
            BntSignUp.Click += BntSignUp_Click;
            // 
            // PbImage_Perfil
            // 
            PbImage_Perfil.BackColor = Color.Transparent;
            PbImage_Perfil.BorderStyle = BorderStyle.Fixed3D;
            PbImage_Perfil.Location = new Point(1040, 296);
            PbImage_Perfil.Name = "PbImage_Perfil";
            PbImage_Perfil.Size = new Size(420, 420);
            PbImage_Perfil.SizeMode = PictureBoxSizeMode.CenterImage;
            PbImage_Perfil.TabIndex = 26;
            PbImage_Perfil.TabStop = false;
            PbImage_Perfil.Click += pictureBoxCircle1_Click;
            // 
            // PnImage_Escolha
            // 
            PnImage_Escolha.BackColor = Color.Transparent;
            PnImage_Escolha.Controls.Add(BntEscolher_Image);
            PnImage_Escolha.Location = new Point(251, 558);
            PnImage_Escolha.Name = "PnImage_Escolha";
            PnImage_Escolha.Size = new Size(386, 78);
            PnImage_Escolha.TabIndex = 27;
            // 
            // BntEscolher_Image
            // 
            BntEscolher_Image.BackColor = Color.Transparent;
            BntEscolher_Image.FlatStyle = FlatStyle.Popup;
            BntEscolher_Image.Location = new Point(-15, -15);
            BntEscolher_Image.Name = "BntEscolher_Image";
            BntEscolher_Image.Size = new Size(478, 116);
            BntEscolher_Image.TabIndex = 6;
            BntEscolher_Image.Text = "   ";
            BntEscolher_Image.UseVisualStyleBackColor = false;
            BntEscolher_Image.Click += BntEscolher_Image_Click;
            // 
            // FpUser
            // 
            FpUser.BackColor = Color.Transparent;
            FpUser.Controls.Add(PbUser);
            FpUser.Controls.Add(flowLayoutPanel2);
            FpUser.Controls.Add(PnBarUser);
            FpUser.Location = new Point(2, 228);
            FpUser.Name = "FpUser";
            FpUser.Size = new Size(384, 70);
            FpUser.TabIndex = 28;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtUser);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(63, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(313, 50);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // PnBarUser
            // 
            PnBarUser.Location = new Point(3, 59);
            PnBarUser.Name = "PnBarUser";
            PnBarUser.Size = new Size(373, 28);
            PnBarUser.TabIndex = 1;
            // 
            // FpPass
            // 
            FpPass.BackColor = Color.Transparent;
            FpPass.Controls.Add(PbPassWord);
            FpPass.Controls.Add(flowLayoutPanel3);
            FpPass.Controls.Add(Image_Visivel);
            FpPass.Controls.Add(PnBarPass);
            FpPass.Location = new Point(434, 228);
            FpPass.Name = "FpPass";
            FpPass.Size = new Size(454, 70);
            FpPass.TabIndex = 29;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(txtPassWord);
            flowLayoutPanel3.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel3.Location = new Point(63, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(313, 50);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // PnBarPass
            // 
            PnBarPass.Location = new Point(3, 59);
            PnBarPass.Name = "PnBarPass";
            PnBarPass.Size = new Size(433, 28);
            PnBarPass.TabIndex = 1;
            // 
            // FpNomeComp
            // 
            FpNomeComp.BackColor = Color.Transparent;
            FpNomeComp.Controls.Add(PbNomeComp);
            FpNomeComp.Controls.Add(flowLayoutPanel5);
            FpNomeComp.Controls.Add(PnBarNomeComp);
            FpNomeComp.Location = new Point(5, 88);
            FpNomeComp.Name = "FpNomeComp";
            FpNomeComp.Size = new Size(384, 70);
            FpNomeComp.TabIndex = 30;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(txtNomeComp);
            flowLayoutPanel5.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel5.Location = new Point(63, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(313, 50);
            flowLayoutPanel5.TabIndex = 2;
            // 
            // PnBarNomeComp
            // 
            PnBarNomeComp.Location = new Point(3, 59);
            PnBarNomeComp.Name = "PnBarNomeComp";
            PnBarNomeComp.Size = new Size(373, 28);
            PnBarNomeComp.TabIndex = 1;
            // 
            // FpId
            // 
            FpId.BackColor = Color.Transparent;
            FpId.Controls.Add(PbID);
            FpId.Controls.Add(flowLayoutPanel7);
            FpId.Controls.Add(PnBarId);
            FpId.Location = new Point(431, 88);
            FpId.Name = "FpId";
            FpId.Size = new Size(384, 70);
            FpId.TabIndex = 31;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(txtID);
            flowLayoutPanel7.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel7.Location = new Point(63, 3);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(313, 50);
            flowLayoutPanel7.TabIndex = 2;
            // 
            // PnBarId
            // 
            PnBarId.Location = new Point(3, 59);
            PnBarId.Name = "PnBarId";
            PnBarId.Size = new Size(373, 28);
            PnBarId.TabIndex = 1;
            // 
            // CbUnidade
            // 
            CbUnidade.BackColor = Color.White;
            CbUnidade.FlatStyle = FlatStyle.Popup;
            CbUnidade.FormattingEnabled = true;
            CbUnidade.Location = new Point(330, 418);
            CbUnidade.Name = "CbUnidade";
            CbUnidade.Size = new Size(220, 28);
            CbUnidade.TabIndex = 32;
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(CbUnidade);
            Controls.Add(FpId);
            Controls.Add(FpNomeComp);
            Controls.Add(FpPass);
            Controls.Add(FpUser);
            Controls.Add(PnImage_Escolha);
            Controls.Add(PnBntSignUp);
            Controls.Add(CbAno);
            Controls.Add(CbCargo);
            Controls.Add(LbLogIn);
            Controls.Add(Lbtext);
            Controls.Add(PbImage_Perfil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSignUp";
            Load += FrmSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbPassWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbID).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbNomeComp).EndInit();
            PnBntSignUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbImage_Perfil).EndInit();
            PnImage_Escolha.ResumeLayout(false);
            FpUser.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            FpPass.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            FpNomeComp.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            FpId.ResumeLayout(false);
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel LbLogIn;
        private Label Lbtext;
        private PictureBox Image_Visivel;
        private TextBox txtPassWord;
        private PictureBox PbPassWord;
        private TextBox txtUser;
        private PictureBox PbUser;
        private TextBox txtID;
        private PictureBox PbID;
        private TextBox txtNomeComp;
        private PictureBox PbNomeComp;
        private ComboBox CbCargo;
        private ComboBox CbAno;
        private ImageList CbVisivel_Senha;
        private ImageList Cbimage_PassWord;
        private ImageList Cbimage_User;
        private ImageList CbImage_NomeComp;
        private ImageList CbImage_ID;
        private Panel PnBntSignUp;
        private Button BntSignUp;
        private Aprendendo_MVC.PictureBoxCircle PbImage_Perfil;
        private Panel PnImage_Escolha;
        private Button BntEscolher_Image;
        private FlowLayoutPanel FpUser;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel PnBarUser;
        private FlowLayoutPanel FpPass;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel PnBarPass;
        private FlowLayoutPanel FpNomeComp;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel PnBarNomeComp;
        private FlowLayoutPanel FpId;
        private FlowLayoutPanel flowLayoutPanel7;
        private Panel PnBarId;
        private ComboBox CbUnidade;
    }
}