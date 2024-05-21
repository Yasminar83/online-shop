namespace online_shop
{
    partial class Form3
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 221);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 15;
            label4.Text = "شماره شناسایی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 163);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 14;
            label3.Text = "دسته بندی";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 93);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 13;
            label2.Text = "نام";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 38);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 12;
            label1.Text = "اطلاعات مربوط به محصول را وارد کنید";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(142, 277);
            button1.Name = "button1";
            button1.Size = new Size(100, 53);
            button1.TabIndex = 8;
            button1.Text = "ثبت اطلاعات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 366);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}