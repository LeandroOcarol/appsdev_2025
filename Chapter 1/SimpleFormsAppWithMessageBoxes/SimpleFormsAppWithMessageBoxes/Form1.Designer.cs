namespace SimpleFormsAppWithMessageBoxes
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
            firstName = new TextBox();
            submit = new Button();
            middleName = new TextBox();
            lastName = new TextBox();
            suffix = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 23);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 0;
            label1.Text = "Simple Form Application";
            // 
            // firstName
            // 
            firstName.Location = new Point(70, 126);
            firstName.Name = "firstName";
            firstName.Size = new Size(360, 23);
            firstName.TabIndex = 1;
            // 
            // submit
            // 
            submit.Location = new Point(147, 496);
            submit.Name = "submit";
            submit.Size = new Size(200, 23);
            submit.TabIndex = 5;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // middleName
            // 
            middleName.Location = new Point(70, 218);
            middleName.Name = "middleName";
            middleName.Size = new Size(360, 23);
            middleName.TabIndex = 6;
            // 
            // lastName
            // 
            lastName.Location = new Point(70, 311);
            lastName.Name = "lastName";
            lastName.Size = new Size(360, 23);
            lastName.TabIndex = 7;
            // 
            // suffix
            // 
            suffix.Location = new Point(70, 402);
            suffix.Name = "suffix";
            suffix.Size = new Size(360, 23);
            suffix.TabIndex = 8;
            suffix.TextChanged += textBox4_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 95);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 191);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 283);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 11;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 371);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 12;
            label5.Text = "Suffix";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 568);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(suffix);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(submit);
            Controls.Add(firstName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstName;
        private Button submit;
        private TextBox middleName;
        private TextBox lastName;
        private TextBox suffix;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
