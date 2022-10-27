namespace baitapcongtru
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
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.butxoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but1
            // 
            this.but1.Location = new System.Drawing.Point(235, 191);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(105, 56);
            this.but1.TabIndex = 0;
            this.but1.Text = "-";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(57, 191);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(105, 56);
            this.but2.TabIndex = 1;
            this.but2.Text = "+";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.Location = new System.Drawing.Point(411, 191);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(108, 56);
            this.but3.TabIndex = 2;
            this.but3.Text = "*";
            this.but3.UseVisualStyleBackColor = true;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // but4
            // 
            this.but4.Location = new System.Drawing.Point(612, 191);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(116, 56);
            this.but4.TabIndex = 3;
            this.but4.Text = "/";
            this.but4.UseVisualStyleBackColor = true;
            this.but4.Click += new System.EventHandler(this.but4_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(57, 48);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(163, 22);
            this.txt1.TabIndex = 4;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(307, 48);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(167, 22);
            this.txt2.TabIndex = 5;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(555, 48);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(162, 22);
            this.txt3.TabIndex = 6;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(328, 324);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(119, 54);
            this.butxoa.TabIndex = 7;
            this.butxoa.Text = "Delete";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button butxoa;
    }
}

