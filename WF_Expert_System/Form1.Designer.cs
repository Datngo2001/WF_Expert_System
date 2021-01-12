
namespace WF_Expert_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Edit_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.viewKnowLedge = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.End_editting_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_btn
            // 
            this.Edit_btn.AutoSize = true;
            this.Edit_btn.Location = new System.Drawing.Point(16, 434);
            this.Edit_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(217, 35);
            this.Edit_btn.TabIndex = 2;
            this.Edit_btn.Text = "Edit Know ledge";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.EditKnoledgeBase_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(741, 60);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(366, 340);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // viewKnowLedge
            // 
            this.viewKnowLedge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewKnowLedge.Location = new System.Drawing.Point(11, 502);
            this.viewKnowLedge.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.viewKnowLedge.Name = "viewKnowLedge";
            this.viewKnowLedge.ReadOnly = true;
            this.viewKnowLedge.Size = new System.Drawing.Size(1096, 299);
            this.viewKnowLedge.TabIndex = 5;
            this.viewKnowLedge.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "How do you feel ?";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(488, 60);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 34);
            this.Start.TabIndex = 15;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(488, 125);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(112, 34);
            this.Reset.TabIndex = 16;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(829, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Result";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(11, 60);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(345, 340);
            this.checkedListBox.TabIndex = 13;
            // 
            // End_editting_btn
            // 
            this.End_editting_btn.AutoSize = true;
            this.End_editting_btn.Location = new System.Drawing.Point(255, 434);
            this.End_editting_btn.Name = "End_editting_btn";
            this.End_editting_btn.Size = new System.Drawing.Size(186, 35);
            this.End_editting_btn.TabIndex = 18;
            this.End_editting_btn.Text = "End Editing";
            this.End_editting_btn.UseVisualStyleBackColor = true;
            this.End_editting_btn.Click += new System.EventHandler(this.End_editting_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.AutoSize = true;
            this.Save_btn.Location = new System.Drawing.Point(488, 434);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(112, 35);
            this.Save_btn.TabIndex = 19;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 814);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.End_editting_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.viewKnowLedge);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Edit_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Expert system: Diagnose the disease";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox viewKnowLedge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button End_editting_btn;
    }
}

