namespace BaseConverter
{
    partial class f2ndConverter
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
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert10to2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConvert32 = new System.Windows.Forms.Button();
            this.txtFrom32 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(33, 30);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(100, 20);
            this.txt10.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(33, 73);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(260, 20);
            this.txt2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số âm - cơ số 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số âm - cơ số 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // btnConvert10to2
            // 
            this.btnConvert10to2.Location = new System.Drawing.Point(125, 99);
            this.btnConvert10to2.Name = "btnConvert10to2";
            this.btnConvert10to2.Size = new System.Drawing.Size(75, 23);
            this.btnConvert10to2.TabIndex = 5;
            this.btnConvert10to2.Text = "Chuyển đổi";
            this.btnConvert10to2.UseVisualStyleBackColor = true;
            this.btnConvert10to2.Click += new System.EventHandler(this.btnConvert10to2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(33, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lưu ý chỉ nhập phần số, không nhập phần dấu \"-\".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dấu chấm động";
            // 
            // btnConvert32
            // 
            this.btnConvert32.Location = new System.Drawing.Point(123, 204);
            this.btnConvert32.Name = "btnConvert32";
            this.btnConvert32.Size = new System.Drawing.Size(75, 23);
            this.btnConvert32.TabIndex = 12;
            this.btnConvert32.Text = "Chuyển đổi";
            this.btnConvert32.UseVisualStyleBackColor = true;
            this.btnConvert32.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFrom32
            // 
            this.txtFrom32.Location = new System.Drawing.Point(33, 178);
            this.txtFrom32.Name = "txtFrom32";
            this.txtFrom32.Size = new System.Drawing.Size(260, 20);
            this.txtFrom32.TabIndex = 13;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(98, 233);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(122, 20);
            this.txtResult.TabIndex = 14;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(223, 263);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // f2ndConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 298);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtFrom32);
            this.Controls.Add(this.btnConvert32);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert10to2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt10);
            this.Name = "f2ndConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển đổi khác";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f2ndConverter_FormClosing);
            this.Load += new System.EventHandler(this.f2ndConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert10to2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConvert32;
        private System.Windows.Forms.TextBox txtFrom32;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnBack;
    }
}