using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopUsingList
{
   
    public partial class Form1 : Form
    {
        List<string> customerName = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<string> quantity = new List<string>();
        List<string> price = new List<string>();

        int totalPrice;
        string message = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            showRichTextBox.Clear();

            customerName.Add(customerNameTextBox.Text);
            contactNo.Add(ContactNoTextBox.Text);
            address.Add(addressTextBox.Text);
            order.Add(orderComboBox.Text);
            quantity.Add(quantityTextBox.Text);

            if (orderComboBox.SelectedItem.Equals("Math"))
                totalPrice = 120 * Convert.ToInt32(quantityTextBox.Text);
            else if(orderComboBox.SelectedItem.Equals("English"))
                totalPrice = 100 * Convert.ToInt32(quantityTextBox.Text);
            else
                totalPrice = 80 * Convert.ToInt32(quantityTextBox.Text);

            price.Add(Convert.ToString(totalPrice));
            int count = 1;
            int index = 0;

            foreach (string display in customerName)
            {
                showRichTextBox.SelectedText = "\n\t\tOrder " + count++ + " information";

                showRichTextBox.SelectedText = "\nCustomer Name : " +display;
                showRichTextBox.SelectedText = "\nContact No : " + contactNo[index];
                showRichTextBox.SelectedText = "\nAddress : " + address[index];
                showRichTextBox.SelectedText = "\nOrder : " + order[index];
                showRichTextBox.SelectedText = "\nQuantity : " + quantity[index];
                showRichTextBox.SelectedText = "\nTotal price : " + price[index];
                index++;

            }

            customerNameTextBox.Clear();
            ContactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantityTextBox.Clear();

        }
    }
}
