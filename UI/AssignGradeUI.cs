using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeApp.Manager;
using EmployeeApp.Model;

namespace EmployeeApp.UI
{
    public partial class AssignGradeUI : Form
    {
        public AssignGradeUI()
        {
            InitializeComponent();
            selectDeptComboBox.DisplayMember = "Name";
            selectDeptComboBox.ValueMember = "Id";

            selectGradeLevelComboBox.DisplayMember = "GradeLevel";
            selectGradeLevelComboBox.ValueMember = "Id";

            selectEmployeeComboBox.DisplayMember = "Name";
            selectEmployeeComboBox.ValueMember = "Id";

            PopulateComboBoxes();
        }

        DepartmentManager aDepartmentManager = new DepartmentManager();
        GradeManager aGradeManager = new GradeManager();

        private int employeeId;
        private int gradeId;

        private void PopulateComboBoxes()
        {
            selectDeptComboBox.DataSource = aDepartmentManager.GetAll();
            selectGradeLevelComboBox.DataSource = aGradeManager.GetAll();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //string msg = aGradeManager.Assign(employeeId,gradeId);
            //MessageBox.Show(msg);
        }

        private void AssignGradeUI_Load(object sender, EventArgs e)
        {
            
        }

        private void selectDeptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectEmployeeComboBox.DataSource = aDepartmentManager.GetAllEmployees((int)selectDeptComboBox.SelectedValue);
        }

        private void selectEmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeManager anEmployeeManager = new EmployeeManager();
            Employee anEmployee = new Employee();
            anEmployee.Email = anEmployeeManager.Get((int)selectEmployeeComboBox.SelectedValue).Email;
            anEmployee.Contact = anEmployeeManager.Get((int)selectEmployeeComboBox.SelectedValue).Contact;
            emailTextBox.Text = anEmployee.Email;
            contactTextBox.Text = anEmployee.Contact;

            employeeId = (int)selectEmployeeComboBox.SelectedValue;

        }

        private void selectGradeLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradeManager aGradeManager = new GradeManager();
            Grade aGrade = new Grade();
            aGrade.BasicAmount = aGradeManager.Get((int)selectGradeLevelComboBox.SelectedValue).BasicAmount;
            aGrade.MedicalAllowance = aGradeManager.Get((int)selectGradeLevelComboBox.SelectedValue).MedicalAllowance;
            aGrade.HouseRent = aGradeManager.Get((int)selectGradeLevelComboBox.SelectedValue).HouseRent;
            totalSalaryTextBox.Text = aGrade.GetTotalSalary().ToString();

            gradeId = (int) selectGradeLevelComboBox.SelectedValue;
        }
    }
}
