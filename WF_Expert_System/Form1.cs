using System;
using System.IO;
using System.Windows.Forms;

namespace WF_Expert_System
{
    
    public partial class Form1 : Form
    {
        private string path = @"Knowlegde.txt";
        private KnowledgeBase knowledgeBase;
        private InferenceEngine inferenceEngine;
        private string allKnowLedgeText;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initallize();
        }

        private void Initallize()
        {
            knowledgeBase = new KnowledgeBase(path);
            inferenceEngine = new InferenceEngine(knowledgeBase);
            for (int i = 0; i < inferenceEngine.Base.Parameters.Count; i++)
            {
                checkedListBox.Items.Add(inferenceEngine.Base.Parameters[i].Name, false);
            }
            allKnowLedgeText = knowledgeBase.AllText;
            viewKnowLedge.Text = "";
            viewKnowLedge.Text = allKnowLedgeText;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
            richTextBox1.Text = "";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox.CheckedIndices)
            {
                inferenceEngine.Base.Parameters[indexChecked].Value = true;
            }
            inferenceEngine.Facts.AddRange(inferenceEngine.Base.Parameters);
            inferenceEngine.Start();
            string ab = inferenceEngine.ShowResult();
            string a = "";
            string b = "";
            int i = 0;
            for (; i < ab.Length; i++)
            {
                if (ab[i] == '?')
                {
                    break;
                }
                else
                {
                    a += ab[i];
                }
            }
            for (int j = i + 1; j < ab.Length; j++)
            {
                b += ab[j];
            } // Tách a và b từ chuỗi ab (Với a là bệnh, b là lời khuyên)
            richTextBox1.Text = "Co the ban bi: \n" + a + "\n" + "Ban nen: \n" + b;
        }

        private void EditKnoledgeBase_Click(object sender, EventArgs e)
        {
            viewKnowLedge.ReadOnly = false;
        }

        private void End_editting_btn_Click(object sender, EventArgs e)
        {
            viewKnowLedge.ReadOnly = true;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(viewKnowLedge.Text);
            writer.Close();
            checkedListBox.Items.Clear();
            Initallize();
        }

    }
}
