using System;

namespace baitap3
{
    partial class frmMain
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
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(212, 53);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(265, 26);
            this.txtht.TabIndex = 0;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(214, 110);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(64, 26);
            this.txtt.TabIndex = 1;
            this.txtt.Leave += new System.EventHandler(this.txtt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ho va ten:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tuoi";
            // 
            // but1
            // 
            this.but1.Enabled = false;
            this.but1.Location = new System.Drawing.Point(212, 175);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(82, 40);
            this.but1.TabIndex = 4;
            this.but1.Text = "Ok";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.Location = new System.Drawing.Point(393, 175);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(84, 40);
            this.but2.TabIndex = 5;
            this.but2.Text = "Close";
            this.but2.UseVisualStyleBackColor = true;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(654, 334);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtht);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EventHandler textBox1_TextChanged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txttuoi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
    }
}

