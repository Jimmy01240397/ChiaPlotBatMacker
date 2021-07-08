namespace Chia耕地腳本產生器
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fpk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.finaldir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ppk = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fornum = new System.Windows.Forms.NumericUpDown();
            this.plotnum = new System.Windows.Forms.NumericUpDown();
            this.threadnum = new System.Windows.Forms.NumericUpDown();
            this.bucketnum = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timedelay = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Knum = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ram = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.finger = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fornum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucketnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "FarmerPublicKey";
            // 
            // fpk
            // 
            this.fpk.Location = new System.Drawing.Point(119, 78);
            this.fpk.Name = "fpk";
            this.fpk.Size = new System.Drawing.Size(452, 22);
            this.fpk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "平行耕地數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "耕地執行次數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "RAM(MB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thread";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "籃子大小";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "暫存目錄";
            // 
            // temp1
            // 
            this.temp1.Location = new System.Drawing.Point(119, 362);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(452, 22);
            this.temp1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "暫存目錄2(可略)";
            // 
            // temp2
            // 
            this.temp2.Location = new System.Drawing.Point(119, 396);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(452, 22);
            this.temp2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "最終目錄";
            // 
            // finaldir
            // 
            this.finaldir.Location = new System.Drawing.Point(119, 431);
            this.finaldir.Name = "finaldir";
            this.finaldir.Size = new System.Drawing.Size(452, 22);
            this.finaldir.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "PoolContractAddress";
            // 
            // ppk
            // 
            this.ppk.Location = new System.Drawing.Point(119, 112);
            this.ppk.Name = "ppk";
            this.ppk.Size = new System.Drawing.Size(452, 22);
            this.ppk.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "是否為每個平行耕地資料夾作區別";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(668, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(615, 314);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(748, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "匯出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveFile);
            // 
            // fornum
            // 
            this.fornum.Location = new System.Drawing.Point(119, 140);
            this.fornum.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.fornum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fornum.Name = "fornum";
            this.fornum.Size = new System.Drawing.Size(100, 22);
            this.fornum.TabIndex = 8;
            this.fornum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // plotnum
            // 
            this.plotnum.Location = new System.Drawing.Point(119, 227);
            this.plotnum.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.plotnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.plotnum.Name = "plotnum";
            this.plotnum.Size = new System.Drawing.Size(100, 22);
            this.plotnum.TabIndex = 9;
            this.plotnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // threadnum
            // 
            this.threadnum.Location = new System.Drawing.Point(119, 292);
            this.threadnum.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.threadnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadnum.Name = "threadnum";
            this.threadnum.Size = new System.Drawing.Size(100, 22);
            this.threadnum.TabIndex = 11;
            this.threadnum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // bucketnum
            // 
            this.bucketnum.Location = new System.Drawing.Point(119, 327);
            this.bucketnum.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.bucketnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bucketnum.Name = "bucketnum";
            this.bucketnum.Size = new System.Drawing.Size(100, 22);
            this.bucketnum.TabIndex = 12;
            this.bucketnum.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenFolder);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(577, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OpenFolder);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OpenFolder);
            // 
            // timedelay
            // 
            this.timedelay.Location = new System.Drawing.Point(119, 195);
            this.timedelay.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.timedelay.Name = "timedelay";
            this.timedelay.Size = new System.Drawing.Size(100, 22);
            this.timedelay.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "平行耕地延遲秒數";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "K值";
            // 
            // Knum
            // 
            this.Knum.Location = new System.Drawing.Point(119, 12);
            this.Knum.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.Knum.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.Knum.Name = "Knum";
            this.Knum.Size = new System.Drawing.Size(100, 22);
            this.Knum.TabIndex = 8;
            this.Knum.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 459);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 16);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "是否將最終目錄加入收耕";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "批次檔|*.bat";
            this.saveFileDialog1.Title = "匯出";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(667, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "匯入";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GetFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "批次檔|*.bat";
            this.openFileDialog1.Title = "匯入";
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(119, 259);
            this.ram.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.ram.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(100, 22);
            this.ram.TabIndex = 9;
            this.ram.Value = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "指紋(可略)";
            // 
            // finger
            // 
            this.finger.Location = new System.Drawing.Point(119, 45);
            this.finger.Name = "finger";
            this.finger.Size = new System.Drawing.Size(452, 22);
            this.finger.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 499);
            this.Controls.Add(this.timedelay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bucketnum);
            this.Controls.Add(this.threadnum);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.plotnum);
            this.Controls.Add(this.Knum);
            this.Controls.Add(this.fornum);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.finaldir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ppk);
            this.Controls.Add(this.finger);
            this.Controls.Add(this.fpk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fornum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucketnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timedelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fpk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox temp1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox temp2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox finaldir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ppk;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown fornum;
        private System.Windows.Forms.NumericUpDown plotnum;
        private System.Windows.Forms.NumericUpDown threadnum;
        private System.Windows.Forms.NumericUpDown bucketnum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown timedelay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Knum;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown ram;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox finger;
    }
}

