using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string customerName, contact, address, order, item;
            int quantity, price, totalBill;

            customerName = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;
            quantity = Convert.ToInt32(quantityTextBox.Text);
            item = orderComboBox.Text;


            if (orderComboBox.Text == "Black")
                price = 120;
            else if (orderComboBox.Text == "Cold")
                price = 100;
            else if (orderComboBox.Text == "Hot")
                price = 80;
            else
                price = 70;
            totalBill = price * quantity;
            if (orderComboBox.Text == "--select one--") ;
            else
                richTextBox.Text = "\n Customer Name:" + "\n" + "Contact Number:" + "\n" + "TotalBill";

        }
    }
}
