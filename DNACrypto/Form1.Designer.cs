namespace DNACrypto
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.txtDNAEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRNA = new System.Windows.Forms.RadioButton();
            this.radDNA = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceDNAText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchASCII = new System.Windows.Forms.TextBox();
            this.btnSearchString = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplemenraryStrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtASCIIResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetASCIIFromStrand = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStrand1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStrand2 = new System.Windows.Forms.TextBox();
            this.btnGetLCS = new System.Windows.Forms.Button();
            this.txtLCSResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Words";
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(143, 17);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(230, 20);
            this.txtWords.TabIndex = 1;
            // 
            // txtDNAEncrypt
            // 
            this.txtDNAEncrypt.Location = new System.Drawing.Point(143, 43);
            this.txtDNAEncrypt.Multiline = true;
            this.txtDNAEncrypt.Name = "txtDNAEncrypt";
            this.txtDNAEncrypt.Size = new System.Drawing.Size(230, 80);
            this.txtDNAEncrypt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNA Encoded Words";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(388, 100);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 3;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRNA);
            this.groupBox1.Controls.Add(this.radDNA);
            this.groupBox1.Location = new System.Drawing.Point(388, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt Type";
            // 
            // radRNA
            // 
            this.radRNA.AutoSize = true;
            this.radRNA.Location = new System.Drawing.Point(7, 44);
            this.radRNA.Name = "radRNA";
            this.radRNA.Size = new System.Drawing.Size(111, 17);
            this.radRNA.TabIndex = 1;
            this.radRNA.Text = "RNA (Objective 2)";
            this.radRNA.UseVisualStyleBackColor = true;
            // 
            // radDNA
            // 
            this.radDNA.AutoSize = true;
            this.radDNA.Checked = true;
            this.radDNA.Location = new System.Drawing.Point(7, 20);
            this.radDNA.Name = "radDNA";
            this.radDNA.Size = new System.Drawing.Size(111, 17);
            this.radDNA.TabIndex = 0;
            this.radDNA.TabStop = true;
            this.radDNA.Text = "DNA (Objective 1)";
            this.radDNA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EnCoded DNA Word";
            // 
            // txtSourceDNAText
            // 
            this.txtSourceDNAText.Location = new System.Drawing.Point(18, 53);
            this.txtSourceDNAText.Name = "txtSourceDNAText";
            this.txtSourceDNAText.Size = new System.Drawing.Size(274, 20);
            this.txtSourceDNAText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ASCII String";
            // 
            // txtSearchASCII
            // 
            this.txtSearchASCII.Location = new System.Drawing.Point(18, 105);
            this.txtSearchASCII.Name = "txtSearchASCII";
            this.txtSearchASCII.Size = new System.Drawing.Size(274, 20);
            this.txtSearchASCII.TabIndex = 6;
            // 
            // btnSearchString
            // 
            this.btnSearchString.Location = new System.Drawing.Point(319, 53);
            this.btnSearchString.Name = "btnSearchString";
            this.btnSearchString.Size = new System.Drawing.Size(75, 72);
            this.btnSearchString.TabIndex = 7;
            this.btnSearchString.Text = "Search";
            this.btnSearchString.UseVisualStyleBackColor = true;
            this.btnSearchString.Click += new System.EventHandler(this.btnSearchString_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Index";
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(411, 91);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(97, 20);
            this.txtSearchIndex.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Complementary Strand";
            // 
            // txtComplemenraryStrand
            // 
            this.txtComplemenraryStrand.Location = new System.Drawing.Point(18, 51);
            this.txtComplemenraryStrand.Name = "txtComplemenraryStrand";
            this.txtComplemenraryStrand.Size = new System.Drawing.Size(274, 20);
            this.txtComplemenraryStrand.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ASCII String";
            // 
            // txtASCIIResult
            // 
            this.txtASCIIResult.Location = new System.Drawing.Point(19, 105);
            this.txtASCIIResult.Name = "txtASCIIResult";
            this.txtASCIIResult.Size = new System.Drawing.Size(274, 20);
            this.txtASCIIResult.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearchString);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSourceDNAText);
            this.groupBox2.Controls.Add(this.txtSearchASCII);
            this.groupBox2.Controls.Add(this.txtSearchIndex);
            this.groupBox2.Location = new System.Drawing.Point(27, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 143);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Objective 3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetASCIIFromStrand);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtComplemenraryStrand);
            this.groupBox3.Controls.Add(this.txtASCIIResult);
            this.groupBox3.Location = new System.Drawing.Point(27, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 159);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Objective 4";
            // 
            // btnGetASCIIFromStrand
            // 
            this.btnGetASCIIFromStrand.Location = new System.Drawing.Point(319, 51);
            this.btnGetASCIIFromStrand.Name = "btnGetASCIIFromStrand";
            this.btnGetASCIIFromStrand.Size = new System.Drawing.Size(75, 74);
            this.btnGetASCIIFromStrand.TabIndex = 7;
            this.btnGetASCIIFromStrand.Text = "Get ASCII";
            this.btnGetASCIIFromStrand.UseVisualStyleBackColor = true;
            this.btnGetASCIIFromStrand.Click += new System.EventHandler(this.btnGetASCIIFromStrand_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtLCSResult);
            this.groupBox4.Controls.Add(this.btnGetLCS);
            this.groupBox4.Controls.Add(this.txtStrand2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtStrand1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(27, 460);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 132);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Objective 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Strand 1";
            // 
            // txtStrand1
            // 
            this.txtStrand1.Location = new System.Drawing.Point(69, 32);
            this.txtStrand1.Name = "txtStrand1";
            this.txtStrand1.Size = new System.Drawing.Size(367, 20);
            this.txtStrand1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Strand 2";
            // 
            // txtStrand2
            // 
            this.txtStrand2.Location = new System.Drawing.Point(69, 58);
            this.txtStrand2.Name = "txtStrand2";
            this.txtStrand2.Size = new System.Drawing.Size(367, 20);
            this.txtStrand2.TabIndex = 1;
            // 
            // btnGetLCS
            // 
            this.btnGetLCS.Location = new System.Drawing.Point(442, 32);
            this.btnGetLCS.Name = "btnGetLCS";
            this.btnGetLCS.Size = new System.Drawing.Size(75, 46);
            this.btnGetLCS.TabIndex = 2;
            this.btnGetLCS.Text = "Get LCS";
            this.btnGetLCS.UseVisualStyleBackColor = true;
            this.btnGetLCS.Click += new System.EventHandler(this.btnGetLCS_Click);
            // 
            // txtLCSResult
            // 
            this.txtLCSResult.Location = new System.Drawing.Point(69, 89);
            this.txtLCSResult.Name = "txtLCSResult";
            this.txtLCSResult.Size = new System.Drawing.Size(308, 20);
            this.txtLCSResult.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 610);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtDNAEncrypt);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.TextBox txtDNAEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radRNA;
        private System.Windows.Forms.RadioButton radDNA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourceDNAText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchASCII;
        private System.Windows.Forms.Button btnSearchString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComplemenraryStrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtASCIIResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetASCIIFromStrand;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStrand2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStrand1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLCSResult;
        private System.Windows.Forms.Button btnGetLCS;
    }
}

