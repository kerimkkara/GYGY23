namespace SchoolApp
{
    partial class StudentProcesses
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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Ekleme Alanı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(116, 145);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 3;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 253);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 139);
            listBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 204);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci  Listesi";
            // 
            // button2
            // 
            button2.Location = new Point(141, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 55);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 7;
            label4.Text = "Öğrenciyi Derse Ekleme ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 225);
            label5.Name = "label5";
            label5.Size = new Size(154, 15);
            label5.TabIndex = 7;
            label5.Text = "Öğrenciyi Dersden Çıkarma ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 94);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 8;
            label6.Text = "Ders Seçiniz";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 280);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 8;
            label7.Text = "Ders Seçiniz";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(463, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(463, 277);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // StudentProcesses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentProcesses";
            Text = "StudentProcesses";
            Load += StudentProcesses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}