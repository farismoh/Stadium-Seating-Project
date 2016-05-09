using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Constant fields
                const decimal CLASS_A = 15.00M;
                const decimal CLASS_B = 12.00M;
                const decimal CLASS_C = 9.00M;

                decimal ticketsSoldA; //To hold number of tickets sold for A
                decimal ticketsSoldB; //To hold number of tickets sold for B
                decimal ticketsSoldC; //To hold number of tickets sold for C
                decimal revenueA; //To hold revenue for A
                decimal revenueB; //To hold revenue for B
                decimal revenueC; //To hold revenue for C
                decimal totalRevenue; //To hold Total Revenue

                //Get tickets sold from TextBox
                ticketsSoldA = decimal.Parse(classATextBox.Text);
                ticketsSoldB = decimal.Parse(classBTextBox.Text);
                ticketsSoldC = decimal.Parse(classCTextBox.Text);

                //Calculate reveneue
                revenueA = ticketsSoldA * CLASS_A;
                revenueB = ticketsSoldB * CLASS_B;
                revenueC = ticketsSoldC * CLASS_C;

                //Calculate Total revenue
                totalRevenue = revenueA + revenueB + revenueC;

                //Display revenue in PromptLabel
                aPromptLabel.Text = revenueA.ToString("C");
                bPromptLabel.Text = revenueB.ToString("C");
                cPromptLabel.Text = revenueC.ToString("C");

                //Display Total revenue
                totalPromptLabel.Text = totalRevenue.ToString("C");
            }
            catch (Exception ex)
            {
                //Display the default error message.
                MessageBox.Show(ex.Message);
            }
            


            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes.
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";

            //Clear the PromptLabels. 
            aPromptLabel.Text = "";
            bPromptLabel.Text = "";
            cPromptLabel.Text = "";
            totalPromptLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
