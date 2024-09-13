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
            SuspendLayout();
            // 
            // FPConteinerCat
            // 
            FPConteinerCat.AutoScroll = true;
            FPConteinerCat.BackColor = Color.Transparent;
            FPConteinerCat.Location = new Point(39, 116);
            FPConteinerCat.Name = "FPConteinerCat";
            FPConteinerCat.Size = new Size(1425, 633);
            FPConteinerCat.TabIndex = 0;
            FPConteinerCat.Paint += FPConteinerCat_Paint;
            // 
            // FrmCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1482, 772);
            Controls.Add(FPConteinerCat);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCatalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "estantelivros";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FPConteinerCat;
    }
}