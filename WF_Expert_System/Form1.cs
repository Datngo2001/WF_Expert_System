using System;
using System.IO;
using System.Windows.Forms;

namespace WF_Expert_System
{
    
    public partial class Form1 : Form
    {
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
            knowledgeBase = new KnowledgeBase();
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
        }

        private void Start_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox.CheckedIndices)
            {
                inferenceEngine.Base.Parameters[indexChecked].Value = true;
            }
            inferenceEngine.Facts.AddRange(inferenceEngine.Base.Parameters);
            inferenceEngine.Start();
            inferenceEngine.ShowResult();
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
            FileStream file = new FileStream("Knowlegde.txt", FileMode.Create, FileAccess.ReadWrite);
            file.Close();
            StreamWriter writer = new StreamWriter(file.Name);
            writer.Write(viewKnowLedge.Text);
            writer.Close();
        }
    }
}
