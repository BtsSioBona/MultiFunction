using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonPetitEditeur
{
    public partial class FrmEditeur : Form
    {
        public FrmEditeur()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.rtbAffiche.Dock = DockStyle.Fill;


            /*
            var toolMenu = new ToolStripMenuItem()
            {
                Name = "TlsFichier",
                Text = "Fichier"
            };
            var toolFichier = new ToolStripMenuItem()
            {
                Name = "TlsEdition",
                Text = "Edition"
            };
            MnuPrincipal.Items.Add(toolMenu);
            MnuPrincipal.Items.Add(toolFichier);

    */

        }
        private void afficheMenu(object sender, EventArgs e)
        {

        }
        private void rtbAffiche_TextChanged(object sender, EventArgs e)
        {

        }

        private void MnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
