namespace SimpleFormsApp
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
            firstName = new TextBox();
            label3 = new Label();
            middleName = new TextBox();
            label4 = new Label();
            lastName = new TextBox();
            label5 = new Label();
            suffix = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 21);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FORM APPLICATION";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 58);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // firstName
            // 
            firstName.Location = new Point(29, 89);
            firstName.Name = "firstName";
            firstName.Size = new Size(404, 23);
            firstName.TabIndex = 2;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 134);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "Middle Name";
            // 
            // middleName
            // 
            middleName.Location = new Point(29, 168);
            middleName.Name = "middleName";
            middleName.Size = new Size(404, 23);
            middleName.TabIndex = 4;
            middleName.TextChanged += middleName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 210);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // lastName
            // 
            lastName.Location = new Point(29, 244);
            lastName.Name = "lastName";
            lastName.Size = new Size(404, 23);
            lastName.TabIndex = 6;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 285);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 7;
            label5.Text = "Suffix";
            // 
            // suffix
            // 
            suffix.Location = new Point(29, 318);
            suffix.Name = "suffix";
            suffix.Size = new Size(404, 23);
            suffix.TabIndex = 8;
            suffix.TextChanged += suffix_TextChanged;
            // 
            // submit
            // 
            submit.Location = new Point(29, 388);
            submit.Name = "submit";
            submit.Size = new Size(404, 36);
            submit.TabIndex = 9;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 450);
            Controls.Add(submit);
            Controls.Add(suffix);
            Controls.Add(label5);
            Controls.Add(lastName);
            Controls.Add(label4);
            Controls.Add(middleName);
            Controls.Add(label3);
            Controls.Add(firstName);
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
        private TextBox firstName;
        private Label label3;
        private TextBox middleName;
        private Label label4;
        private TextBox lastName;
        private Label label5;
        private TextBox suffix;
        private Button submit;
    }
}
