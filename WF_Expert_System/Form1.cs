using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Expert_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
            contentchoiceListbox.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                contentchoiceListbox.Items.Add(checkedListBox1.CheckedIndices[i] + 1);
            }
            richTextBox1.Text = "You should: ";
            //foreach (int indexChecked in checkedListBox1.CheckedIndices)
            //{
            //    MessageBox.Show("Index: " + indexChecked.ToString() + ", is checked. Checked state is: " +
            //        checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            //}
        }  
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contentchoiceListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void button_clickReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
                contentchoiceListbox.Items.Clear();
                listBox1.Items.Clear();
            }
        }
    }
}
