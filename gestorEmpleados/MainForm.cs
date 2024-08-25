using EmployeeManagementLibrary.Models;

namespace gestorEmpleados
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeesListBox.Items.AddRange(employeeManagement.GetAllEmployees().ToArray());
            employeesListBox.DisplayMember = "FullName";
            employeesListBox.ValueMember = "Id";
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployeeForm newEmployeeForm = new NewEmployeeForm();
            newEmployeeForm.ShowDialog();
        }
    }
}
