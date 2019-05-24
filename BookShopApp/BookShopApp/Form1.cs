using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string contactNo = contactNoTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            string quantity = quantityTextBox.Text;

            nameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.ResetText();
            quantityTextBox.Clear();

            showTextBox.Text = "\r\n\r\n\t\tOrder Information"+"\r\n\r\nName : "+ name + "\r\nContact No : " + contactNo +
                "\r\nAddress : " + address + "\r\nOrderd Items : " +order+ "\r\nQuantity : " + quantity;
           


        }
    }
}
