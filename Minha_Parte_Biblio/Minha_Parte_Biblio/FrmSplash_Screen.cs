namespace Minha_Parte_Biblio

{
    public partial class FrmSplash_Screen : Form
    {

        int lbPorcent;
        public FrmSplash_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bar_Charge.Start();
            lbPorcent = PnBarCharge.MaximumSize.Width;
            lbPorcent = lbPorcent / 100;
        }

        private void Bar_Charge_Tick(object sender, EventArgs e)
        {
            while(PnCharge.MaximumSize.Width > PnCharge.Width)
            {
                PnCharge.Width += 1;
                
                LbPorcento.Text = lbPorcent.ToString() +"%";
            }
            Bar_Charge.Stop();
                
            
            FRMLogIn logIn = new FRMLogIn();
            this.Hide();
            logIn.ShowDialog();
           
        }

    }
}
