namespace SimpleFormsAppWithComboBox
{
    partial class Form
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
            comboBox = new ComboBox();
            selectBtn = new Button();
            checkedListBox = new CheckedListBox();
            addBtn = new Button();
            listBox = new ListBox();
            removeBtn = new Button();
            clrBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(415, 27);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE FOOD PICKER APP";
            // 
            // comboBox
            // 
            comboBox.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(25, 141);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(185, 28);
            comboBox.TabIndex = 1;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // selectBtn
            // 
            selectBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectBtn.Location = new Point(25, 186);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(185, 27);
            selectBtn.TabIndex = 2;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(252, 108);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(165, 180);
            checkedListBox.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(252, 313);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(165, 27);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // listBox
            // 
            listBox.Font = new Font("Consolas", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 20;
            listBox.Location = new Point(447, 108);
            listBox.Name = "listBox";
            listBox.Size = new Size(219, 164);
            listBox.TabIndex = 5;
            // 
            // removeBtn
            // 
            removeBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeBtn.Location = new Point(696, 141);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(127, 36);
            removeBtn.TabIndex = 6;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(696, 207);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(127, 36);
            clrBtn.TabIndex = 7;
            clrBtn.Text = "Clear All";
            clrBtn.UseVisualStyleBackColor = true;
            clrBtn.Click += clrBtn_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 389);
            Controls.Add(clrBtn);
            Controls.Add(removeBtn);
            Controls.Add(listBox);
            Controls.Add(addBtn);
            Controls.Add(checkedListBox);
            Controls.Add(selectBtn);
            Controls.Add(comboBox);
            Controls.Add(label1);
            Name = "Form";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox;
        private Button selectBtn;
        private CheckedListBox checkedListBox;
        private Button addBtn;
        private ListBox listBox;
        private Button removeBtn;
        private Button clrBtn;
    }
}
