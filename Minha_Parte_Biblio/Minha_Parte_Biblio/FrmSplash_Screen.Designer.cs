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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash_Screen));
            PnBarCharge = new Panel();
            PnCharge = new Panel();
            Bar_Charge = new System.Windows.Forms.Timer(components);
            LbVisualPerct = new Label();
            label1 = new Label();
            PnBarCharge.SuspendLayout();
            SuspendLayout();
            // 
            // PnBarCharge
            // 
            PnBarCharge.BackColor = Color.Transparent;
            PnBarCharge.BorderStyle = BorderStyle.Fixed3D;
            PnBarCharge.Controls.Add(PnCharge);
            PnBarCharge.Location = new Point(81, 701);
            PnBarCharge.MaximumSize = new Size(1300, 13);
            PnBarCharge.MinimumSize = new Size(1300, 13);
            PnBarCharge.Name = "PnBarCharge";
            PnBarCharge.Size = new Size(1300, 13);
            PnBarCharge.TabIndex = 0;
            // 
            // PnCharge
            // 
            PnCharge.BackColor = Color.White;
            PnCharge.Location = new Point(-6, -15);
            PnCharge.MaximumSize = new Size(1311, 50);
            PnCharge.MinimumSize = new Size(10, 50);
            PnCharge.Name = "PnCharge";
            PnCharge.Size = new Size(10, 50);
            PnCharge.TabIndex = 1;
            // 
            // Bar_Charge
            // 
            Bar_Charge.Enabled = true;
            Bar_Charge.Interval = 50;
            Bar_Charge.Tick += Bar_Charge_Tick;
            // 
            // LbVisualPerct
            // 
            LbVisualPerct.AutoSize = true;
            LbVisualPerct.BackColor = Color.Transparent;
            LbVisualPerct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbVisualPerct.Location = new Point(1316, 738);
            LbVisualPerct.Name = "LbVisualPerct";
            LbVisualPerct.Size = new Size(0, 28);
            LbVisualPerct.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1148, 752);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // FrmSplash_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1497, 898);
            Controls.Add(label1);
            Controls.Add(LbVisualPerct);
            Controls.Add(PnBarCharge);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSplash_Screen";
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
        private Label LbVisualPerct;
        private Label label1;
    }
}
