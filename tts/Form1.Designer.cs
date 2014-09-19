namespace tts
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contentTxtBox = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.folderPathLbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.defaultRbtn = new System.Windows.Forms.RadioButton();
            this.customRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentTxtBox
            // 
            this.contentTxtBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentTxtBox.Location = new System.Drawing.Point(6, 25);
            this.contentTxtBox.Multiline = true;
            this.contentTxtBox.Name = "contentTxtBox";
            this.contentTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contentTxtBox.Size = new System.Drawing.Size(524, 407);
            this.contentTxtBox.TabIndex = 0;
            this.contentTxtBox.WordWrap = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(18, 542);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 39);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "开始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(156, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "1.请先选择文件保存位置\r\n\r\n2.一行一个单词或句子\r\n\r\n3.男声:henry 女声:catherine";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contentTxtBox);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 438);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "内容";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selectFolderBtn);
            this.groupBox3.Controls.Add(this.folderPathLbl);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox3.Location = new System.Drawing.Point(13, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 52);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件保存位置";
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(454, 20);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFolderBtn.TabIndex = 1;
            this.selectFolderBtn.Text = "选择";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // folderPathLbl
            // 
            this.folderPathLbl.AutoSize = true;
            this.folderPathLbl.Location = new System.Drawing.Point(11, 24);
            this.folderPathLbl.Name = "folderPathLbl";
            this.folderPathLbl.Size = new System.Drawing.Size(41, 12);
            this.folderPathLbl.TabIndex = 0;
            this.folderPathLbl.Text = "未选择";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.statusTxtBox);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox4.Location = new System.Drawing.Point(554, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 438);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "处理状态";
            // 
            // statusTxtBox
            // 
            this.statusTxtBox.Location = new System.Drawing.Point(6, 25);
            this.statusTxtBox.Multiline = true;
            this.statusTxtBox.Name = "statusTxtBox";
            this.statusTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.statusTxtBox.Size = new System.Drawing.Size(188, 407);
            this.statusTxtBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(378, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 70);
            this.label2.TabIndex = 8;
            this.label2.Text = "henry#hello world 这样会生成男声\r\n\r\ncatherine#hello world 这样会生成女声\r\n\r\nhello world 这样默认是女声" +
    "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customRbtn);
            this.groupBox2.Controls.Add(this.defaultRbtn);
            this.groupBox2.Location = new System.Drawing.Point(554, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 52);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生成规则";
            // 
            // defaultRbtn
            // 
            this.defaultRbtn.AutoSize = true;
            this.defaultRbtn.Checked = true;
            this.defaultRbtn.Location = new System.Drawing.Point(6, 24);
            this.defaultRbtn.Name = "defaultRbtn";
            this.defaultRbtn.Size = new System.Drawing.Size(47, 16);
            this.defaultRbtn.TabIndex = 0;
            this.defaultRbtn.TabStop = true;
            this.defaultRbtn.Text = "默认";
            this.defaultRbtn.UseVisualStyleBackColor = true;
            // 
            // customRbtn
            // 
            this.customRbtn.AutoSize = true;
            this.customRbtn.Location = new System.Drawing.Point(55, 24);
            this.customRbtn.Name = "customRbtn";
            this.customRbtn.Size = new System.Drawing.Size(143, 16);
            this.customRbtn.TabIndex = 1;
            this.customRbtn.Text = "奇数行女声偶数行男声";
            this.customRbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "语音合成";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTxtBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.Label folderPathLbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox statusTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton defaultRbtn;
        private System.Windows.Forms.RadioButton customRbtn;
    }
}

