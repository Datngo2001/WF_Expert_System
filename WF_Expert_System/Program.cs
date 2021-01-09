using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Expert_System
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            KnowledgeBase knowledgeBase = new KnowledgeBase(@"C:\Users\supod\source\repos\WF_Expert_System\WF_Expert_System\Knowlegde.txt");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            InferenceEngine inferenceEngine = new InferenceEngine(knowledgeBase);
            inferenceEngine.Start();
            inferenceEngine.ShowResult();
        }
    }
}
