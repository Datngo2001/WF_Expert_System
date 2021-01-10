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
            //knowledgeBase = new KnowledgeBase(@"C:\Users\supod\source\repos\WF_Expert_System\WF_Expert_System\Knowlegde.txt");
            //inferenceEngine = new InferenceEngine(knowledgeBase);
            //checkedListBox = new CheckedListBox();
            //for (int i = 0; i < inferenceEngine.Base.Parameters.Count; i++)
            //{
            //    checkedListBox.Items.Add(inferenceEngine.Base.Parameters[i].Name, false);
            //}
            //Controls.Add(checkedListBox);
            //inferenceEngine.Start();
            //inferenceEngine.ShowResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button button = new Button();
            //listBox1.Items.Clear();
            //foreach (string s in checkedListBox.CheckedItems)
            //{
            //    listBox1.Items.Add(s);
            //}
            //contentchoiceListbox.Items.Clear();
            //for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            //{
            //    contentchoiceListbox.Items.Add(checkedListBox1.CheckedIndices[i] + 1);
            //}
            //richTextBox1.Text = "You should: ";
            ////foreach (int indexChecked in checkedListBox1.CheckedIndices)
            ////{
            ////    MessageBox.Show("Index: " + indexChecked.ToString() + ", is checked. Checked state is: " +
            ////        checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            ////}
            //bool test1 = false;
            //bool test6 = false;
            //for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            //{
            //    if(checkedListBox1.CheckedIndices[i] +1 ==1)
            //    {
            //     DialogResult result1 =  MessageBox.Show("Rát họng?","Chi tiết triệu chứng", MessageBoxButtons.YesNo); 
            //     DialogResult result2 = MessageBox.Show("Thường xuyên khát nước?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //     DialogResult result3 = MessageBox.Show("Bạn có đau đầu không?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        test1 = true; // Đã có triệu chứng 1
            //    }
            //    if (checkedListBox1.CheckedIndices[i] + 1 == 6)
            //    {
            //        DialogResult result4 = MessageBox.Show("Sốt cao?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        if (test1 == false) // Đã có triêu chứng 1 rồi thì ko hỏi nhức đầu hay ko nữa
            //        {
            //            DialogResult result3 = MessageBox.Show("Nhức đầu?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        }
            //        test6 = true;
            //    }
            //    if (checkedListBox1.CheckedIndices[i] + 1 == 8)
            //    {
            //        //if (test6 == true)
            //        //{
            //        //    DialogResult result4 = MessageBox.Show("Sốt cao?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //}
            //        //DialogResult result5 = MessageBox.Show("Ngạt mũi?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //DialogResult result6 = MessageBox.Show("Nhức âm ĩ vùng mặt?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //DialogResult result7 = MessageBox.Show("Ho có đờm?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);

            //        //if (test1 == false)
            //        //{
            //        //    DialogResult result1 = MessageBox.Show("Ngạt mũi?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //}
            //        //if(test6 == false)
            //        //{
            //        //    DialogResult result4 = MessageBox.Show("Sốt cao?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //}
            //        //DialogResult result8 = MessageBox.Show("Đau nhói vùng họng?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //DialogResult result9 = MessageBox.Show("Khan tiếng/ Tắt tiếng?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //        //DialogResult result10 = MessageBox.Show("Hôi hơi thở?", "Chi tiết triệu chứng", MessageBoxButtons.YesNo);
            //    }

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
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, false);
            //    contentchoiceListbox.Items.Clear();
            //    listBox1.Items.Clear();
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
