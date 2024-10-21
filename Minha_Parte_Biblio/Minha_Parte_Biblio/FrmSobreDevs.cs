using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class FrmSobreDevs : Form
    {
        public FrmSobreDevs()
        {
            System.Diagnostics.Process.Start("");
            InitializeComponent();
        }

        string AdStrEmail = "adamfap2021@gmail.com";
        string RaStrEmail = "rafaf.code@gmail.com";
        string GaStrEmail = "gabioliva2007@gmail.com";

        string AdStrGit = "https://github.com/Adam2005Prado";
        string RaStrGit = "https://github.com/RafaLNunes";
        string GaStrGit = "https://github.com/gabrieldeoliveira1";

        string AdStrLinkdn = "https://www.linkedin.com/in/adam-prado-5b5159244";
        string RaStrLinkdn = "https://www.linkedin.com/in/rafael-nunes-aa77b6309/";
        string GaStrLinkdn = "https://www.linkedin.com/in/gabriel-de-oliveira-9a8321268/";


        private void AdLbEmail_Click(object sender, EventArgs e)
        {

        }

        private void RaLbEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void GaLbEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AdLbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(AdStrGit);
        }

        private void RaLbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(RaStrGit);
        }

        private void GaLbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GaStrGit);
        }

        private void AdLbLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(AdStrLinkdn);
        }

        private void RaLbLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(RaStrLinkdn);
        }

        private void GaLbLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(GaStrLinkdn);
        }

        private void AdLbEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
