namespace hw4
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
            button_choose1 = new Button();
            label_filepath1 = new Label();
            label_filepath2 = new Label();
            button_choose2 = new Button();
            button_create = new Button();
            label3 = new Label();
            output_filename = new TextBox();
            SuspendLayout();
            // 
            // button_choose1
            // 
            button_choose1.BackColor = SystemColors.Control;
            button_choose1.FlatStyle = FlatStyle.System;
            button_choose1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button_choose1.Location = new Point(530, 105);
            button_choose1.Name = "button_choose1";
            button_choose1.Size = new Size(112, 36);
            button_choose1.TabIndex = 0;
            button_choose1.Text = "选择文件";
            button_choose1.UseVisualStyleBackColor = false;
            button_choose1.Click += button_choose1_Click;
            // 
            // label_filepath1
            // 
            label_filepath1.AutoSize = true;
            label_filepath1.BorderStyle = BorderStyle.Fixed3D;
            label_filepath1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 134);
            label_filepath1.ForeColor = SystemColors.ControlDarkDark;
            label_filepath1.Location = new Point(128, 106);
            label_filepath1.MaximumSize = new Size(400, 0);
            label_filepath1.MinimumSize = new Size(400, 0);
            label_filepath1.Name = "label_filepath1";
            label_filepath1.Padding = new Padding(0, 5, 0, 5);
            label_filepath1.Size = new Size(400, 36);
            label_filepath1.TabIndex = 2;
            label_filepath1.Text = "FilePath";
            label_filepath1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_filepath2
            // 
            label_filepath2.AutoSize = true;
            label_filepath2.BorderStyle = BorderStyle.Fixed3D;
            label_filepath2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 134);
            label_filepath2.ForeColor = SystemColors.ControlDarkDark;
            label_filepath2.Location = new Point(128, 190);
            label_filepath2.MaximumSize = new Size(400, 0);
            label_filepath2.MinimumSize = new Size(400, 0);
            label_filepath2.Name = "label_filepath2";
            label_filepath2.Padding = new Padding(0, 5, 0, 5);
            label_filepath2.Size = new Size(400, 36);
            label_filepath2.TabIndex = 3;
            label_filepath2.Text = "FilePath";
            label_filepath2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_choose2
            // 
            button_choose2.BackColor = SystemColors.Control;
            button_choose2.FlatStyle = FlatStyle.System;
            button_choose2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button_choose2.Location = new Point(530, 190);
            button_choose2.Name = "button_choose2";
            button_choose2.Size = new Size(112, 36);
            button_choose2.TabIndex = 4;
            button_choose2.Text = "选择文件";
            button_choose2.UseVisualStyleBackColor = false;
            button_choose2.Click += button_choose2_Click;
            // 
            // button_create
            // 
            button_create.Cursor = Cursors.Hand;
            button_create.FlatStyle = FlatStyle.System;
            button_create.Location = new Point(353, 379);
            button_create.Name = "button_create";
            button_create.Size = new Size(82, 34);
            button_create.TabIndex = 7;
            button_create.Text = "合并";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 306);
            label3.Name = "label3";
            label3.Size = new Size(37, 24);
            label3.TabIndex = 6;
            label3.Text = ".txt";
            // 
            // output_filename
            // 
            output_filename.BackColor = SystemColors.Window;
            output_filename.BorderStyle = BorderStyle.FixedSingle;
            output_filename.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            output_filename.Location = new Point(300, 296);
            output_filename.Name = "output_filename";
            output_filename.Size = new Size(162, 34);
            output_filename.TabIndex = 5;
            output_filename.Text = "output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(button_create);
            Controls.Add(label3);
            Controls.Add(output_filename);
            Controls.Add(button_choose2);
            Controls.Add(label_filepath2);
            Controls.Add(label_filepath1);
            Controls.Add(button_choose1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_choose1;
        private Label label_filepath1;
        private Label label_filepath2;
        private Button button_choose2;
        private Button button_create;
        private Label label3;
        private TextBox output_filename;
    }
}
