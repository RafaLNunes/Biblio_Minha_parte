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
        }

        private void Bar_Charge_Tick(object sender, EventArgs e)
        {
            while(PnCharge.MaximumSize.Width > PnCharge.Width)
            {
                PnCharge.Width += 1;
            }
            Bar_Charge.Stop();
                
            
            FRMLogIn logIn = new FRMLogIn();
            this.Hide();
            logIn.ShowDialog();
           
        }

    }
}
