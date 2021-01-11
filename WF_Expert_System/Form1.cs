using System;
using System.Windows.Forms;

namespace WF_Expert_System
{
    
    public partial class Form1 : Form
    {
        KnowledgeBase knowledgeBase;
        InferenceEngine inferenceEngine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            knowledgeBase = new KnowledgeBase(@"C:\Users\admin\Source\Repos\WF_Expert_Systemoffz\WF_Expert_System\Knowlegde.txt");
            inferenceEngine = new InferenceEngine(knowledgeBase);
            for (int i = 0; i < inferenceEngine.Base.Parameters.Count; i++)
            {
                checkedListBox.Items.Add(inferenceEngine.Base.Parameters[i].Name, false);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox.CheckedIndices)
            {
                inferenceEngine.Base.Parameters[indexChecked].Value = true;
            }
            inferenceEngine.Facts.AddRange(inferenceEngine.Base.Parameters);
            inferenceEngine.Start();
            string ab =inferenceEngine.ShowResult();
            string a = "";
            string b = "";
            int i = 0;
            for(; i < ab.Length;i++)
            {
                if(ab[i]=='?')
                {
                    break;
                }
                else
                {
                    a += ab[i];
                }
            }
            for(int j = i+1;j<ab.Length;j++)
            {
                b += ab[j];
            } // Tách a và b từ chuỗi ab (Với a là bệnh, b là lời khuyên)
            richTextBox1.Text = "Co the ban bi: \n" + a + "\n" + "Ban nen: \n" + b; 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
