namespace SimpleFormsAppWithListBox
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
            listBox = new ListBox();
            label1 = new Label();
            textBox = new TextBox();
            add = new Button();
            remove = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 19;
            listBox.Location = new Point(15, 78);
            listBox.Name = "listBox";
            listBox.Size = new Size(219, 365);
            listBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 19);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 1;
            label1.Text = "Simple Name Viewer";
            // 
            // textBox
            // 
            textBox.Location = new Point(290, 115);
            textBox.Name = "textBox";
            textBox.Size = new Size(135, 23);
            textBox.TabIndex = 2;
            // 
            // add
            // 
            add.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(309, 197);
            add.Name = "add";
            add.Size = new Size(91, 37);
            add.TabIndex = 3;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(309, 277);
            remove.Name = "remove";
            remove.Size = new Size(91, 37);
            remove.TabIndex = 4;
            remove.Text = "REMOVE";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.Location = new Point(309, 356);
            clear.Name = "clear";
            clear.Size = new Size(91, 37);
            clear.TabIndex = 5;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 479);
            Controls.Add(clear);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(textBox);
            Controls.Add(label1);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Label label1;
        private TextBox textBox;
        private Button add;
        private Button remove;
        private Button clear;
    }
}
