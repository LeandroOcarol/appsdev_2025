namespace SimpleFavoriteCartoonFormApp
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
            comboBox = new ComboBox();
            viewBtn = new Button();
            clearBtn = new Button();
            pictureBox = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(490, 24);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE CARTOON CHARACTER PICKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Select an item:";
            label2.Click += label2_Click;
            // 
            // comboBox
            // 
            comboBox.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(22, 107);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(249, 26);
            comboBox.TabIndex = 2;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // viewBtn
            // 
            viewBtn.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewBtn.Location = new Point(70, 152);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(157, 23);
            viewBtn.TabIndex = 3;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += button1_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(70, 191);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(157, 23);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(330, 107);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(270, 254);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(330, 74);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "Image";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 398);
            Controls.Add(label3);
            Controls.Add(pictureBox);
            Controls.Add(clearBtn);
            Controls.Add(viewBtn);
            Controls.Add(comboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox;
        private Button viewBtn;
        private Button clearBtn;
        private PictureBox pictureBox;
        private Label label3;
    }
}
