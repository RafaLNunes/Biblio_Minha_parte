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
            // FrmCatalogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1500, 785);
            Controls.Add(button1);
            Controls.Add(FPConteinerCat);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCatalogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "estantelivros";
            Load += FrmCatalogo_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FPConteinerCat;
        private Button button1;
    }
}