using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GServer
{
    public partial class Form1 : Form
    {
        Server server = new Server();
 

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }

        public static Form1 _Form1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!server.isStarted)
            {
                server = new Server(ipTxt.Text, Int32.Parse(portTxt.Text));
                server.Start();
                execBtn.Text = "Stop";
                questionLbl.Visible = true;
                choiceBtn1.Visible = true;
                choiceBtn2.Visible = true;

            } else
            {
                server.Stop();
                execBtn.Text = "Start";
                questionLbl.Visible = false;
                choiceBtn1.Visible = false;
                choiceBtn2.Visible = false;
            }
        }

        delegate void SetTextCallback(string text);

        public void update(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.logRT.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(update);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.logRT.Text += "\n" + text;
            }
        }

        public void updateQuestionLabel(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.questionLbl.InvokeRequired)
            {
                SetTextCallback dd = new SetTextCallback(updateQuestionLabel);
                this.Invoke(dd, new object[] { text });
            }
            else
            {
                this.questionLbl.Text = text;
            }
        }

        public void updateButtonLabel(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.choiceBtn1.InvokeRequired)
            {
                SetTextCallback dd = new SetTextCallback(updateButtonLabel);
                this.Invoke(dd, new object[] { text });
            }
            else
            {
                this.choiceBtn1.Text = text;
            }
        }
        public void updateButtonLabel2(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.choiceBtn2.InvokeRequired)
            {
                SetTextCallback dd = new SetTextCallback(updateButtonLabel2);
                this.Invoke(dd, new object[] { text });
            }
            else
            {
                this.choiceBtn2.Text = text;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void choiceBtn1_Click(object sender, EventArgs e)
        {

        }
    }
}
