namespace usuario
{
    partial class FrmCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogo));
            FPConteinerCat = new FlowLayoutPanel();
            button1 = new Button();
            textPesquisa = new TextBox();
            SuspendLayout();
            // 
            // FPConteinerCat
            // 
            FPConteinerCat.AutoScroll = true;
            FPConteinerCat.BackColor = Color.Transparent;
            FPConteinerCat.Location = new Point(100, 124);
            FPConteinerCat.Name = "FPConteinerCat";
            FPConteinerCat.Size = new Size(1305, 633);
            FPConteinerCat.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(426, 66);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textPesquisa
            // 
            textPesquisa.BackColor = SystemColors.HotTrack;
            textPesquisa.ForeColor = Color.White;
            textPesquisa.Location = new Point(100, 68);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(320, 27);
            textPesquisa.TabIndex = 1;
            textPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // FrmCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1500, 785);
            Controls.Add(textPesquisa);
            Controls.Add(button1);
            Controls.Add(FPConteinerCat);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCatalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "estantelivros";
            Load += FrmCatalogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FPConteinerCat;
        private Button button1;
        private TextBox textPesquisa;
    }
}