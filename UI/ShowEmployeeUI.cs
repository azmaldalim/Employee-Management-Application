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
    public partial class ShowEmployeeUI : Form
    {
        public ShowEmployeeUI()
        {
            InitializeComponent();
            selectDeptComboBox.DisplayMember = "Name";
            selectDeptComboBox.ValueMember = "Id";
            PopulateComboBoxes();

        }

        DepartmentManager aDepartmentManager = new DepartmentManager();

        private void PopulateComboBoxes()
        {
            selectDeptComboBox.DataSource = aDepartmentManager.GetAll();
        }

        private void selectDeptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeManager anEmployeeManager = new EmployeeManager();
            

            dataGridView1.DataSource = anEmployeeManager.GetAllByDepartment((int)selectDeptComboBox.SelectedValue);



        }
    }
}
