namespace Minha_Parte_Biblio
{
    partial class FrmSplash_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PnBarCharge = new Panel();
            PnCharge = new Panel();
            Bar_Charge = new System.Windows.Forms.Timer(components);
            Label_Charge_Up = new System.Windows.Forms.Timer(components);
            LbCharge = new Label();
            Label_Charge_Down = new System.Windows.Forms.Timer(components);
            PnBarCharge.SuspendLayout();
            SuspendLayout();
            // 
            // PnBarCharge
            // 
            PnBarCharge.BackColor = Color.Transparent;
            PnBarCharge.BorderStyle = BorderStyle.Fixed3D;
            PnBarCharge.Controls.Add(PnCharge);
            PnBarCharge.Location = new Point(300, 681);
            PnBarCharge.Name = "PnBarCharge";
            PnBarCharge.Size = new Size(900, 25);
            PnBarCharge.TabIndex = 0;
            // 
            // PnCharge
            // 
            PnCharge.BackColor = Color.FromArgb(204, 167, 141);
            PnCharge.Location = new Point(-6, -15);
            PnCharge.MaximumSize = new Size(910, 50);
            PnCharge.MinimumSize = new Size(10, 50);
            PnCharge.Name = "PnCharge";
            PnCharge.Size = new Size(10, 50);
            PnCharge.TabIndex = 1;
            // 
            // Bar_Charge
            // 
            Bar_Charge.Enabled = true;
            Bar_Charge.Interval = 200;
            Bar_Charge.Tick += Bar_Charge_Tick;
            // 
            // Label_Charge_Up
            // 
            Label_Charge_Up.Enabled = true;
            Label_Charge_Up.Interval = 10;
            Label_Charge_Up.Tick += Label_Charge_Tick;
            // 
            // LbCharge
            // 
            LbCharge.AutoSize = true;
            LbCharge.BackColor = Color.Transparent;
            LbCharge.Font = new Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LbCharge.ForeColor = Color.Black;
            LbCharge.Location = new Point(393, 600);
            LbCharge.Name = "LbCharge";
            LbCharge.Size = new Size(724, 74);
            LbCharge.TabIndex = 2;
            LbCharge.Text = "Carregando Arquivos";
            // 
            // Label_Charge_Down
            // 
            Label_Charge_Down.Enabled = true;
            Label_Charge_Down.Interval = 10;
            Label_Charge_Down.Tick += Label_Charge_Down_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SPLASH_SCREEN;
            ClientSize = new Size(1497, 898);
            Controls.Add(LbCharge);
            Controls.Add(PnBarCharge);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            PnBarCharge.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnBarCharge;
        private Panel PnCharge;
        private System.Windows.Forms.Timer Bar_Charge;
        private System.Windows.Forms.Timer Label_Charge_Up;
        private Label LbCharge;
        private System.Windows.Forms.Timer Label_Charge_Down;
    }
}
