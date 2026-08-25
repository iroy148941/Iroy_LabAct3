using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iroy_LabAct3
{
    public partial class Form1 : Form
    {
        private static int sharedQueueCounter = 0;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Emergency");
            comboBox1.Items.Add("Senior");
            comboBox1.Items.Add("Pregnant");
            comboBox1.Items.Add("Regular");

            comboBox1.SelectedIndex = -1;

            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patientName = textBox1.Text.Trim();
            string patientAge = textBox2.Text.Trim();
            string reasonForVisit = textBox3.Text.Trim();
            string selectedType = comboBox1.Text.Trim();

            string priorityText = "";
            string formattedQueueNumber = "";

            if (patientName == "" ||
                patientAge == "" ||
                reasonForVisit == "" ||
                selectedType == "")
            {
                MessageBox.Show(
                    "Error: Please fill in all fields before adding to the queue.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            sharedQueueCounter++;

            formattedQueueNumber = "Q" + sharedQueueCounter.ToString("D3");

            if (selectedType == "Emergency")
            {
                priorityText = "EMERGENCY";
            }
            else if (selectedType == "Senior")
            {
                priorityText = "SENIOR PRIORITY";
            }
            else if (selectedType == "Pregnant")
            {
                priorityText = "PRIORITY";
            }
            else if (selectedType == "Regular")
            {
                priorityText = "REGULAR";
            }

            textBox4.Text = formattedQueueNumber;
            textBox5.Text = selectedType;
            textBox6.Text = priorityText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.SelectedIndex = -1;

            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
