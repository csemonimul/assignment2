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
            //string customerName, contact, address, order, item;
           // int quantity=0, price, totalBill;

           

        }

        private void butttonTextBox_Click(object sender, EventArgs e)
        {
            string customerName = nameTextBox.Text;
            string  contact = contactTextBox.Text;
            string address = addressTextBox.Text;
            string item = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
           

            int price = 0;
            int totalBill = 0;

            if (item == "Black")
                price = 120;
            else if (item == "Cold")
                price = 100;
            else if (item == "Hot")
                price = 90;
            else
                price = 80;

            totalBill = price * quantity;

            if (orderComboBox.Text == "--select one--")
                MessageBox.Show("Select an item");
            else
                richTextBox.Text = "\n Customer Name:" +customerName+  "\nContact Number:" +contact+ "\n" + "Address: "+address+"\norder:"+item+"\nQuantity:"+quantity+"\nTotal Price:"+totalBill; 
        }
    }
}
