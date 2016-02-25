using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*

 * if receiving data: 
 * display transmitting IP
 * ask user to accept
 * write file line by line 
*/
namespace OutputApp0
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcceptTransfer_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Transmission Found. Data Transfer in Progress...", "Success!"); 


            //Begin file tranfer.
            //read in & write out text file
            int counter=0;
            string line;
            //read
            StreamReader file = new StreamReader("zipcodes.txt");
            //write
            StreamWriter writer = new StreamWriter("output.txt");
                while((line=file.ReadLine()) != null)
                {
                               writer.WriteLine(line);
                               counter++;
                }
            file.Close();
            
            
            //done
            MessageBox.Show("Data Transfer Complete.", "Success!"); 
         
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if IP detected
            //MessageBox.Show("Transmission Found. Data Transfer in Progress...", "Success!"); 
            //else
            // MessageBox.Show("Error: Transmission Not Found", "Error!"); 
        }
    }
}
