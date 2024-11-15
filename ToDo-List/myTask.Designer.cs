namespace ToDo_List
{
    partial class myTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myTask));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            button9 = new Button();
            button10 = new Button();
            textBox3 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            textBox2 = new TextBox();
            button8 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            button11 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 42);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 40);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(361, 16);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 0;
            label2.Text = "© 2024 Hossein-GS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(636, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 369);
            panel3.TabIndex = 2;
            // 
            // button9
            // 
            button9.BackColor = Color.Red;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(156, 212);
            button9.Name = "button9";
            button9.Size = new Size(32, 23);
            button9.TabIndex = 12;
            button9.Text = "X";
            button9.UseVisualStyleBackColor = false;
            button9.Visible = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Chartreuse;
            button10.Location = new Point(127, 212);
            button10.Name = "button10";
            button10.Size = new Size(32, 23);
            button10.TabIndex = 11;
            button10.Text = "✔";
            button10.UseVisualStyleBackColor = false;
            button10.Visible = false;
            button10.Click += button10_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 10;
            textBox3.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(156, 132);
            button6.Name = "button6";
            button6.Size = new Size(32, 23);
            button6.TabIndex = 9;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Chartreuse;
            button7.Location = new Point(127, 132);
            button7.Name = "button7";
            button7.Size = new Size(32, 23);
            button7.TabIndex = 8;
            button7.Text = "✔";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 7;
            textBox2.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(46, 103);
            button8.Name = "button8";
            button8.Size = new Size(113, 23);
            button8.TabIndex = 6;
            button8.Text = "Add Section";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(156, 62);
            button5.Name = "button5";
            button5.Size = new Size(32, 23);
            button5.TabIndex = 5;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Chartreuse;
            button4.Location = new Point(127, 62);
            button4.Name = "button4";
            button4.Size = new Size(32, 23);
            button4.TabIndex = 4;
            button4.Text = "✔";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(46, 255);
            button3.Name = "button3";
            button3.Size = new Size(113, 23);
            button3.TabIndex = 2;
            button3.Text = "Delete Entry";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(46, 183);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 1;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 33);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Entry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 15F);
            groupBox1.Location = new Point(0, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(636, 369);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tasks";
            // 
            // tabControl1
            // 
            tabControl1.Location = new Point(12, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(618, 330);
            tabControl1.TabIndex = 2;
            // 
            // button11
            // 
            button11.Location = new Point(46, 316);
            button11.Name = "button11";
            button11.Size = new Size(113, 23);
            button11.TabIndex = 13;
            button11.Text = "Delete Section";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // myTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(836, 464);
            Controls.Add(groupBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(852, 503);
            MinimumSize = new Size(852, 503);
            Name = "myTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyTask";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
        private TextBox textBox2;
        private Button button8;
        private TabControl tabControl1;
        private Button button9;
        private Button button10;
        private TextBox textBox3;
        private Button button11;
    }
}