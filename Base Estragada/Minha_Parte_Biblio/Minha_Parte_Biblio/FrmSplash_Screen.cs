namespace Minha_Parte_Biblio

{
    public partial class FrmSplash_Screen : Form
    {

        float lbintPorcent = 0;
        public FrmSplash_Screen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lbintPorcent = (100 * PnCharge.Width) / PnBarCharge.MaximumSize.Width;
            LbVisualPerct.Text = lbintPorcent.ToString() + '%';

            Bar_Charge.Start();


            /*
             *  100 ------- PnBarCharge.MaximumSize.Width
             *    x ------- PnBarCharge.Width
             *
             *   x * PnBarCharge.MaximumSize.Width = 100 * PnBarCharge.Width
             * 
             *   x = (100 * PnBarCharge.Width)/PnBarCharge.MaximumSize.Width
             *  
             * 
             */
        }

        private void Bar_Charge_Tick(object sender, EventArgs e)
        {
            while(PnCharge.MaximumSize.Width > PnCharge.Width)
            {
                PnCharge.Width += 1;
                lbintPorcent = 0;
                    //lbintPorcent = (100 * PnCharge.Width) / PnBarCharge.MaximumSize.Width;
                    //label1.Text = "";
                    //label1.Text = lbintPorcent.ToString() + "%";
            }
            Bar_Charge.Stop();
                
            
            FRMLogIn logIn = new FRMLogIn();
            this.Hide();
            logIn.ShowDialog();
           
        }

    }
}
