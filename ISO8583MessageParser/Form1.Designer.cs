namespace ISO8583MessageParser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtMTI = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.txtB4 = new System.Windows.Forms.TextBox();
            this.txtB5 = new System.Windows.Forms.TextBox();
            this.txtB6 = new System.Windows.Forms.TextBox();
            this.txtB7 = new System.Windows.Forms.TextBox();
            this.txtB8 = new System.Windows.Forms.TextBox();
            this.txtB9 = new System.Windows.Forms.TextBox();
            this.txtB10 = new System.Windows.Forms.TextBox();
            this.txtB11 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.txtB11);
            this.groupBox1.Controls.Add(this.txtB10);
            this.groupBox1.Controls.Add(this.txtB9);
            this.groupBox1.Controls.Add(this.txtB8);
            this.groupBox1.Controls.Add(this.txtB7);
            this.groupBox1.Controls.Add(this.txtB6);
            this.groupBox1.Controls.Add(this.txtB5);
            this.groupBox1.Controls.Add(this.txtB4);
            this.groupBox1.Controls.Add(this.txtB3);
            this.groupBox1.Controls.Add(this.txtB2);
            this.groupBox1.Controls.Add(this.txtMTI);
            this.groupBox1.Controls.Add(this.txtHeader);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message Header";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MTI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blk 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Blk 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Blk 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Blk 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Blk 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Blk 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Blk 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Blk 9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Blk 10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Blk 11";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(113, 36);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(215, 20);
            this.txtHeader.TabIndex = 12;
            // 
            // txtMTI
            // 
            this.txtMTI.Location = new System.Drawing.Point(113, 64);
            this.txtMTI.Name = "txtMTI";
            this.txtMTI.Size = new System.Drawing.Size(215, 20);
            this.txtMTI.TabIndex = 13;
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(113, 92);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(215, 20);
            this.txtB2.TabIndex = 14;
            // 
            // txtB3
            // 
            this.txtB3.Location = new System.Drawing.Point(113, 120);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(215, 20);
            this.txtB3.TabIndex = 15;
            // 
            // txtB4
            // 
            this.txtB4.Location = new System.Drawing.Point(113, 148);
            this.txtB4.Name = "txtB4";
            this.txtB4.Size = new System.Drawing.Size(215, 20);
            this.txtB4.TabIndex = 16;
            // 
            // txtB5
            // 
            this.txtB5.Location = new System.Drawing.Point(113, 176);
            this.txtB5.Name = "txtB5";
            this.txtB5.Size = new System.Drawing.Size(215, 20);
            this.txtB5.TabIndex = 17;
            // 
            // txtB6
            // 
            this.txtB6.Location = new System.Drawing.Point(113, 204);
            this.txtB6.Name = "txtB6";
            this.txtB6.Size = new System.Drawing.Size(215, 20);
            this.txtB6.TabIndex = 18;
            // 
            // txtB7
            // 
            this.txtB7.Location = new System.Drawing.Point(113, 232);
            this.txtB7.Name = "txtB7";
            this.txtB7.Size = new System.Drawing.Size(215, 20);
            this.txtB7.TabIndex = 19;
            // 
            // txtB8
            // 
            this.txtB8.Location = new System.Drawing.Point(113, 260);
            this.txtB8.Name = "txtB8";
            this.txtB8.Size = new System.Drawing.Size(215, 20);
            this.txtB8.TabIndex = 20;
            // 
            // txtB9
            // 
            this.txtB9.Location = new System.Drawing.Point(113, 288);
            this.txtB9.Name = "txtB9";
            this.txtB9.Size = new System.Drawing.Size(215, 20);
            this.txtB9.TabIndex = 21;
            // 
            // txtB10
            // 
            this.txtB10.Location = new System.Drawing.Point(113, 316);
            this.txtB10.Name = "txtB10";
            this.txtB10.Size = new System.Drawing.Size(215, 20);
            this.txtB10.TabIndex = 22;
            // 
            // txtB11
            // 
            this.txtB11.Location = new System.Drawing.Point(113, 342);
            this.txtB11.Name = "txtB11";
            this.txtB11.Size = new System.Drawing.Size(215, 20);
            this.txtB11.TabIndex = 23;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(113, 369);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(215, 49);
            this.btnGenerate.TabIndex = 24;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnParse);
            this.groupBox2.Controls.Add(this.txtMsg);
            this.groupBox2.Location = new System.Drawing.Point(362, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ISO 8583 Message";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(17, 29);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(320, 318);
            this.txtMsg.TabIndex = 13;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(17, 353);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(215, 49);
            this.btnParse.TabIndex = 25;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtB11;
        private System.Windows.Forms.TextBox txtB10;
        private System.Windows.Forms.TextBox txtB9;
        private System.Windows.Forms.TextBox txtB8;
        private System.Windows.Forms.TextBox txtB7;
        private System.Windows.Forms.TextBox txtB6;
        private System.Windows.Forms.TextBox txtB5;
        private System.Windows.Forms.TextBox txtB4;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtMTI;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox txtMsg;
    }
}

