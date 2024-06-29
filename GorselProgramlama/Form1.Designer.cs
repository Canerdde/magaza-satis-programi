namespace GorselProgramlama
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            listBox5 = new ListBox();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Gömlek";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 26);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Pantolon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 26);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Ceket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 26);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Ayakkabı";
            // 
            // listBox1
            // 
            listBox1.ForeColor = SystemColors.WindowText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "", "Uzun Kol", "Kısa Kol", "Hakim Yaka" });
            listBox1.Location = new Point(196, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "", "Kot ", "Kumaş", "Deri" });
            listBox2.Location = new Point(520, 44);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "", "Keten", "Kumaş", "Kot" });
            listBox3.Location = new Point(357, 44);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 6;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Items.AddRange(new object[] { "", "Suni Deri", "Spor", "Haki Deri" });
            listBox4.Location = new Point(680, 44);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 94);
            listBox4.TabIndex = 7;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 159);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "FİYAT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 159);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 159);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 10;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(520, 159);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 11;
            label8.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(680, 159);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 12;
            label9.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(425, 191);
            button1.Name = "button1";
            button1.Size = new Size(146, 35);
            button1.TabIndex = 13;
            button1.Text = "SEPETE EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(107, 265);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(160, 124);
            listBox5.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(107, 247);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 15;
            label10.Text = "SEPETİNİZ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 412);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 16;
            label11.Text = "TOPLAM FİYAT";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(107, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 17;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(312, 265);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Öğrenci";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(293, 290);
            button2.Name = "button2";
            button2.Size = new Size(108, 47);
            button2.TabIndex = 19;
            button2.Text = "FATURA OLUŞTUR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(425, 263);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(322, 126);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 610);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(listBox5);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private ListBox listBox5;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}
