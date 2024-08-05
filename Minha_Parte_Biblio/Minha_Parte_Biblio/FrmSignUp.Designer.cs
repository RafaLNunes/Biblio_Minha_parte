namespace Minha_Parte_Biblio
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
            LbNomeComp = new Label();
            PbImage_Perfil = new Aprendendo_MVC.PictureBoxCircle();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbPassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbNomeComp).BeginInit();
            PnBntSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbImage_Perfil).BeginInit();
            SuspendLayout();
            // 
            // LbLogIn
            // 
            LbLogIn.AutoSize = true;
            LbLogIn.BackColor = Color.Transparent;
            LbLogIn.Font = new Font("Arial Black", 17F, FontStyle.Bold | FontStyle.Italic);
            LbLogIn.LinkColor = Color.Black;
            LbLogIn.Location = new Point(215, 841);
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
            Lbtext.Location = new Point(72, 846);
            Lbtext.Name = "Lbtext";
            Lbtext.Size = new Size(159, 33);
            Lbtext.TabIndex = 8;
            Lbtext.Text = "Tem conta ";
            // 
            // Image_Visivel
            // 
            Image_Visivel.BackColor = Color.Transparent;
            Image_Visivel.Image = (Image)resources.GetObject("Image_Visivel.Image");
            Image_Visivel.Location = new Point(456, 766);
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
            txtPassWord.Location = new Point(149, 783);
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
            PbPassWord.Location = new Point(89, 766);
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
            txtUser.Location = new Point(149, 655);
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '•';
            txtUser.Size = new Size(301, 20);
            txtUser.TabIndex = 17;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // PbUser
            // 
            PbUser.BackColor = Color.Transparent;
            PbUser.Image = (Image)resources.GetObject("PbUser.Image");
            PbUser.Location = new Point(89, 638);
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
            txtID.Location = new Point(149, 519);
            txtID.Name = "txtID";
            txtID.PasswordChar = '•';
            txtID.Size = new Size(301, 20);
            txtID.TabIndex = 19;
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // PbID
            // 
            PbID.BackColor = Color.Transparent;
            PbID.Image = (Image)resources.GetObject("PbID.Image");
            PbID.Location = new Point(89, 502);
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
            txtNomeComp.Location = new Point(149, 387);
            txtNomeComp.Name = "txtNomeComp";
            txtNomeComp.PasswordChar = '•';
            txtNomeComp.Size = new Size(301, 20);
            txtNomeComp.TabIndex = 21;
            txtNomeComp.Enter += txtNomeComp_Enter;
            txtNomeComp.Leave += txtNomeComp_Leave;
            // 
            // PbNomeComp
            // 
            PbNomeComp.BackColor = Color.Transparent;
            PbNomeComp.Image = (Image)resources.GetObject("PbNomeComp.Image");
            PbNomeComp.Location = new Point(89, 370);
            PbNomeComp.Name = "PbNomeComp";
            PbNomeComp.Size = new Size(54, 50);
            PbNomeComp.SizeMode = PictureBoxSizeMode.Zoom;
            PbNomeComp.TabIndex = 20;
            PbNomeComp.TabStop = false;
            // 
            // CbCargo
            // 
            CbCargo.BackColor = Color.FromArgb(242, 203, 17);
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(93, 237);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(195, 28);
            CbCargo.TabIndex = 22;
            // 
            // CbAno
            // 
            CbAno.BackColor = Color.FromArgb(242, 203, 17);
            CbAno.FormattingEnabled = true;
            CbAno.Location = new Point(93, 305);
            CbAno.Name = "CbAno";
            CbAno.Size = new Size(195, 28);
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
            PnBntSignUp.Location = new Point(108, 900);
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
            // 
            // LbNomeComp
            // 
            LbNomeComp.AutoSize = true;
            LbNomeComp.BackColor = Color.Transparent;
            LbNomeComp.Font = new Font("Segoe UI", 15.2F, FontStyle.Bold);
            LbNomeComp.ForeColor = Color.FromArgb(255, 207, 0);
            LbNomeComp.Location = new Point(314, 202);
            LbNomeComp.Name = "LbNomeComp";
            LbNomeComp.Size = new Size(197, 108);
            LbNomeComp.TabIndex = 25;
            LbNomeComp.Text = "  Clique aqui\r\n para escolher\r\na foto de perfil";
            // 
            // PbImage_Perfil
            // 
            PbImage_Perfil.BackColor = Color.Transparent;
            PbImage_Perfil.BorderStyle = BorderStyle.Fixed3D;
            PbImage_Perfil.Location = new Point(303, 147);
            PbImage_Perfil.Name = "PbImage_Perfil";
            PbImage_Perfil.Size = new Size(220, 220);
            PbImage_Perfil.SizeMode = PictureBoxSizeMode.CenterImage;
            PbImage_Perfil.TabIndex = 26;
            PbImage_Perfil.TabStop = false;
            PbImage_Perfil.Click += pictureBoxCircle1_Click;
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUp_Duplicada__1_;
            ClientSize = new Size(600, 1000);
            Controls.Add(LbNomeComp);
            Controls.Add(PnBntSignUp);
            Controls.Add(CbAno);
            Controls.Add(CbCargo);
            Controls.Add(txtNomeComp);
            Controls.Add(PbNomeComp);
            Controls.Add(txtID);
            Controls.Add(PbID);
            Controls.Add(txtUser);
            Controls.Add(PbUser);
            Controls.Add(Image_Visivel);
            Controls.Add(txtPassWord);
            Controls.Add(PbPassWord);
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
        private Label LbNomeComp;
        private Aprendendo_MVC.PictureBoxCircle PbImage_Perfil;
    }
}