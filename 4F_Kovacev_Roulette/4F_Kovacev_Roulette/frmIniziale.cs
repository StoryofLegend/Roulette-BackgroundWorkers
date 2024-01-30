using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4F_Kovacev_Roulette
{
    public partial class frmIniziale : Form
    {
        public frmIniziale()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Passo al Form del gioco
            frmGioco frm = new frmGioco();
            this.Hide();
            frm.Show();
        }
    }
}
