namespace XiuxianGameManager
{
    partial class mapuniteditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.最大容纳人数 = new System.Windows.Forms.ComboBox();
            this.资源丰富度 = new System.Windows.Forms.ComboBox();
            this.资源级别 = new System.Windows.Forms.ComboBox();
            this.野生怪级别 = new System.Windows.Forms.ComboBox();
            this.是否安全区 = new System.Windows.Forms.ComboBox();
            this.进入权限 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.maparea = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.地名 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大容纳人数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "资源丰富度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "资源级别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "野生怪级别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否安全区";
            // 
            // 最大容纳人数
            // 
            this.最大容纳人数.FormattingEnabled = true;
            this.最大容纳人数.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "50",
            "100",
            "200",
            "500"});
            this.最大容纳人数.Location = new System.Drawing.Point(180, 123);
            this.最大容纳人数.Name = "最大容纳人数";
            this.最大容纳人数.Size = new System.Drawing.Size(182, 32);
            this.最大容纳人数.TabIndex = 5;
            // 
            // 资源丰富度
            // 
            this.资源丰富度.FormattingEnabled = true;
            this.资源丰富度.Items.AddRange(new object[] {
            "低",
            "较低",
            "中",
            "较高",
            "高",
            "极高"});
            this.资源丰富度.Location = new System.Drawing.Point(180, 171);
            this.资源丰富度.Name = "资源丰富度";
            this.资源丰富度.Size = new System.Drawing.Size(182, 32);
            this.资源丰富度.TabIndex = 6;
            // 
            // 资源级别
            // 
            this.资源级别.FormattingEnabled = true;
            this.资源级别.Items.AddRange(new object[] {
            "凡人",
            "炼器",
            "筑基",
            "金丹",
            "元婴"});
            this.资源级别.Location = new System.Drawing.Point(180, 222);
            this.资源级别.Name = "资源级别";
            this.资源级别.Size = new System.Drawing.Size(182, 32);
            this.资源级别.TabIndex = 7;
            // 
            // 野生怪级别
            // 
            this.野生怪级别.FormattingEnabled = true;
            this.野生怪级别.Items.AddRange(new object[] {
            "凡人",
            "炼器",
            "筑基",
            "金丹",
            "元婴"});
            this.野生怪级别.Location = new System.Drawing.Point(180, 280);
            this.野生怪级别.Name = "野生怪级别";
            this.野生怪级别.Size = new System.Drawing.Size(182, 32);
            this.野生怪级别.TabIndex = 8;
            // 
            // 是否安全区
            // 
            this.是否安全区.FormattingEnabled = true;
            this.是否安全区.Items.AddRange(new object[] {
            "是",
            "否"});
            this.是否安全区.Location = new System.Drawing.Point(180, 341);
            this.是否安全区.Name = "是否安全区";
            this.是否安全区.Size = new System.Drawing.Size(182, 32);
            this.是否安全区.TabIndex = 9;
            // 
            // 进入权限
            // 
            this.进入权限.FormattingEnabled = true;
            this.进入权限.Items.AddRange(new object[] {
            "仅玩家",
            "亲族",
            "朋友",
            "道侣",
            "所有人"});
            this.进入权限.Location = new System.Drawing.Point(180, 399);
            this.进入权限.Name = "进入权限";
            this.进入权限.Size = new System.Drawing.Size(182, 32);
            this.进入权限.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "进入权限";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "地图区域";
            // 
            // maparea
            // 
            this.maparea.AutoSize = true;
            this.maparea.Location = new System.Drawing.Point(154, 41);
            this.maparea.Name = "maparea";
            this.maparea.Size = new System.Drawing.Size(0, 24);
            this.maparea.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "地名";
            // 
            // 地名
            // 
            this.地名.Location = new System.Drawing.Point(180, 70);
            this.地名.Name = "地名";
            this.地名.Size = new System.Drawing.Size(182, 30);
            this.地名.TabIndex = 16;
            // 
            // mapuniteditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 526);
            this.Controls.Add(this.地名);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maparea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.进入权限);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.是否安全区);
            this.Controls.Add(this.野生怪级别);
            this.Controls.Add(this.资源级别);
            this.Controls.Add(this.资源丰富度);
            this.Controls.Add(this.最大容纳人数);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mapuniteditor";
            this.Text = "mapuniteditor";
            this.Load += new System.EventHandler(this.mapuniteditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox 最大容纳人数;
        private System.Windows.Forms.ComboBox 资源丰富度;
        private System.Windows.Forms.ComboBox 资源级别;
        private System.Windows.Forms.ComboBox 野生怪级别;
        private System.Windows.Forms.ComboBox 是否安全区;
        private System.Windows.Forms.ComboBox 进入权限;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label maparea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox 地名;
    }
}