using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Exam_Task_3_Client
{
    public partial class Form1 : Form
    {
        ServiceReference.WebServiceSoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference.WebServiceSoapClient();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = client.sum(int.Parse(XtextBox.Text), int.Parse(YtextBox.Text)).ToString();
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = client.sub(int.Parse(XtextBox.Text), int.Parse(YtextBox.Text)).ToString();
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = client.mul(int.Parse(XtextBox.Text), int.Parse(YtextBox.Text)).ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            YtextBox.Text = "";
            XtextBox.Text = "";
        }
    }
}
