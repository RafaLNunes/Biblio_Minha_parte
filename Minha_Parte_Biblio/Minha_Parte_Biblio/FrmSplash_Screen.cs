namespace Minha_Parte_Biblio
{
    public partial class FrmSplash_Screen : Form
    {
        public FrmSplash_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bar_Charge.Start();
            Label_Charge_Down.Start();
        }

        private void Label_Charge_Tick(object sender, EventArgs e)
        {
            LbCharge.Top -= 5;
            if (LbCharge.Top <= 580)
            {
                Label_Charge_Up.Stop();
                Label_Charge_Down.Start();
            }
        }

        private void Bar_Charge_Tick(object sender, EventArgs e)
        {
            while(PnCharge.Width <= PnCharge.MaximumSize.Width)
            {
                PnCharge.Width += 1;
            }
            if(PnCharge.Width >= PnCharge.MaximumSize.Width) 
            { 
                FRMLogIn LogInFRM = new FRMLogIn();
                this.Hide();
                LogInFRM.ShowDialog();
            }
        }

        private void Label_Charge_Down_Tick(object sender, EventArgs e)
        {
            LbCharge.Top += 5;
            if (LbCharge.Top >= 600)
            {
                Label_Charge_Up.Start();
                Label_Charge_Down.Stop();
            }
        }
    }
}
