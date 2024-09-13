using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class UcConjuntoLivro : UserControl
    {
        public UcConjuntoLivro()
        {
            InitializeComponent();
        }
        //margin: 20

        private PrivateFontCollection _fontCollection = new PrivateFontCollection();
        private void UcConjuntoLivro_Load(object sender, EventArgs e)
        {
            _fontCollection.AddFontFile("ChakraPetch-Regular.ttf");
        }
    }
}
