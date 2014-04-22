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
    public partial class GradeEntryUI : Form
    {
        public GradeEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Grade aGrade = new Grade();
            aGrade.GradeLevel = gradeLevelTextBox.Text;
            aGrade.BasicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aGrade.MedicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            aGrade.HouseRent = Convert.ToDouble(houseRentTextBox.Text);

            GradeManager aGradeManager = new GradeManager();
            string msg = aGradeManager.Save(aGrade);
            MessageBox.Show(msg);
        }
    }
}
