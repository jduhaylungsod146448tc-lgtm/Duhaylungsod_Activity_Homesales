using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duhaylungsod_Activity_Homesales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalSales_Danielle = 0;
        private double totalSales_Edward = 0;
        private double totalSales_Fatima = 0;


        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            if (salesInitial == "D")
            {
                totalSales_Danielle += salesAmount;
                label_Result.Text = $"Updated Total Sales:\nDanielle: ₱{totalSales_Danielle}";
            }
            else if (salesInitial == "E")
            {
                totalSales_Edward += salesAmount;
                label_Result.Text = $"Updated Total Sales:\nEdward: ₱{totalSales_Edward}";
            }
            else if (salesInitial == "F")
            {
                totalSales_Fatima += salesAmount;
                label_Result.Text = $"Updated Total Sales:\nFatima: ₱{totalSales_Fatima}";
            }
            else
            {
                label_Result.Text = "Invalid Sales Person Initial.";
            }
        }
        

        private void clearEntry()
        {
            textBox_Initial.Text = "";
            textBox_AmountOfSale.Text = "";
            label_Result.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Submit_Click_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_Initial.Text, out double saleAmount))
            {
                getSalesPerson_Amount(textBox_Initial.Text, saleAmount);
            }
            else
            {
                label_Result.Text = "Please enter a valid number for the sale amount.";
            }
        }
        

        private void Btn_Clear_Click_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click_Click(object sender, EventArgs e)
        {
            string print = "";
            print += "Daniela: " + totalSales_Danielle + "\n";
            print += "Edward: " + totalSales_Edward + "\n";
            print += "Fatima: " + totalSales_Fatima + "\n\n";
            print += "Total: " + (totalSales_Danielle + totalSales_Edward + totalSales_Fatima);

            label_Result.Text = print;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
