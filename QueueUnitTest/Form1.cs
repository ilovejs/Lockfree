using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lockfreeq;

namespace QueueUnitTest
{
    public partial class QueueUnitTest : Form
    {
        MSQueue< int > Q = new MSQueue< int >();

        public QueueUnitTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Q.enqueue(i);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayText.Text = "Idaho Edokpayi's Lock Free Queue Unit Test Suite";
            
            for(int i = 0; i < 10; i++)
            {
                int n = 0;
                DisplayText.Text += (Q.deque(ref n) ? " " + n.ToString() : "Queue is empty");
            }
        }

        private void ClearBttn_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "";
        }
    }
}