namespace _17._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.modeSwitch = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.closeFileButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gradeWriteBox = new System.Windows.Forms.TextBox();
            this.classWriteBox = new System.Windows.Forms.TextBox();
            this.lastNameWriteBox = new System.Windows.Forms.TextBox();
            this.IDNumWriteBox = new System.Windows.Forms.TextBox();
            this.firstNameWriteBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.ListBox();
            this.modeSwitch.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(128, 315);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save As";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Location = new System.Drawing.Point(274, 315);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // modeSwitch
            // 
            this.modeSwitch.Controls.Add(this.tabPage1);
            this.modeSwitch.Controls.Add(this.tabPage2);
            this.modeSwitch.Location = new System.Drawing.Point(12, 13);
            this.modeSwitch.Name = "modeSwitch";
            this.modeSwitch.SelectedIndex = 0;
            this.modeSwitch.Size = new System.Drawing.Size(617, 395);
            this.modeSwitch.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.closeFileButton);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.gradeWriteBox);
            this.tabPage1.Controls.Add(this.classWriteBox);
            this.tabPage1.Controls.Add(this.lastNameWriteBox);
            this.tabPage1.Controls.Add(this.IDNumWriteBox);
            this.tabPage1.Controls.Add(this.firstNameWriteBox);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.enterButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enter Grades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // closeFileButton
            // 
            this.closeFileButton.Enabled = false;
            this.closeFileButton.Location = new System.Drawing.Point(396, 315);
            this.closeFileButton.Name = "closeFileButton";
            this.closeFileButton.Size = new System.Drawing.Size(75, 23);
            this.closeFileButton.TabIndex = 12;
            this.closeFileButton.Text = "Close File";
            this.closeFileButton.UseVisualStyleBackColor = true;
            this.closeFileButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "ID #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Grade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "First Name";
            // 
            // gradeWriteBox
            // 
            this.gradeWriteBox.Location = new System.Drawing.Point(229, 235);
            this.gradeWriteBox.Name = "gradeWriteBox";
            this.gradeWriteBox.Size = new System.Drawing.Size(184, 22);
            this.gradeWriteBox.TabIndex = 6;
            // 
            // classWriteBox
            // 
            this.classWriteBox.Location = new System.Drawing.Point(229, 183);
            this.classWriteBox.Name = "classWriteBox";
            this.classWriteBox.Size = new System.Drawing.Size(184, 22);
            this.classWriteBox.TabIndex = 5;
            // 
            // lastNameWriteBox
            // 
            this.lastNameWriteBox.Location = new System.Drawing.Point(229, 72);
            this.lastNameWriteBox.Name = "lastNameWriteBox";
            this.lastNameWriteBox.Size = new System.Drawing.Size(184, 22);
            this.lastNameWriteBox.TabIndex = 4;
            // 
            // IDNumWriteBox
            // 
            this.IDNumWriteBox.Location = new System.Drawing.Point(229, 126);
            this.IDNumWriteBox.Name = "IDNumWriteBox";
            this.IDNumWriteBox.Size = new System.Drawing.Size(184, 22);
            this.IDNumWriteBox.TabIndex = 3;
            // 
            // firstNameWriteBox
            // 
            this.firstNameWriteBox.Location = new System.Drawing.Point(229, 21);
            this.firstNameWriteBox.Name = "firstNameWriteBox";
            this.firstNameWriteBox.Size = new System.Drawing.Size(184, 22);
            this.firstNameWriteBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultBox);
            this.tabPage2.Controls.Add(this.openButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Open Grades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(242, 307);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 43);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.FormattingEnabled = true;
            this.resultBox.ItemHeight = 16;
            this.resultBox.Location = new System.Drawing.Point(40, 29);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(527, 260);
            this.resultBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 420);
            this.Controls.Add(this.modeSwitch);
            this.Name = "Form1";
            this.Text = "Grades";
            this.modeSwitch.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TabControl modeSwitch;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox classWriteBox;
        private System.Windows.Forms.TextBox lastNameWriteBox;
        private System.Windows.Forms.TextBox IDNumWriteBox;
        private System.Windows.Forms.TextBox firstNameWriteBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gradeWriteBox;
        private System.Windows.Forms.Button closeFileButton;
        private System.Windows.Forms.ListBox resultBox;
    }
}

