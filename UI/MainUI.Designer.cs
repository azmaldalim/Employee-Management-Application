namespace EmployeeApp.UI
{
    partial class MainUI
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
            this.departmentEntryButton = new System.Windows.Forms.Button();
            this.employeeEntryButton = new System.Windows.Forms.Button();
            this.viewEmployeeButton = new System.Windows.Forms.Button();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.assignGradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmentEntryButton
            // 
            this.departmentEntryButton.Location = new System.Drawing.Point(41, 34);
            this.departmentEntryButton.Name = "departmentEntryButton";
            this.departmentEntryButton.Size = new System.Drawing.Size(202, 41);
            this.departmentEntryButton.TabIndex = 0;
            this.departmentEntryButton.Text = "Department Entry";
            this.departmentEntryButton.UseVisualStyleBackColor = true;
            this.departmentEntryButton.Click += new System.EventHandler(this.departmentEntryButton_Click);
            // 
            // employeeEntryButton
            // 
            this.employeeEntryButton.Location = new System.Drawing.Point(41, 81);
            this.employeeEntryButton.Name = "employeeEntryButton";
            this.employeeEntryButton.Size = new System.Drawing.Size(202, 41);
            this.employeeEntryButton.TabIndex = 0;
            this.employeeEntryButton.Text = "Employee Entry";
            this.employeeEntryButton.UseVisualStyleBackColor = true;
            this.employeeEntryButton.Click += new System.EventHandler(this.employeeEntryButton_Click);
            // 
            // viewEmployeeButton
            // 
            this.viewEmployeeButton.Location = new System.Drawing.Point(41, 128);
            this.viewEmployeeButton.Name = "viewEmployeeButton";
            this.viewEmployeeButton.Size = new System.Drawing.Size(202, 41);
            this.viewEmployeeButton.TabIndex = 0;
            this.viewEmployeeButton.Text = "View Employees";
            this.viewEmployeeButton.UseVisualStyleBackColor = true;
            this.viewEmployeeButton.Click += new System.EventHandler(this.viewEmployeeButton_Click);
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(41, 175);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(202, 41);
            this.addGradeButton.TabIndex = 0;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // assignGradeButton
            // 
            this.assignGradeButton.Location = new System.Drawing.Point(41, 222);
            this.assignGradeButton.Name = "assignGradeButton";
            this.assignGradeButton.Size = new System.Drawing.Size(202, 44);
            this.assignGradeButton.TabIndex = 1;
            this.assignGradeButton.Text = "Assign Grade";
            this.assignGradeButton.UseVisualStyleBackColor = true;
            this.assignGradeButton.Click += new System.EventHandler(this.assignGradeButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.assignGradeButton);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.viewEmployeeButton);
            this.Controls.Add(this.employeeEntryButton);
            this.Controls.Add(this.departmentEntryButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button departmentEntryButton;
        private System.Windows.Forms.Button employeeEntryButton;
        private System.Windows.Forms.Button viewEmployeeButton;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.Button assignGradeButton;
    }
}