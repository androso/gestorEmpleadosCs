using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementLibrary.Models;

namespace gestorEmpleados
{
    public partial class NewEmployeeForm : Form
    {
        private EmployeeManagement employeeManagement;
        public NewEmployeeForm(EmployeeManagement employeeManagement)
        {
            InitializeComponent();
            this.employeeManagement = employeeManagement;

        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            newEmpSeniorityCombobox.Items.AddRange([
                "Junior",
                "Mid",
                "Senior"
                ]);
            newEmpSeniorityCombobox.SelectedIndex = 0;
            newEmpSeniorityCombobox.SelectedItem = "Junior";
        }

        private void newEmpFullNameTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(newEmpFullNameTextbox.Text))
            {
                e.Cancel = true;
                ValidationErrorProvider.SetError(newEmpFullNameTextbox, "Por favor introduce un nombre");
                fullNameErrorLabel.Text = "El nombre no debe estar vacío";
                newEmpFullNameTextbox.Focus();
            }
            else
            {
                e.Cancel = false;
                ValidationErrorProvider.SetError(newEmpFullNameTextbox, "");
                fullNameErrorLabel.Text = "";
            }
        }

        private void newEmpSubmitButton_Click(object sender, EventArgs e)
        {
            string fullname = newEmpFullNameTextbox.Text;
            string seniority = newEmpSeniorityCombobox.SelectedItem.ToString();
            DateTime birthdate = newEmpBirthDateDateTimePicker.Value;
            
            Employee employee = new Employee
            {
                Id = employeeManagement.GetAllEmployees().Count + 1,
                FullName = fullname,
                Seniority = seniority,
                BirthDate = birthdate
            };
            employeeManagement.AddEmployee(employee);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
