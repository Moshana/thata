﻿using System;
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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClient frmClients = new frmClient();
            frmClients.ShowDialog();
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSupplier frmSupp = new frmSupplier();
            frmSupp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMSBRequestUnsuccessfull frmRU = new frmMSBRequestUnsuccessfull();
            frmRU.ShowDialog();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRawMaterial frmRawMat = new frmRawMaterial();
            frmRawMat.ShowDialog();
        }

        private void buttonAddEmployee_click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                //emp.EmployeeId = 1;//Convert.ToInt32(textBox3.Text);
                emp.EmployeeName = textBox9.Text;
                emp.EmployeeSurname = textBox8.Text;
                emp.EmployeePhone = textBox4.Text;
                emp.EmployeeAddress = textBox6.Text;
                emp.EmployeeEmail = textBox7.Text;

                new dbHelper().createEmployee(emp);
                MessageBox.Show("New Employee succesfully added!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                dbHelper dbh = new dbHelper();
                Employee emp = new Employee();
                emp.EmployeeName = this.textBox1.Text;
                emp.EmployeeSurname = this.textBox2.Text;

                DataSet empdata = dbh.getEmployee(emp);
                //this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = empdata.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}