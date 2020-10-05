using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomProj;

namespace RandomProj
{
    public partial class Main_Snacks : Form
    {
        public Main_Snacks()
        {
            InitializeComponent();
        }

        private void btnSnack_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snack_Sale snack_Sale = new Snack_Sale();
            snack_Sale.ShowDialog();
        }
    }
}
