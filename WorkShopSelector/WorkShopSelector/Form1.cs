using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShopSelector
{
    public partial class Form1 : Form
    {
        int days = 0;
        int registrationFees = 0;
        int lodgingFees = 0;
        string workshopSelection;
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //VARIABLES
            //LOCATIONS & LODGING FEES
            if (locations.SelectedIndex == 0)
            {
                lodgingFees = 150;
                lodgingCostTextBox.Text = lodgingFees.ToString();
            }
            if (locations.SelectedIndex == 1)
            {
                lodgingFees = 225;
                lodgingCostTextBox.Text = lodgingFees.ToString();
            }
            if (locations.SelectedIndex == 2)
            {
                lodgingFees = 175;
                lodgingCostTextBox.Text = lodgingFees.ToString();
            }
            if (locations.SelectedIndex == 3)
            {
                lodgingFees = 300;
                lodgingCostTextBox.Text = lodgingFees.ToString();
            }
            if (locations.SelectedIndex == 4)
            {
                lodgingFees = 175;
                lodgingCostTextBox.Text = lodgingFees.ToString();
            }
            if (locations.SelectedIndex == 5)
            {
                lodgingFees = 150;
                lodgingCostTextBox.Text = lodgingFees.ToString();
            }
            //VARIABLES?
            int totalCost = 1;
            //WORKSHOPS, DAYS, REGISTRATION FEE, TOTAL COST
            if (Workshops.SelectedIndex != -1)
            {
                workshopSelection = Workshops.SelectedItem.ToString();
        
            }
            if (Workshops.SelectedIndex == 0)
            {
                days = 3;
                registrationFees = 1000;
                registrationCostTextBox.Text = registrationFees.ToString();
                totalCost = (days * lodgingFees) + registrationFees;
                totalCostTextBox.Text = totalCost.ToString();


            }
            if (Workshops.SelectedIndex == 1)
            {
                days = 3;
                registrationFees = 800;
                registrationCostTextBox.Text = registrationFees.ToString();
                totalCost = (days * lodgingFees) + registrationFees;
                totalCostTextBox.Text = totalCost.ToString();


            }
            if (Workshops.SelectedIndex == 2)
            {
                days = 3;
                registrationFees = 1500;
                registrationCostTextBox.Text = registrationFees.ToString();
                totalCost = (days * lodgingFees) + registrationFees;
                totalCostTextBox.Text = totalCost.ToString();


            }
            if (Workshops.SelectedIndex == 3)
            {
                days = 5;
                registrationFees = 1300;
                registrationCostTextBox.Text = registrationFees.ToString();
                totalCost = (days * lodgingFees) + registrationFees;
                totalCostTextBox.Text = totalCost.ToString();


            }
            if (Workshops.SelectedIndex == 4)
            {
                days = 1;
                registrationFees = 500;
                registrationCostTextBox.Text = registrationFees.ToString();
                totalCost = (days * lodgingFees) + registrationFees;
                totalCostTextBox.Text = totalCost.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
