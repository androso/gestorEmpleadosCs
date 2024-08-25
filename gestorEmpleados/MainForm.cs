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
            RefreshEmployeeList();
        }
        
        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {


                NewEmployeeForm newEmployeeForm = new NewEmployeeForm(employeeManagement);
                DialogResult result = newEmployeeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshEmployeeList();
                }
            }catch (Exception ex)
            {
                MessageBox.Show($"Error creando nuevo empleado: {ex.Message}", "Error Nuevo Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void paySalaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = (Employee)employeesListBox.SelectedItem;
                GeneratePayment generatePaymentForm = new GeneratePayment(employee);
                generatePaymentForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generando el pago: {ex.Message}", "Error Generar Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {


                Employee selectedEmployee = (Employee)employeesListBox.SelectedItem;
                employeeManagement.DeleteEmployee(selectedEmployee);
                RefreshEmployeeList();
            }catch (Exception ex)
            {
                MessageBox.Show($"Error eliminando empleado: {ex.Message}", "Error Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee selectedEmployee = (Employee)employeesListBox.SelectedItem;
                MessageBox.Show($"ID: {selectedEmployee.Id}\nNombre: {selectedEmployee.FullName}\nFecha de nacimiento: {selectedEmployee.BirthDate}\nAntigüedad: {selectedEmployee.Seniority}", "Información del empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir detalles de empleado", "Error al ver empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshEmployeeList()
        {
            employeesListBox.Items.Clear();
            employeesListBox.Items.AddRange(employeeManagement.GetAllEmployees().ToArray());
            employeesListBox.DisplayMember = "FullName";
            employeesListBox.ValueMember = "Id";
            if (employeesListBox.Items.Count > 0)
            {
                employeesListBox.SelectedIndex = 0;
                employeesListBox.SelectedItem = employeesListBox.Items[0];
            }
        }
    }
}