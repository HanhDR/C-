namespace baitap4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdai = new System.Windows.Forms.TextBox();
            this.txtrong = new System.Windows.Forms.TextBox();
            this.butn1 = new System.Windows.Forms.Button();
            this.butn2 = new System.Windows.Forms.Button();
            this.butclick = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butok = new System.Windows.Forms.Button();
            this.labtien = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.testcheck = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chieu dai HCN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chieu rong HCN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdai
            // 
            this.txtdai.Location = new System.Drawing.Point(258, 47);
            this.txtdai.Name = "txtdai";
            this.txtdai.Size = new System.Drawing.Size(130, 22);
            this.txtdai.TabIndex = 2;
            // 
            // txtrong
            // 
            this.txtrong.Location = new System.Drawing.Point(258, 93);
            this.txtrong.Name = "txtrong";
            this.txtrong.Size = new System.Drawing.Size(130, 22);
            this.txtrong.TabIndex = 3;
            // 
            // butn1
            // 
            this.butn1.Location = new System.Drawing.Point(92, 184);
            this.butn1.Name = "butn1";
            this.butn1.Size = new System.Drawing.Size(104, 49);
            this.butn1.TabIndex = 4;
            this.butn1.Text = "Tinh dien tich";
            this.butn1.UseVisualStyleBackColor = true;
            this.butn1.Click += new System.EventHandler(this.butn1_Click);
            // 
            // butn2
            // 
            this.butn2.Location = new System.Drawing.Point(284, 182);
            this.butn2.Name = "butn2";
            this.butn2.Size = new System.Drawing.Size(103, 50);
            this.butn2.TabIndex = 5;
            this.butn2.Text = "Tinh Chu Vi";
            this.butn2.UseVisualStyleBackColor = true;
            this.butn2.Click += new System.EventHandler(this.butn2_Click);
            // 
            // butclick
            // 
            this.butclick.Location = new System.Drawing.Point(517, 183);
            this.butclick.Name = "butclick";
            this.butclick.Size = new System.Drawing.Size(121, 49);
            this.butclick.TabIndex = 6;
            this.butclick.Text = "Click";
            this.butclick.UseVisualStyleBackColor = true;
            this.butclick.Click += new System.EventHandler(this.butclick_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(469, 277);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "yellow";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(469, 327);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "red";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(469, 373);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "blue";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(594, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 107);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // butok
            // 
            this.butok.Location = new System.Drawing.Point(481, 411);
            this.butok.Name = "butok";
            this.butok.Size = new System.Drawing.Size(143, 32);
            this.butok.TabIndex = 11;
            this.butok.Text = "OK";
            this.butok.UseVisualStyleBackColor = true;
            this.butok.Click += new System.EventHandler(this.butok_Click);
            // 
            // labtien
            // 
            this.labtien.AutoSize = true;
            this.labtien.Location = new System.Drawing.Point(334, 331);
            this.labtien.Name = "labtien";
            this.labtien.Size = new System.Drawing.Size(44, 16);
            this.labtien.TabIndex = 12;
            this.labtien.Text = "label3";
            this.labtien.Click += new System.EventHandler(this.labtien_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "ca";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 323);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "tom";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 372);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "cua";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // testcheck
            // 
            this.testcheck.AutoSize = true;
            this.testcheck.Location = new System.Drawing.Point(89, 323);
            this.testcheck.Name = "testcheck";
            this.testcheck.Size = new System.Drawing.Size(44, 16);
            this.testcheck.TabIndex = 16;
            this.testcheck.Text = "label3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Dep trai",
            "Cao to",
            "Den Hoi"});
            this.listBox1.Location = new System.Drawing.Point(191, 287);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 116);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.testcheck);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labtien);
            this.Controls.Add(this.butok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.butclick);
            this.Controls.Add(this.butn2);
            this.Controls.Add(this.butn1);
            this.Controls.Add(this.txtrong);
            this.Controls.Add(this.txtdai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdai;
        private System.Windows.Forms.TextBox txtrong;
        private System.Windows.Forms.Button butn1;
        private System.Windows.Forms.Button butn2;
        private System.Windows.Forms.Button butclick;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butok;
        private System.Windows.Forms.Label labtien;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label testcheck;
        private System.Windows.Forms.ListBox listBox1;
    }
}

