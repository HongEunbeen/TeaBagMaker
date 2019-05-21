using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]{"홍차","녹차", "루이보스차", "국화차"};
        string orgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.SList.Length; i++)
            {
                this.comboBox1.Items.Add(SList[i]);
            }
            this.orgStr = this.Time.Text; 

            if (SList.Count() > 1)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Time.Text != "")
            {
                comboBox1.Items.Add(this.Time.Text);
                MessageBox.Show("아이템을 추가하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Time.Text = "";
            }
            else
            {
                MessageBox.Show("아이템을 입력해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Time.Focus();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                this.Time.Text = this.orgStr + this.comboBox1.Text;
            }
        }
    }
}
