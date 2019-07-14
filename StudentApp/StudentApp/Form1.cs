using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentApp.Model.Model;
using StudentMnager.Manager;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string roll;
        Student student = new Student();
        SManager manager = new SManager();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            student.Name = nameTextBox.Text;
            student.RollNo = rollTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.Email = EmailTextBox.Text;

            if(SaveButton.Text.Equals("Update"))
            {
                manager.Update(student, roll);
                displayDataGridView.DataSource = manager.Show();
                SaveButton.Text = "Save";
                nameTextBox.Clear();
                rollTextBox.Clear();
                contactTextBox.Clear();
                EmailTextBox.Clear();
            }
            else
            {
                int isExecuted = manager.Save(student);
                if (isExecuted > 0)
                {
                    nameTextBox.Clear();
                    rollTextBox.Clear();
                    contactTextBox.Clear();
                    EmailTextBox.Clear();
                    displayDataGridView.DataSource = manager.Show();
                }
            }
           
        }

        private void displayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.displayDataGridView.Rows[e.RowIndex];
                nameTextBox.Text = row.Cells["Name"].Value.ToString();
                rollTextBox.Text = row.Cells["Roll"].Value.ToString();
                contactTextBox.Text = row.Cells["Contact"].Value.ToString();
                EmailTextBox.Text = row.Cells["Email"].Value.ToString();
                SaveButton.Text = "Update";

                roll = rollTextBox.Text;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            manager.Delete(roll);
            displayDataGridView.DataSource = manager.Show();
            nameTextBox.Clear();
            rollTextBox.Clear();
            contactTextBox.Clear();
            EmailTextBox.Clear();
            SaveButton.Text = "Save";
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string roll = rollTextBox.Text;
            DataTable dataTable;
            dataTable = manager.Search(roll);
            if (dataTable.Rows.Count > 0)
                displayDataGridView.DataSource = dataTable;
            else
                MessageBox.Show("No data found");
            rollTextBox.Clear();
        }
    }
}
