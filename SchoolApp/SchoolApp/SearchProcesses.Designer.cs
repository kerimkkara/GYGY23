namespace SchoolApp
{
    partial class SearchProcesses
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label6 = new Label();
            listBox1 = new ListBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            label8 = new Label();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Arama İşlemleri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 69);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Hangi Dersleri Alıyor\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 69);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Ders Hangi Sınıflarda\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 69);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 3;
            label4.Text = "Dersin Öğretmeni Kim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 109);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Öğrenci Seç";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(147, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 194);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "Sonuç";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(57, 234);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(165, 154);
            listBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(343, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 103);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 10;
            label7.Text = "Ders Seç";
            // 
            // button2
            // 
            button2.Location = new Point(389, 143);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(322, 194);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 12;
            label8.Text = "Sonuç";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(343, 234);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(164, 154);
            listBox2.TabIndex = 13;
            // 
            // SearchProcesses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchProcesses";
            Text = "SearchProcesses";
            Load += SearchProcesses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Label label6;
        private ListBox listBox1;
        private ComboBox comboBox2;
        private Label label7;
        private Button button2;
        private Label label8;
        private ListBox listBox2;
    }
}