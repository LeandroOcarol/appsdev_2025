namespace SimpleFormsAppWithCheckedListBox
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            add = new Button();
            remove = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 28);
            label1.Name = "label1";
            label1.Size = new Size(328, 28);
            label1.TabIndex = 0;
            label1.Text = "MY FAVORITE MOVIE PICKER APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Movies/Series List";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 90);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "My Movies List";
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(12, 111);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(255, 220);
            checkedListBox.TabIndex = 3;
            checkedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(316, 114);
            listBox.Name = "listBox";
            listBox.Size = new Size(314, 214);
            listBox.TabIndex = 4;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(12, 354);
            add.Name = "add";
            add.Size = new Size(255, 36);
            add.TabIndex = 5;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(328, 354);
            remove.Name = "remove";
            remove.Size = new Size(141, 36);
            remove.TabIndex = 6;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.Location = new Point(475, 354);
            clear.Name = "clear";
            clear.Size = new Size(141, 36);
            clear.TabIndex = 7;
            clear.Text = "Clear All";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 494);
            Controls.Add(clear);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Button add;
        private Button remove;
        private Button clear;
    }
}
