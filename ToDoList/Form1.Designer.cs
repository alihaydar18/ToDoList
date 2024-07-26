
namespace ToDoList
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 184);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 1;
            label1.Text = "To Do List";
            // 
            // button1
            // 
            button1.Location = new Point(71, 339);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(335, 339);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(581, 339);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 27);
            textBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(335, 389);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Complete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
    }
}
