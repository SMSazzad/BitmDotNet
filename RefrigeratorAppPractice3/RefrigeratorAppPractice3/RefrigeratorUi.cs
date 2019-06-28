using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        Manage manage = new Manage();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(maxWeightTakeTextBox.Text))
            {
                maxWeightTakeTextBox.Text = "Enter max weight ";
                return;
            }
            double limit = Convert.ToDouble(maxWeightTakeTextBox.Text);
            manage.Limit = limit;

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {

                int numberItems = Convert.ToInt32(itemTextBox.Text);
                double weight = Convert.ToDouble(weightTextBox.Text);
                
                if (! manage.AddWeight(numberItems, weight))
                {
                    MessageBox.Show("Your given amount can’t be entered because it will be over flown.");
                    return;
                }
                else
                {
                    currentWeightTextBox.Text = Convert.ToString(manage.CurrentWeight());
                    remainingWeightTextBox.Text = Convert.ToString(manage.RemainingWeight());
                }
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}
