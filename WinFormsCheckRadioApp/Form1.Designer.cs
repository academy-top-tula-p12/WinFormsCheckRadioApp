namespace WinFormsCheckRadioApp
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
            grpLangs = new GroupBox();
            chkJava = new CheckBox();
            chkPython = new CheckBox();
            chkCpp = new CheckBox();
            label1 = new Label();
            grpFirst = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            grpSecond = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            lblFirst = new Label();
            lblSecond = new Label();
            grpLangs.SuspendLayout();
            grpFirst.SuspendLayout();
            grpSecond.SuspendLayout();
            SuspendLayout();
            // 
            // grpLangs
            // 
            grpLangs.Controls.Add(chkJava);
            grpLangs.Controls.Add(chkPython);
            grpLangs.Controls.Add(chkCpp);
            grpLangs.Font = new Font("Segoe UI", 20F);
            grpLangs.Location = new Point(34, 28);
            grpLangs.Name = "grpLangs";
            grpLangs.Size = new Size(388, 246);
            grpLangs.TabIndex = 0;
            grpLangs.TabStop = false;
            grpLangs.Text = "Языки программирования";
            // 
            // chkJava
            // 
            chkJava.AutoSize = true;
            chkJava.Location = new Point(27, 172);
            chkJava.Name = "chkJava";
            chkJava.Size = new Size(87, 41);
            chkJava.TabIndex = 2;
            chkJava.Text = "Java";
            chkJava.UseVisualStyleBackColor = true;
            chkJava.CheckedChanged += chkCpp_CheckedChanged;
            // 
            // chkPython
            // 
            chkPython.AutoSize = true;
            chkPython.Location = new Point(27, 110);
            chkPython.Name = "chkPython";
            chkPython.Size = new Size(119, 41);
            chkPython.TabIndex = 1;
            chkPython.Text = "Python";
            chkPython.UseVisualStyleBackColor = true;
            chkPython.CheckedChanged += chkCpp_CheckedChanged;
            // 
            // chkCpp
            // 
            chkCpp.AutoSize = true;
            chkCpp.Checked = true;
            chkCpp.CheckState = CheckState.Indeterminate;
            chkCpp.Location = new Point(27, 53);
            chkCpp.Name = "chkCpp";
            chkCpp.Size = new Size(89, 41);
            chkCpp.TabIndex = 0;
            chkCpp.Text = "C++";
            chkCpp.ThreeState = true;
            chkCpp.UseVisualStyleBackColor = true;
            chkCpp.CheckedChanged += chkCpp_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(34, 318);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // grpFirst
            // 
            grpFirst.Controls.Add(radioButton2);
            grpFirst.Controls.Add(radioButton1);
            grpFirst.Font = new Font("Segoe UI", 22F);
            grpFirst.Location = new Point(453, 43);
            grpFirst.Name = "grpFirst";
            grpFirst.Size = new Size(277, 231);
            grpFirst.TabIndex = 3;
            grpFirst.TabStop = false;
            grpFirst.Text = "Первое блюдо";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(30, 143);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(114, 45);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Борщ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(30, 74);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(164, 45);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Окрошка";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // grpSecond
            // 
            grpSecond.Controls.Add(radioButton5);
            grpSecond.Controls.Add(radioButton4);
            grpSecond.Controls.Add(radioButton3);
            grpSecond.Font = new Font("Segoe UI", 22F);
            grpSecond.Location = new Point(769, 43);
            grpSecond.Name = "grpSecond";
            grpSecond.Size = new Size(277, 231);
            grpSecond.TabIndex = 3;
            grpSecond.TabStop = false;
            grpSecond.Text = "Второе  блюдо";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(23, 158);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(106, 45);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Рыба";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 107);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(136, 45);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Курица";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 56);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(172, 45);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Бифштекс";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Font = new Font("Segoe UI", 24F);
            lblFirst.Location = new Point(453, 344);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(105, 45);
            lblFirst.TabIndex = 1;
            lblFirst.Text = "label1";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Font = new Font("Segoe UI", 24F);
            lblSecond.Location = new Point(769, 344);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(105, 45);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 474);
            Controls.Add(grpSecond);
            Controls.Add(grpFirst);
            Controls.Add(lblSecond);
            Controls.Add(lblFirst);
            Controls.Add(label1);
            Controls.Add(grpLangs);
            Name = "Form1";
            Text = "Form1";
            grpLangs.ResumeLayout(false);
            grpLangs.PerformLayout();
            grpFirst.ResumeLayout(false);
            grpFirst.PerformLayout();
            grpSecond.ResumeLayout(false);
            grpSecond.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpLangs;
        private CheckBox chkCpp;
        private CheckBox chkJava;
        private CheckBox chkPython;
        private Label label1;
        private GroupBox grpFirst;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox grpSecond;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label lblFirst;
        private Label lblSecond;
    }
}
