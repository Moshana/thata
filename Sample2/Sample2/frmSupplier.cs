using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample2
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRental frmRent = new frmRental();
            frmRent.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManufacturing frmMan = new frmManufacturing();
            frmMan.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSale frmSales = new frmSale();
            frmSales.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManufacturing frmAlteration = new frmManufacturing();
            frmAlteration.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient frmClients = new frmClient();
            frmClients.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmMSBRequestUnsuccessfull frmRU = new frmMSBRequestUnsuccessfull();
            frmRU.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee frmEmployees = new frmEmployee();
            frmEmployees.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserAccess frmAdmin = new frmUserAccess();
            frmAdmin.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportingMain frmReport = new frmReportingMain();
            frmReport.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBackupRestore frmBR = new frmBackupRestore();
            frmBR.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRawMaterial frmRawMat = new frmRawMaterial();
            frmRawMat.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStock frmStocks = new frmStock();
            frmStocks.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frmClose = new frmDashboard();
            frmClose.ShowDialog();
        }
    }
}
