namespace Gorillaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 203);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 148);
            button1.Name = "button1";
            button1.Size = new Size(91, 82);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(674, 152);
            button2.Name = "button2";
            button2.Size = new Size(94, 74);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 72);
            label1.Name = "label1";
            label1.Size = new Size(258, 89);
            label1.TabIndex = 3;
            label1.Text = "Gorillaz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(343, 172);
            label2.Name = "label2";
            label2.Size = new Size(306, 54);
            label2.TabIndex = 4;
            label2.Text = "\"The Now Now\"";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.FromArgb(97, 217, 24);
            label3.Location = new Point(353, 244);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 5;
            label3.Text = "11 utworów";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.FromArgb(97, 217, 24);
            label4.Location = new Point(527, 244);
            label4.Name = "label4";
            label4.Size = new Size(77, 37);
            label4.TabIndex = 6;
            label4.Text = "2018";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.FromArgb(97, 217, 24);
            label5.Location = new Point(100, 313);
            label5.Name = "label5";
            label5.Size = new Size(137, 37);
            label5.TabIndex = 7;
            label5.Text = "11000102";
            label5.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(97, 217, 24);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(353, 351);
            button3.Name = "button3";
            button3.Size = new Size(81, 38);
            button3.TabIndex = 8;
            button3.Text = "Pobierz";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}
