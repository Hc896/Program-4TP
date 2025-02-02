namespace firstApp
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            geoInput = new TextBox();
            chemInput = new TextBox();
            label3 = new Label();
            fizInput = new TextBox();
            label2 = new Label();
            wfInput = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(geoInput);
            groupBox1.Controls.Add(chemInput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(fizInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(wfInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Przedmioty";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 153);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Geografia";
            // 
            // geoInput
            // 
            geoInput.Location = new Point(77, 150);
            geoInput.Name = "geoInput";
            geoInput.Size = new Size(100, 23);
            geoInput.TabIndex = 6;
            // 
            // chemInput
            // 
            chemInput.Location = new Point(77, 110);
            chemInput.Name = "chemInput";
            chemInput.Size = new Size(100, 23);
            chemInput.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Chemia";
            // 
            // fizInput
            // 
            fizInput.Location = new Point(77, 66);
            fizInput.Name = "fizInput";
            fizInput.Size = new Size(100, 23);
            fizInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 69);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Fizyka";
            // 
            // wfInput
            // 
            wfInput.Location = new Point(77, 25);
            wfInput.Name = "wfInput";
            wfInput.Size = new Size(100, 23);
            wfInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 28);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "WF";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(19, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Średnia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 63);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 1;
            label5.Text = "Tutaj będzie wynik";
            // 
            // button1
            // 
            button1.Location = new Point(51, 22);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 0;
            button1.Text = "Oblicz średnią";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 477);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox fizInput;
        private Label label2;
        private TextBox wfInput;
        private Label label1;
        private Label label4;
        private TextBox geoInput;
        private TextBox chemInput;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private Label label5;
    }
}
