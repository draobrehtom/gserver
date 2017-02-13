namespace GServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.execBtn = new System.Windows.Forms.Button();
            this.logRT = new System.Windows.Forms.RichTextBox();
            this.ipTxt = new System.Windows.Forms.TextBox();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.choiceBtn1 = new System.Windows.Forms.Button();
            this.choiceBtn2 = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // execBtn
            // 
            this.execBtn.Location = new System.Drawing.Point(118, 9);
            this.execBtn.Name = "execBtn";
            this.execBtn.Size = new System.Drawing.Size(75, 23);
            this.execBtn.TabIndex = 0;
            this.execBtn.Text = "Start server";
            this.execBtn.UseVisualStyleBackColor = true;
            this.execBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logRT
            // 
            this.logRT.Location = new System.Drawing.Point(12, 190);
            this.logRT.Name = "logRT";
            this.logRT.Size = new System.Drawing.Size(610, 157);
            this.logRT.TabIndex = 1;
            this.logRT.Text = "";
            // 
            // ipTxt
            // 
            this.ipTxt.Location = new System.Drawing.Point(12, 12);
            this.ipTxt.Name = "ipTxt";
            this.ipTxt.Size = new System.Drawing.Size(100, 20);
            this.ipTxt.TabIndex = 2;
            this.ipTxt.Text = "127.0.0.1";
            this.ipTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(12, 38);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(100, 20);
            this.portTxt.TabIndex = 3;
            this.portTxt.Text = "4567";
            this.portTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // choiceBtn1
            // 
            this.choiceBtn1.Location = new System.Drawing.Point(278, 38);
            this.choiceBtn1.Name = "choiceBtn1";
            this.choiceBtn1.Size = new System.Drawing.Size(169, 146);
            this.choiceBtn1.TabIndex = 4;
            this.choiceBtn1.Text = "button1";
            this.choiceBtn1.UseVisualStyleBackColor = true;
            this.choiceBtn1.Visible = false;
            this.choiceBtn1.Click += new System.EventHandler(this.choiceBtn1_Click);
            // 
            // choiceBtn2
            // 
            this.choiceBtn2.Location = new System.Drawing.Point(453, 38);
            this.choiceBtn2.Name = "choiceBtn2";
            this.choiceBtn2.Size = new System.Drawing.Size(169, 146);
            this.choiceBtn2.TabIndex = 5;
            this.choiceBtn2.Text = "button2";
            this.choiceBtn2.UseVisualStyleBackColor = true;
            this.choiceBtn2.Visible = false;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLbl.Location = new System.Drawing.Point(274, 9);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(51, 20);
            this.questionLbl.TabIndex = 6;
            this.questionLbl.Text = "label1";
            this.questionLbl.Visible = false;
            this.questionLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 359);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.choiceBtn2);
            this.Controls.Add(this.choiceBtn1);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.ipTxt);
            this.Controls.Add(this.logRT);
            this.Controls.Add(this.execBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button execBtn;
        public System.Windows.Forms.RichTextBox logRT;
        private System.Windows.Forms.TextBox ipTxt;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Button choiceBtn1;
        private System.Windows.Forms.Button choiceBtn2;
        private System.Windows.Forms.Label questionLbl;
    }
}

