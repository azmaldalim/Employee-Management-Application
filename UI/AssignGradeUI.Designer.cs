namespace EmployeeApp.UI
{
    partial class AssignGradeUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectDeptComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectGradeLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Department";
            // 
            // selectDeptComboBox
            // 
            this.selectDeptComboBox.FormattingEnabled = true;
            this.selectDeptComboBox.Location = new System.Drawing.Point(109, 24);
            this.selectDeptComboBox.Name = "selectDeptComboBox";
            this.selectDeptComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectDeptComboBox.TabIndex = 1;
            this.selectDeptComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDeptComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Employee";
            // 
            // selectEmployeeComboBox
            // 
            this.selectEmployeeComboBox.FormattingEnabled = true;
            this.selectEmployeeComboBox.Location = new System.Drawing.Point(109, 51);
            this.selectEmployeeComboBox.Name = "selectEmployeeComboBox";
            this.selectEmployeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectEmployeeComboBox.TabIndex = 1;
            this.selectEmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.selectEmployeeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select Grade Level";
            // 
            // selectGradeLevelComboBox
            // 
            this.selectGradeLevelComboBox.FormattingEnabled = true;
            this.selectGradeLevelComboBox.Location = new System.Drawing.Point(109, 132);
            this.selectGradeLevelComboBox.Name = "selectGradeLevelComboBox";
            this.selectGradeLevelComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectGradeLevelComboBox.TabIndex = 1;
            this.selectGradeLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.selectGradeLevelComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Salary";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(109, 78);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(109, 104);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 2;
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Location = new System.Drawing.Point(109, 159);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalaryTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(109, 185);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AssignGradeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 229);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalSalaryTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectGradeLevelComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectEmployeeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectDeptComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AssignGradeUI";
            this.Text = "AssignGradeUI";
            this.Load += new System.EventHandler(this.AssignGradeUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectDeptComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectEmployeeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectGradeLevelComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}