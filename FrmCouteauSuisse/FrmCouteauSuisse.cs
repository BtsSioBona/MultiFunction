using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonPetitEditeur;
using simpleList;
using lesNavires;

namespace FrmCouteauSuisse
{
    public partial class FrmCouteauSuisse : Form
    {
        public FrmCouteauSuisse()
        {
            InitializeComponent();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void btnEditeurText_Click(object sender, EventArgs e)
        {
            var frmEditeur = new FrmEditeur();
            frmEditeur.ShowDialog();
        }

        private void btnListes_Click(object sender, EventArgs e)
        {
            var frmListeSimple = new FrmListeSimple();
            frmListeSimple.ShowDialog();
        }

        private void btnGestionPorts_Click(object sender, EventArgs e)
        {
            var frmGestionNavire = new Frm_Gestion_Navire();
            frmGestionNavire.ShowDialog();
        }
    }
}
