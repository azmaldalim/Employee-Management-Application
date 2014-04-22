using System.Windows.Forms;
using EmployeeApp.Manager;
using EmployeeApp.Model;

namespace EmployeeApp.UI
{
    public partial class EmployeeEntryUI : Form
    {
        public EmployeeEntryUI()
        {
            InitializeComponent();
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
            PopulateDepartmentComboBox();

        }

        DepartmentManager  aDepartmentManager = new DepartmentManager();

        private void PopulateDepartmentComboBox()
        {
            departmentComboBox.DataSource = aDepartmentManager.GetAll();
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Employee anEmployee = new Employee();
            anEmployee.Name = nameTextBox.Text;
            anEmployee.Email = emailTextBox.Text;
            anEmployee.Contact = contactTextBox.Text;
            anEmployee.JoiningDate = joiningDateDateTimePicker.Value;
            anEmployee.DepartmentId = (int) departmentComboBox.SelectedValue;
            EmployeeManager anEmployeeManager = new EmployeeManager();
            string msg = anEmployeeManager.Save(anEmployee);
            MessageBox.Show(msg);
        }
    }
}
