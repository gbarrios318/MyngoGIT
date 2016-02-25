using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Code that might be useful
 * 
 * 
 * 
 * 
 * 
 */


namespace InputApp0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            /*
            //This button will check which flight status is chosen, and export the desired text file to the output app
            if(rbRunway.Checked)
            {
                //read in runway text file - export to IP Address
                string ip = txtIP.Text;

            }

            else if (rbWheelsUp.Checked)
            {
                //read in Wheels Up text file - export to IP Address
                string ip = txtIP.Text;

            }

            else if (rbCruising.Checked)
            {
                //read in Crusing file - export to IP Address
                string ip = txtIP.Text;

            }

            else if (rbLanding.Checked)
            {
                //read in Landing text file - export to IP Address
                string ip = txtIP.Text;

            }

            else if (rbEmergency.Checked)
            {
                //read in Emergency text file - export to IP Address
                string ip = txtIP.Text;

            }
            */

            //  using (StreamWriter writer = new StreamWriter(filename))
            //       writer.Write(...);


            //if found
            MessageBox.Show("Destination Found. Data Transfer in Progress...", "Success!"); 
            //else
            //MessageBox.Show("Error: Destination Not Found.", "Error!"); 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //This button will close the application
            Close();
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            //We can dowload an IP-specific textbox .dll online
 
        }
    }
}
