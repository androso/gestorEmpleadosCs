using EmployeeManagementLibrary.Models;

namespace gestorEmpleados
{
    public partial class MainForm : Form
    {
        private EmployeeManagement employeeManagement;
        public MainForm()
        {
            InitializeComponent();
            employeeManagement = new EmployeeManagement();
            employeesListBox.Items.AddRange(employeeManagement.GetAllEmployees().ToArray());
            employeesListBox.DisplayMember = "FullName";
            employeesListBox.ValueMember = "Id";
            employeesListBox.SelectedIndex = 0;
            employeesListBox.SelectedItem = employeesListBox.Items[0];
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployeeForm newEmployeeForm = new NewEmployeeForm(employeeManagement);
            DialogResult result = newEmployeeForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                employeesListBox.Items.Clear();
                employeesListBox.Items.AddRange(employeeManagement.GetAllEmployees().ToArray());
            }
        }

        private void paySalaryButton_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)employeesListBox.SelectedItem;
            GeneratePayment generatePaymentForm = new GeneratePayment(employee);
            generatePaymentForm.ShowDialog();
        }
    }
}