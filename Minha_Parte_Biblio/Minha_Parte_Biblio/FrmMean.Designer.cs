namespace Minha_Parte_Biblio
{
    partial class FrmMean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMean));
            panel1 = new Panel();
            PbClose = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PnPag_User = new Panel();
            LbUser = new Label();
            PnBarPag_User = new Panel();
            PnCatalogo = new Panel();
            PnBarCatalogo = new Panel();
            LbCatalogo = new Label();
            PnPagUser_catalogo = new Panel();
            Pncatalogo_HistLivro = new Panel();
            PnHist_Livro = new Panel();
            PnBarHistLivro = new Panel();
            LbHistorico = new Label();
            PnHistLivro_Reserv = new Panel();
            PnReserv = new Panel();
            PnBarReserv = new Panel();
            LbReserv = new Label();
            PnReserv_Perguntas = new Panel();
            PnPerguntas = new Panel();
            PnBarPerguntas = new Panel();
            LbPerguntas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbClose).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            PnPag_User.SuspendLayout();
            PnCatalogo.SuspendLayout();
            PnHist_Livro.SuspendLayout();
            PnReserv.SuspendLayout();
            PnPerguntas.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 90, 162);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(PbClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1515, 187);
            panel1.TabIndex = 0;
            // 
            // PbClose
            // 
            PbClose.Image = (Image)resources.GetObject("PbClose.Image");
            PbClose.Location = new Point(1433, 12);
            PbClose.Name = "PbClose";
            PbClose.Size = new Size(70, 70);
            PbClose.SizeMode = PictureBoxSizeMode.Zoom;
            PbClose.TabIndex = 1;
            PbClose.TabStop = false;
            PbClose.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(PnPag_User);
            flowLayoutPanel1.Controls.Add(PnPagUser_catalogo);
            flowLayoutPanel1.Controls.Add(PnCatalogo);
            flowLayoutPanel1.Controls.Add(Pncatalogo_HistLivro);
            flowLayoutPanel1.Controls.Add(PnHist_Livro);
            flowLayoutPanel1.Controls.Add(PnHistLivro_Reserv);
            flowLayoutPanel1.Controls.Add(PnReserv);
            flowLayoutPanel1.Controls.Add(PnReserv_Perguntas);
            flowLayoutPanel1.Controls.Add(PnPerguntas);
            flowLayoutPanel1.Location = new Point(167, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1260, 149);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // PnPag_User
            // 
            PnPag_User.Controls.Add(PnBarPag_User);
            PnPag_User.Controls.Add(LbUser);
            PnPag_User.Location = new Point(3, 3);
            PnPag_User.Name = "PnPag_User";
            PnPag_User.Size = new Size(210, 48);
            PnPag_User.TabIndex = 1;
            // 
            // LbUser
            // 
            LbUser.AutoSize = true;
            LbUser.Font = new Font("Sitka Text", 13.5F);
            LbUser.Location = new Point(0, 0);
            LbUser.Name = "LbUser";
            LbUser.Size = new Size(210, 33);
            LbUser.TabIndex = 0;
            LbUser.Text = "Pagina do Usuário";
            // 
            // PnBarPag_User
            // 
            PnBarPag_User.Location = new Point(-15, 35);
            PnBarPag_User.Name = "PnBarPag_User";
            PnBarPag_User.Size = new Size(250, 98);
            PnBarPag_User.TabIndex = 2;
            // 
            // PnCatalogo
            // 
            PnCatalogo.Controls.Add(PnBarCatalogo);
            PnCatalogo.Controls.Add(LbCatalogo);
            PnCatalogo.Location = new Point(245, 3);
            PnCatalogo.Name = "PnCatalogo";
            PnCatalogo.Size = new Size(112, 48);
            PnCatalogo.TabIndex = 2;
            // 
            // PnBarCatalogo
            // 
            PnBarCatalogo.Location = new Point(-15, 35);
            PnBarCatalogo.Name = "PnBarCatalogo";
            PnBarCatalogo.Size = new Size(250, 98);
            PnBarCatalogo.TabIndex = 2;
            // 
            // LbCatalogo
            // 
            LbCatalogo.AutoSize = true;
            LbCatalogo.Font = new Font("Sitka Text", 13.5F);
            LbCatalogo.Location = new Point(3, 0);
            LbCatalogo.Name = "LbCatalogo";
            LbCatalogo.Size = new Size(109, 33);
            LbCatalogo.TabIndex = 0;
            LbCatalogo.Text = "Catálogo";
            // 
            // PnPagUser_catalogo
            // 
            PnPagUser_catalogo.Location = new Point(219, 3);
            PnPagUser_catalogo.Name = "PnPagUser_catalogo";
            PnPagUser_catalogo.Size = new Size(20, 125);
            PnPagUser_catalogo.TabIndex = 3;
            // 
            // Pncatalogo_HistLivro
            // 
            Pncatalogo_HistLivro.Location = new Point(363, 3);
            Pncatalogo_HistLivro.Name = "Pncatalogo_HistLivro";
            Pncatalogo_HistLivro.Size = new Size(20, 125);
            Pncatalogo_HistLivro.TabIndex = 4;
            // 
            // PnHist_Livro
            // 
            PnHist_Livro.Controls.Add(PnBarHistLivro);
            PnHist_Livro.Controls.Add(LbHistorico);
            PnHist_Livro.Location = new Point(389, 3);
            PnHist_Livro.Name = "PnHist_Livro";
            PnHist_Livro.Size = new Size(222, 48);
            PnHist_Livro.TabIndex = 3;
            // 
            // PnBarHistLivro
            // 
            PnBarHistLivro.Location = new Point(-15, 35);
            PnBarHistLivro.Name = "PnBarHistLivro";
            PnBarHistLivro.Size = new Size(250, 98);
            PnBarHistLivro.TabIndex = 2;
            // 
            // LbHistorico
            // 
            LbHistorico.AutoSize = true;
            LbHistorico.Font = new Font("Sitka Text", 13.5F);
            LbHistorico.Location = new Point(4, 0);
            LbHistorico.Name = "LbHistorico";
            LbHistorico.Size = new Size(218, 33);
            LbHistorico.TabIndex = 0;
            LbHistorico.Text = "histórico de Livros";
            // 
            // PnHistLivro_Reserv
            // 
            PnHistLivro_Reserv.Location = new Point(617, 3);
            PnHistLivro_Reserv.Name = "PnHistLivro_Reserv";
            PnHistLivro_Reserv.Size = new Size(20, 125);
            PnHistLivro_Reserv.TabIndex = 5;
            // 
            // PnReserv
            // 
            PnReserv.Controls.Add(PnBarReserv);
            PnReserv.Controls.Add(LbReserv);
            PnReserv.Location = new Point(643, 3);
            PnReserv.Name = "PnReserv";
            PnReserv.Size = new Size(174, 48);
            PnReserv.TabIndex = 4;
            // 
            // PnBarReserv
            // 
            PnBarReserv.Location = new Point(-15, 35);
            PnBarReserv.Name = "PnBarReserv";
            PnBarReserv.Size = new Size(250, 98);
            PnBarReserv.TabIndex = 2;
            // 
            // LbReserv
            // 
            LbReserv.AutoSize = true;
            LbReserv.Font = new Font("Sitka Text", 13.5F);
            LbReserv.Location = new Point(4, 0);
            LbReserv.Name = "LbReserv";
            LbReserv.Size = new Size(169, 33);
            LbReserv.TabIndex = 0;
            LbReserv.Text = "Suas Reservas";
            // 
            // PnReserv_Perguntas
            // 
            PnReserv_Perguntas.Location = new Point(823, 3);
            PnReserv_Perguntas.Name = "PnReserv_Perguntas";
            PnReserv_Perguntas.Size = new Size(20, 125);
            PnReserv_Perguntas.TabIndex = 6;
            // 
            // PnPerguntas
            // 
            PnPerguntas.Controls.Add(PnBarPerguntas);
            PnPerguntas.Controls.Add(LbPerguntas);
            PnPerguntas.Location = new Point(849, 3);
            PnPerguntas.Name = "PnPerguntas";
            PnPerguntas.Size = new Size(259, 48);
            PnPerguntas.TabIndex = 5;
            // 
            // PnBarPerguntas
            // 
            PnBarPerguntas.Location = new Point(-15, 35);
            PnBarPerguntas.Name = "PnBarPerguntas";
            PnBarPerguntas.Size = new Size(298, 98);
            PnBarPerguntas.TabIndex = 2;
            // 
            // LbPerguntas
            // 
            LbPerguntas.AutoSize = true;
            LbPerguntas.Font = new Font("Sitka Text", 13.5F);
            LbPerguntas.Location = new Point(4, 0);
            LbPerguntas.Name = "LbPerguntas";
            LbPerguntas.Size = new Size(252, 33);
            LbPerguntas.TabIndex = 0;
            LbPerguntas.Text = "Perguntas Frequentes";
            // 
            // FrmMean
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 945);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMean";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMean";
            Load += FrmMean_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbClose).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            PnPag_User.ResumeLayout(false);
            PnPag_User.PerformLayout();
            PnCatalogo.ResumeLayout(false);
            PnCatalogo.PerformLayout();
            PnHist_Livro.ResumeLayout(false);
            PnHist_Livro.PerformLayout();
            PnReserv.ResumeLayout(false);
            PnReserv.PerformLayout();
            PnPerguntas.ResumeLayout(false);
            PnPerguntas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox PbClose;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PnPag_User;
        private Panel PnBarPag_User;
        private Label LbUser;
        private Panel PnCatalogo;
        private Panel PnBarCatalogo;
        private Label LbCatalogo;
        private Panel PnPagUser_catalogo;
        private Panel Pncatalogo_HistLivro;
        private Panel PnHist_Livro;
        private Panel PnBarHistLivro;
        private Label LbHistorico;
        private Panel PnHistLivro_Reserv;
        private Panel PnReserv;
        private Panel PnBarReserv;
        private Label LbReserv;
        private Panel PnReserv_Perguntas;
        private Panel PnPerguntas;
        private Panel PnBarPerguntas;
        private Label LbPerguntas;
    }
}