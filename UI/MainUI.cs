using System;
using System.Windows.Forms;

namespace EmployeeApp.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void departmentEntryButton_Click(object sender, EventArgs e)
        {
            DepartmentEntryUI aDepartmentEntryUi = new DepartmentEntryUI();
            aDepartmentEntryUi.Show();
        }

        private void employeeEntryButton_Click(object sender, EventArgs e)
        {
            EmployeeEntryUI aEmployeeEntryUi = new EmployeeEntryUI();
            aEmployeeEntryUi.Show();
        }

        private void addGradeButton_Click(object sender, EventArgs e)
        {
            GradeEntryUI aGradeEntryUi = new GradeEntryUI();
            aGradeEntryUi.Show();
        }

        private void assignGradeButton_Click(object sender, EventArgs e)
        {
            AssignGradeUI oneAssignGradeUi = new AssignGradeUI();
            oneAssignGradeUi.Show();
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            ShowEmployeeUI aShowEmployeeUi = new ShowEmployeeUI();
            aShowEmployeeUi.Show();
        }
    }
}
