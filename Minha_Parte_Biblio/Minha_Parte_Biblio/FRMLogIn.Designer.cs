namespace Minha_Parte_Biblio
{
    partial class FRMLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMLogIn));
            Image_User = new PictureBox();
            Image_PassWord = new PictureBox();
            txtUser = new TextBox();
            txtPassWord = new TextBox();
            Image_Visivel = new PictureBox();
            PnBntLogIn = new Panel();
            BntLogIn = new Button();
            Lbtext = new Label();
            LbSignUp = new LinkLabel();
            CbVisivel_Senha = new ImageList(components);
            Cbimage_PassWord = new ImageList(components);
            Cbimage_User = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)Image_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_PassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).BeginInit();
            PnBntLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // Image_User
            // 
            Image_User.BackColor = Color.Transparent;
            Image_User.Image = (Image)resources.GetObject("Image_User.Image");
            Image_User.Location = new Point(63, 432);
            Image_User.Name = "Image_User";
            Image_User.Size = new Size(54, 50);
            Image_User.SizeMode = PictureBoxSizeMode.Zoom;
            Image_User.TabIndex = 0;
            Image_User.TabStop = false;
            // 
            // Image_PassWord
            // 
            Image_PassWord.BackColor = Color.Transparent;
            Image_PassWord.Image = (Image)resources.GetObject("Image_PassWord.Image");
            Image_PassWord.Location = new Point(63, 583);
            Image_PassWord.Name = "Image_PassWord";
            Image_PassWord.Size = new Size(54, 50);
            Image_PassWord.SizeMode = PictureBoxSizeMode.Zoom;
            Image_PassWord.TabIndex = 1;
            Image_PassWord.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(242, 203, 17);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(123, 450);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(358, 20);
            txtUser.TabIndex = 2;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.FromArgb(242, 203, 17);
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Location = new Point(123, 600);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '•';
            txtPassWord.Size = new Size(358, 20);
            txtPassWord.TabIndex = 3;
            txtPassWord.Enter += txtPassWord_Enter;
            txtPassWord.Leave += txtPassWord_Leave;
            // 
            // Image_Visivel
            // 
            Image_Visivel.BackColor = Color.Transparent;
            Image_Visivel.Image = (Image)resources.GetObject("Image_Visivel.Image");
            Image_Visivel.Location = new Point(487, 583);
            Image_Visivel.Name = "Image_Visivel";
            Image_Visivel.Size = new Size(54, 50);
            Image_Visivel.SizeMode = PictureBoxSizeMode.Zoom;
            Image_Visivel.TabIndex = 4;
            Image_Visivel.TabStop = false;
            Image_Visivel.Click += Image_Visivel_Click;
            // 
            // PnBntLogIn
            // 
            PnBntLogIn.BackColor = Color.Transparent;
            PnBntLogIn.Controls.Add(BntLogIn);
            PnBntLogIn.Location = new Point(78, 766);
            PnBntLogIn.Name = "PnBntLogIn";
            PnBntLogIn.Size = new Size(442, 90);
            PnBntLogIn.TabIndex = 5;
            // 
            // BntLogIn
            // 
            BntLogIn.BackColor = Color.Transparent;
            BntLogIn.FlatStyle = FlatStyle.Popup;
            BntLogIn.Location = new Point(-15, -15);
            BntLogIn.Name = "BntLogIn";
            BntLogIn.Size = new Size(478, 116);
            BntLogIn.TabIndex = 6;
            BntLogIn.Text = "   ";
            BntLogIn.UseVisualStyleBackColor = false;
            // 
            // Lbtext
            // 
            Lbtext.AutoSize = true;
            Lbtext.BackColor = Color.Transparent;
            Lbtext.Font = new Font("Arial", 16F);
            Lbtext.Location = new Point(50, 691);
            Lbtext.Name = "Lbtext";
            Lbtext.Size = new Size(199, 32);
            Lbtext.TabIndex = 6;
            Lbtext.Text = "Não tem conta ";
            // 
            // LbSignUp
            // 
            LbSignUp.AutoSize = true;
            LbSignUp.BackColor = Color.Transparent;
            LbSignUp.Font = new Font("Arial Black", 16F, FontStyle.Bold | FontStyle.Italic);
            LbSignUp.LinkColor = Color.Black;
            LbSignUp.Location = new Point(234, 688);
            LbSignUp.Name = "LbSignUp";
            LbSignUp.Size = new Size(314, 38);
            LbSignUp.TabIndex = 7;
            LbSignUp.TabStop = true;
            LbSignUp.Text = "Clique aqui: Sign Up";
            LbSignUp.LinkClicked += LbSignUp_LinkClicked;
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
            // FRMLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.duplicada_LogIn;
            ClientSize = new Size(600, 900);
            Controls.Add(LbSignUp);
            Controls.Add(Lbtext);
            Controls.Add(PnBntLogIn);
            Controls.Add(Image_Visivel);
            Controls.Add(txtPassWord);
            Controls.Add(txtUser);
            Controls.Add(Image_PassWord);
            Controls.Add(Image_User);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRMLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += FRMLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)Image_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_PassWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).EndInit();
            PnBntLogIn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Image_User;
        private PictureBox Image_PassWord;
        private TextBox txtUser;
        private TextBox txtPassWord;
        private PictureBox Image_Visivel;
        private Panel PnBntLogIn;
        private Button BntLogIn;
        private Label Lbtext;
        private LinkLabel LbSignUp;
        private ImageList CbVisivel_Senha;
        private ImageList Cbimage_PassWord;
        private ImageList Cbimage_User;
    }
}