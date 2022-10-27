namespace bai5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDL = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxfont = new System.Windows.Forms.ComboBox();
            this.cmboxsize = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labgiay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butstop = new System.Windows.Forms.Button();
            this.butstart = new System.Windows.Forms.Button();
            this.lbphut = new System.Windows.Forms.Label();
            this.labgio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Yellow",
            "Black"});
            this.comboBox1.Location = new System.Drawing.Point(111, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Red";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(351, 12);
            this.hScrollBar1.Maximum = 40;
            this.hScrollBar1.Minimum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(337, 37);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(351, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(538, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 4;
            this.label1.Tag = "";
            this.label1.Text = "Teo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhap DL";
            // 
            // lstDL
            // 
            this.lstDL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDL.FormattingEnabled = true;
            this.lstDL.ItemHeight = 23;
            this.lstDL.Items.AddRange(new object[] {
            "Hanh Dep Trai",
            "Anh Dep Trai",
            "Trung Dep Trai"});
            this.lstDL.Location = new System.Drawing.Point(22, 141);
            this.lstDL.Name = "lstDL";
            this.lstDL.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDL.Size = new System.Drawing.Size(172, 119);
            this.lstDL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Font";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size";
            // 
            // cboxfont
            // 
            this.cboxfont.FormattingEnabled = true;
            this.cboxfont.Items.AddRange(new object[] {
            "Times New Roman",
            "Tahoma",
            "Arial"});
            this.cboxfont.Location = new System.Drawing.Point(79, 279);
            this.cboxfont.Name = "cboxfont";
            this.cboxfont.Size = new System.Drawing.Size(115, 28);
            this.cboxfont.TabIndex = 9;
            // 
            // cmboxsize
            // 
            this.cmboxsize.FormattingEnabled = true;
            this.cmboxsize.Items.AddRange(new object[] {
            "12",
            "15",
            "20",
            "25",
            "30"});
            this.cmboxsize.Location = new System.Drawing.Point(79, 329);
            this.cmboxsize.Name = "cmboxsize";
            this.cmboxsize.Size = new System.Drawing.Size(115, 28);
            this.cmboxsize.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labgiay
            // 
            this.labgiay.AutoSize = true;
            this.labgiay.Location = new System.Drawing.Point(557, 201);
            this.labgiay.Name = "labgiay";
            this.labgiay.Size = new System.Drawing.Size(17, 20);
            this.labgiay.TabIndex = 12;
            this.labgiay.Text = "0";
            this.labgiay.Click += new System.EventHandler(this.lblKQ_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butstop
            // 
            this.butstop.Location = new System.Drawing.Point(456, 257);
            this.butstop.Name = "butstop";
            this.butstop.Size = new System.Drawing.Size(72, 45);
            this.butstop.TabIndex = 13;
            this.butstop.Text = "Stop";
            this.butstop.UseVisualStyleBackColor = true;
            this.butstop.Click += new System.EventHandler(this.butstop_Click);
            // 
            // butstart
            // 
            this.butstart.Location = new System.Drawing.Point(547, 258);
            this.butstart.Name = "butstart";
            this.butstart.Size = new System.Drawing.Size(76, 42);
            this.butstart.TabIndex = 14;
            this.butstart.Text = "Start";
            this.butstart.UseVisualStyleBackColor = true;
            this.butstart.Click += new System.EventHandler(this.butstart_Click);
            // 
            // lbphut
            // 
            this.lbphut.AutoSize = true;
            this.lbphut.Location = new System.Drawing.Point(526, 201);
            this.lbphut.Name = "lbphut";
            this.lbphut.Size = new System.Drawing.Size(17, 20);
            this.lbphut.TabIndex = 15;
            this.lbphut.Text = "0";
            // 
            // labgio
            // 
            this.labgio.AutoSize = true;
            this.labgio.Location = new System.Drawing.Point(491, 201);
            this.labgio.Name = "labgio";
            this.labgio.Size = new System.Drawing.Size(17, 20);
            this.labgio.TabIndex = 16;
            this.labgio.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Location = new System.Drawing.Point(309, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 38);
            this.button3.TabIndex = 18;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labden
            // 
            this.labden.AutoSize = true;
            this.labden.Location = new System.Drawing.Point(323, 287);
            this.labden.Name = "labden";
            this.labden.Size = new System.Drawing.Size(25, 20);
            this.labden.TabIndex = 20;
            this.labden.Text = "30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labden);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labgio);
            this.Controls.Add(this.lbphut);
            this.Controls.Add(this.butstart);
            this.Controls.Add(this.butstop);
            this.Controls.Add(this.labgiay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmboxsize);
            this.Controls.Add(this.cboxfont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstDL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private HScrollBar hScrollBar1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ListBox lstDL;
        private Label label3;
        private Label label4;
        private ComboBox cboxfont;
        private ComboBox cmboxsize;
        private Button button2;
        private Label labgiay;
        private System.Windows.Forms.Timer timer1;
        private Button butstop;
        private Button butstart;
        private Label lbphut;
        private Label labgio;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer2;
        private Label labden;
    }
}