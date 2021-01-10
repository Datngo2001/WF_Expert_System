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
        KnowledgeBase knowledgeBase;
        InferenceEngine inferenceEngine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            knowledgeBase = new KnowledgeBase(@"C:\Users\supod\source\repos\WF_Expert_System\WF_Expert_System\Knowlegde.txt");
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
        }
    }
}
