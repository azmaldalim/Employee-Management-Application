using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using EmployeeApp.Manager;
using EmployeeApp.Model;

namespace EmployeeApp.UI
{
    public partial class DepartmentEntryUI : Form
    {
        public DepartmentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.Name = nameTextBox.Text;
            aDepartment.Code = codeTextBox.Text;
            DepartmentManager aDeptManager = new DepartmentManager();
            string msg = aDeptManager.Save(aDepartment);
            MessageBox.Show(msg);
        }
    }
}
