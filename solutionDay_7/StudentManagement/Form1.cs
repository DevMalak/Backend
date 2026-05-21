using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        // 1. Initializing the list to store combined student data (Name and Age)
        List<string> list01 = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // --- Add Button Logic (button1) ---
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Note: From your Designer, textBox2 is Name and textBox3 is Age
                if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    string studentInfo = "Name: " + textBox2.Text + " | Age: " + textBox3.Text;
                    list01.Add(studentInfo);
                    UpdateDisplay(list01);

                    textBox2.Clear();
                    textBox3.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // --- Delete Button Logic (button2) ---
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                list01.RemoveAt(listBox1.SelectedIndex);
                UpdateDisplay(list01);
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        // --- Search Button Logic (button3) ---
        private void button3_Click(object sender, EventArgs e)
        {
            // Note: From your Designer, textBox1 is the Search field
            string searchWord = textBox1.Text.ToLower();
            List<string> filteredList = new List<string>();

            foreach (string item in list01)
            {
                if (item.ToLower().Contains(searchWord))
                {
                    filteredList.Add(item);
                }
            }
            UpdateDisplay(filteredList);
        }

        // --- Reusable method to update the ListBox ---
        private void UpdateDisplay(List<string> listToPrint)
        {
            listBox1.Items.Clear();
            foreach (string info in listToPrint)
            {
                listBox1.Items.Add(info);
            }
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}