using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]{"홍차","녹차", "루이보스차", "국화차"};
        string[] TList = new string[] { "2", "3", "5", "2" };
        string TimeResult = "";
        int CountOrgNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SList);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountOrgNum = Convert.ToInt32(TimeResult);
            Timer.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "홍차")
            {
                this.Time.Text = TList[0];
                TimeResult = TList[0];
            }
            else if (comboBox1.Text == "녹차")
            {
                this.Time.Text = TList[1];
                TimeResult = TList[1];
            }
            else if (comboBox1.Text == "루이보스차")
            {
                this.Time.Text = TList[2];
                TimeResult = TList[2];
            }
            else if (comboBox1.Text == "국화차")
            {
                this.Time.Text = TList[3];
                TimeResult = TList[3];
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.Time.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                CountOrgNum--;
                this.Time.Text = Convert.ToString(CountOrgNum);
            }
        }

    }
}
