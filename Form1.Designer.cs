namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.myName = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(659, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(296, 66);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "담그기!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(562, 295);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(109, 12);
            this.Date.TabIndex = 2;
            this.Date.Text = "제작일 : 2019.05.21";
            // 
            // myName
            // 
            this.myName.AutoSize = true;
            this.myName.Location = new System.Drawing.Point(562, 328);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(113, 12);
            this.myName.TabIndex = 3;
            this.myName.Text = "제작자 : 3617홍은빈";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(294, 115);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 12);
            this.Time.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 349);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.myName);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.button);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label myName;
        private System.Windows.Forms.Label Time;
    }
}

