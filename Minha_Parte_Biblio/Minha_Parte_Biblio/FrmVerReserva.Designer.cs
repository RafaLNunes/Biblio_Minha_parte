namespace Minha_Parte_Biblio
{
    partial class FrmVerReserva
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerReserva));
            panel1 = new Panel();
            BntRefazer = new Button();
            panel2 = new Panel();
            BtnCancelar = new Button();
            dataGridView = new DataGridView();
            clPainelPersonalizado1 = new ClPainelPersonalizado();
            LbNome_Obra = new Label();
            LbDias = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            clPainelPersonalizado1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BntRefazer);
            panel1.Location = new Point(1172, 468);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 115);
            panel1.TabIndex = 0;
            // 
            // BntRefazer
            // 
            BntRefazer.FlatStyle = FlatStyle.Popup;
            BntRefazer.Location = new Point(-24, -29);
            BntRefazer.Name = "BntRefazer";
            BntRefazer.Size = new Size(245, 155);
            BntRefazer.TabIndex = 1;
            BntRefazer.UseVisualStyleBackColor = true;
            BntRefazer.Click += BntRefazer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(BtnCancelar);
            panel2.Location = new Point(1170, 600);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 101);
            panel2.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Location = new Point(-22, -11);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(232, 116);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Cross;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(965, 579);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.Click += dataGridView_Click;
            // 
            // clPainelPersonalizado1
            // 
            clPainelPersonalizado1.BackColor = Color.White;
            clPainelPersonalizado1.BorderRadius = 50;
            clPainelPersonalizado1.Controls.Add(dataGridView);
            clPainelPersonalizado1.ForeColor = Color.White;
            clPainelPersonalizado1.GradientAngle = 90;
            clPainelPersonalizado1.GradientBottomColor = Color.DodgerBlue;
            clPainelPersonalizado1.GradientTopColor = Color.DodgerBlue;
            clPainelPersonalizado1.Location = new Point(116, 140);
            clPainelPersonalizado1.Name = "clPainelPersonalizado1";
            clPainelPersonalizado1.Size = new Size(965, 579);
            clPainelPersonalizado1.TabIndex = 3;
            // 
            // LbNome_Obra
            // 
            LbNome_Obra.AutoSize = true;
            LbNome_Obra.BackColor = Color.White;
            LbNome_Obra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LbNome_Obra.ForeColor = Color.FromArgb(9, 90, 162);
            LbNome_Obra.Location = new Point(1192, 340);
            LbNome_Obra.Name = "LbNome_Obra";
            LbNome_Obra.Size = new Size(70, 28);
            LbNome_Obra.TabIndex = 4;
            LbNome_Obra.Text = "label1";
            // 
            // LbDias
            // 
            LbDias.AutoSize = true;
            LbDias.BackColor = Color.White;
            LbDias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LbDias.ForeColor = Color.FromArgb(9, 90, 162);
            LbDias.Location = new Point(1192, 426);
            LbDias.Name = "LbDias";
            LbDias.Size = new Size(76, 28);
            LbDias.TabIndex = 5;
            LbDias.Text = " label1";
            // 
            // FrmVerReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 756);
            Controls.Add(LbDias);
            Controls.Add(LbNome_Obra);
            Controls.Add(clPainelPersonalizado1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmVerReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVerReserva";
            Load += FrmVerReserva_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            clPainelPersonalizado1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BntRefazer;
        private Panel panel2;
        private Button BtnCancelar;
        private DataGridView dataGridView;
        private ClPainelPersonalizado clPainelPersonalizado1;
        private Label LbNome_Obra;
        private Label LbDias;
    }
}