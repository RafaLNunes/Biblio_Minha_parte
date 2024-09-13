namespace Minha_Parte_Biblio
{
    partial class UcConjuntoLivro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcConjuntoLivro));
            PbLivro = new PictureBox();
            BntReserva = new BntCircle();
            LbNomeAutor = new Label();
            LbNomeLivro = new Label();
            ((System.ComponentModel.ISupportInitialize)PbLivro).BeginInit();
            SuspendLayout();
            // 
            // PbLivro
            // 
            PbLivro.BackColor = Color.Transparent;
            PbLivro.BackgroundImageLayout = ImageLayout.Center;
            PbLivro.Location = new Point(6, 26);
            PbLivro.MaximumSize = new Size(210, 263);
            PbLivro.MinimumSize = new Size(210, 263);
            PbLivro.Name = "PbLivro";
            PbLivro.Size = new Size(210, 263);
            PbLivro.SizeMode = PictureBoxSizeMode.Zoom;
            PbLivro.TabIndex = 0;
            PbLivro.TabStop = false;
            // 
            // BntReserva
            // 
            BntReserva.BackColor = Color.FromArgb(118, 136, 169);
            BntReserva.FlatAppearance.BorderSize = 0;
            BntReserva.FlatStyle = FlatStyle.Flat;
            BntReserva.Font = new Font("Square721 BT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BntReserva.Location = new Point(6, 370);
            BntReserva.Name = "BntReserva";
            BntReserva.Size = new Size(232, 65);
            BntReserva.TabIndex = 1;
            BntReserva.Text = "Iniciar Reserva";
            BntReserva.UseVisualStyleBackColor = false;
            // 
            // LbNomeAutor
            // 
            LbNomeAutor.AutoSize = true;
            LbNomeAutor.BackColor = Color.Transparent;
            LbNomeAutor.Location = new Point(108, 327);
            LbNomeAutor.Name = "LbNomeAutor";
            LbNomeAutor.Size = new Size(50, 20);
            LbNomeAutor.TabIndex = 2;
            LbNomeAutor.Text = "label1";
            // 
            // LbNomeLivro
            // 
            LbNomeLivro.AutoSize = true;
            LbNomeLivro.BackColor = Color.Transparent;
            LbNomeLivro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbNomeLivro.Location = new Point(6, 292);
            LbNomeLivro.Name = "LbNomeLivro";
            LbNomeLivro.Size = new Size(76, 31);
            LbNomeLivro.TabIndex = 3;
            LbNomeLivro.Text = "label2";
            // 
            // UcConjuntoLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(LbNomeLivro);
            Controls.Add(LbNomeAutor);
            Controls.Add(BntReserva);
            Controls.Add(PbLivro);
            MaximumSize = new Size(314, 438);
            MinimumSize = new Size(314, 438);
            Name = "UcConjuntoLivro";
            Size = new Size(314, 438);
            Load += UcConjuntoLivro_Load;
            ((System.ComponentModel.ISupportInitialize)PbLivro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbLivro;
        private BntCircle BntReserva;
        private Label LbNomeAutor;
        private Label LbNomeLivro;
    }
}
