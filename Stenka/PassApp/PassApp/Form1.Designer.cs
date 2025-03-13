namespace PassApp
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



        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            submit = new Button();
            stanowiskaLista = new ComboBox();
            label3 = new Label();
            nazwiskoInput = new TextBox();
            label2 = new Label();
            imieInput = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            genPass = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(submit);
            groupBox1.Controls.Add(stanowiskaLista);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nazwiskoInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(imieInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(103, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // submit
            // 
            submit.Location = new Point(72, 133);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 6;
            submit.Text = "Zatwierdź";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // stanowiskaLista
            // 
            stanowiskaLista.FormattingEnabled = true;
            stanowiskaLista.Items.AddRange(new object[] { "Młodszy programista", "Starszy programista", "Tester", "Kierownik" });
            stanowiskaLista.Location = new Point(83, 93);
            stanowiskaLista.Name = "stanowiskaLista";
            stanowiskaLista.Size = new Size(121, 23);
            stanowiskaLista.TabIndex = 5;
            stanowiskaLista.SelectedIndexChanged += stanowiskaLista_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 96);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Stanowisko";
            // 
            // nazwiskoInput
            // 
            nazwiskoInput.Location = new Point(83, 59);
            nazwiskoInput.Name = "nazwiskoInput";
            nazwiskoInput.Size = new Size(100, 23);
            nazwiskoInput.TabIndex = 3;
            nazwiskoInput.TextChanged += nazwiskoInput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwisko";
            // 
            // imieInput
            // 
            imieInput.Location = new Point(83, 26);
            imieInput.Name = "imieInput";
            imieInput.Size = new Size(100, 23);
            imieInput.TabIndex = 1;
            imieInput.TextChanged += imieInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(genPass);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(435, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // genPass
            // 
            genPass.Location = new Point(77, 133);
            genPass.Name = "genPass";
            genPass.Size = new Size(95, 23);
            genPass.TabIndex = 5;
            genPass.Text = "Generuj hasło";
            genPass.UseVisualStyleBackColor = true;
            genPass.Click += genPass_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(46, 108);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(105, 19);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "znaki specjalne";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(46, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(52, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "cyfry";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(46, 59);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "małe i wielkie litery";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 31);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 0;
            label4.Text = "Ile znaków?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
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
        private TextBox nazwiskoInput;
        private Label label2;
        private TextBox imieInput;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox stanowiskaLista;
        private Label label3;
        private Button submit;
        private TextBox textBox1;
        private Label label4;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private Button genPass;
    }
}
