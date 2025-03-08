namespace hw3
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
            hourOut = new Label();
            label1 = new Label();
            secOut = new Label();
            minOut = new Label();
            label5 = new Label();
            label4 = new Label();
            hourIn = new NumericUpDown();
            minIn = new NumericUpDown();
            secIn = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            setButton = new Button();
            alarmLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)hourIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secIn).BeginInit();
            SuspendLayout();
            // 
            // hourOut
            // 
            hourOut.AutoSize = true;
            hourOut.BackColor = SystemColors.Control;
            hourOut.BorderStyle = BorderStyle.Fixed3D;
            hourOut.Font = new Font("Modern No. 20", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hourOut.Location = new Point(150, 100);
            hourOut.Margin = new Padding(3);
            hourOut.MaximumSize = new Size(117, 65);
            hourOut.MinimumSize = new Size(117, 65);
            hourOut.Name = "hourOut";
            hourOut.Padding = new Padding(0, 5, 0, 5);
            hourOut.Size = new Size(117, 65);
            hourOut.TabIndex = 0;
            hourOut.Text = "HH";
            hourOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 274);
            label1.MaximumSize = new Size(0, 30);
            label1.MinimumSize = new Size(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 30);
            label1.TabIndex = 2;
            label1.Text = "时";
            // 
            // secOut
            // 
            secOut.AutoSize = true;
            secOut.BackColor = SystemColors.Control;
            secOut.BorderStyle = BorderStyle.Fixed3D;
            secOut.Font = new Font("Modern No. 20", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            secOut.Location = new Point(550, 100);
            secOut.Margin = new Padding(3);
            secOut.MaximumSize = new Size(117, 65);
            secOut.MinimumSize = new Size(117, 65);
            secOut.Name = "secOut";
            secOut.Padding = new Padding(0, 5, 0, 5);
            secOut.Size = new Size(117, 65);
            secOut.TabIndex = 3;
            secOut.Text = "SS";
            secOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minOut
            // 
            minOut.AutoSize = true;
            minOut.BackColor = SystemColors.Control;
            minOut.BorderStyle = BorderStyle.Fixed3D;
            minOut.Font = new Font("Modern No. 20", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minOut.Location = new Point(350, 100);
            minOut.Margin = new Padding(3);
            minOut.MaximumSize = new Size(117, 65);
            minOut.MinimumSize = new Size(117, 65);
            minOut.Name = "minOut";
            minOut.Padding = new Padding(0, 5, 0, 5);
            minOut.Size = new Size(117, 65);
            minOut.TabIndex = 4;
            minOut.Text = "MM";
            minOut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Modern No. 20", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(292, 100);
            label5.Margin = new Padding(3);
            label5.MaximumSize = new Size(35, 65);
            label5.MinimumSize = new Size(35, 65);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 5);
            label5.Size = new Size(35, 65);
            label5.TabIndex = 6;
            label5.Text = ":";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Modern No. 20", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(492, 99);
            label4.Margin = new Padding(3);
            label4.MaximumSize = new Size(35, 65);
            label4.MinimumSize = new Size(35, 65);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 5, 0, 5);
            label4.Size = new Size(35, 65);
            label4.TabIndex = 7;
            label4.Text = ":";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hourIn
            // 
            hourIn.BorderStyle = BorderStyle.FixedSingle;
            hourIn.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourIn.Location = new Point(165, 274);
            hourIn.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hourIn.MaximumSize = new Size(80, 0);
            hourIn.MinimumSize = new Size(80, 0);
            hourIn.Name = "hourIn";
            hourIn.Size = new Size(80, 36);
            hourIn.TabIndex = 8;
            // 
            // minIn
            // 
            minIn.BorderStyle = BorderStyle.FixedSingle;
            minIn.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minIn.Location = new Point(335, 274);
            minIn.MaximumSize = new Size(80, 0);
            minIn.MinimumSize = new Size(80, 0);
            minIn.Name = "minIn";
            minIn.Size = new Size(80, 36);
            minIn.TabIndex = 9;
            // 
            // secIn
            // 
            secIn.BorderStyle = BorderStyle.FixedSingle;
            secIn.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secIn.Location = new Point(505, 274);
            secIn.MaximumSize = new Size(80, 0);
            secIn.MinimumSize = new Size(80, 0);
            secIn.Name = "secIn";
            secIn.Size = new Size(80, 36);
            secIn.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 274);
            label2.MaximumSize = new Size(0, 30);
            label2.MinimumSize = new Size(0, 30);
            label2.Name = "label2";
            label2.Size = new Size(39, 30);
            label2.TabIndex = 11;
            label2.Text = "分";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(600, 274);
            label3.MaximumSize = new Size(0, 30);
            label3.MinimumSize = new Size(0, 30);
            label3.Name = "label3";
            label3.Size = new Size(39, 30);
            label3.TabIndex = 12;
            label3.Text = "秒";
            // 
            // setButton
            // 
            setButton.BackColor = SystemColors.ButtonFace;
            setButton.Cursor = Cursors.Hand;
            setButton.Font = new Font("Modern No. 20", 11.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            setButton.Location = new Point(352, 377);
            setButton.Margin = new Padding(0);
            setButton.Name = "setButton";
            setButton.Size = new Size(112, 40);
            setButton.TabIndex = 13;
            setButton.Text = "Set";
            setButton.UseVisualStyleBackColor = false;
            setButton.Click += setButton_Click;
            // 
            // alarmLabel
            // 
            alarmLabel.AutoSize = true;
            alarmLabel.BackColor = SystemColors.Control;
            alarmLabel.Font = new Font("Modern No. 20", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            alarmLabel.ForeColor = Color.Maroon;
            alarmLabel.Location = new Point(311, 184);
            alarmLabel.Margin = new Padding(3);
            alarmLabel.MaximumSize = new Size(350, 65);
            alarmLabel.MinimumSize = new Size(117, 65);
            alarmLabel.Name = "alarmLabel";
            alarmLabel.Padding = new Padding(0, 5, 0, 5);
            alarmLabel.Size = new Size(235, 65);
            alarmLabel.TabIndex = 14;
            alarmLabel.Text = "时间到！";
            alarmLabel.TextAlign = ContentAlignment.MiddleCenter;
            alarmLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(alarmLabel);
            Controls.Add(setButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(secIn);
            Controls.Add(minIn);
            Controls.Add(hourIn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(minOut);
            Controls.Add(secOut);
            Controls.Add(label1);
            Controls.Add(hourOut);
            Name = "Form1";
            Text = "Clock";
            ((System.ComponentModel.ISupportInitialize)hourIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)minIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)secIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hourOut;
        private Label label1;
        private Label secOut;
        private Label minOut;
        private Label label5;
        private Label label4;
        private NumericUpDown hourIn;
        private NumericUpDown minIn;
        private NumericUpDown secIn;
        private Label label2;
        private Label label3;
        private Button setButton;
        private Label alarmLabel;
    }
}
