using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopOrder
{
    public partial class Form1 : Form
    {
        string customerName;
        string contactNo;
        string address;
        string order;
        string quantity;
        int newQuantity;
        int price;
        int customer = 0;
        string showMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string message;
            customerName = customerNameTextBox.Text;
            contactNo = contactNoTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;
            quantity = quantitYTextBox.Text;
            newQuantity = Convert.ToInt32(quantity);

            if (order == "Math")
                price = newQuantity * 120;

            else if (order == "Physics")
                price = newQuantity * 100;

            else if(order == "Chemestry")
                price = newQuantity * 80;

            message = "\n\n\t Customer " + ++customer + " information" + "\n\t __________________" +
                      "\n\n\t Customer name : "+customerName+"\n\t Contact No : "+contactNo+
                      "\n\t Address : "+address+ "\n\t Order : "+order+"\n\t Quantity : "+quantity+
                      "\n\t Price : "+Convert.ToString(price);

            showMessage = showMessage + message;
            showRichTextBox.Text = showMessage;

            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantitYTextBox.Clear();


        }

       
       
    }
}
