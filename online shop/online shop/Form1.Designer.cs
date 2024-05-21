namespace online_shop
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(345, 121);
            button1.Name = "button1";
            button1.Size = new Size(238, 106);
            button1.TabIndex = 0;
            button1.Text = "اضافه کردن مشتری";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(101, 121);
            button2.Name = "button2";
            button2.Size = new Size(238, 106);
            button2.TabIndex = 1;
            button2.Text = "اضافه کردن محصول";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(345, 233);
            button3.Name = "button3";
            button3.Size = new Size(238, 106);
            button3.TabIndex = 2;
            button3.Text = "لیست مشتریان";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(101, 233);
            button4.Name = "button4";
            button4.Size = new Size(238, 106);
            button4.TabIndex = 3;
            button4.Text = "لیست محصولات";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(124, 61);
            label1.Name = "label1";
            label1.Size = new Size(435, 31);
            label1.TabIndex = 4;
            label1.Text = "برای دسترسی به بخش موردنظر خود کلیک کنید";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 432);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
