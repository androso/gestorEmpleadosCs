using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementLibrary.Payments;

namespace gestorEmpleados
{
    public partial class GeneratePayment : Form
    {
        private PaymentGenerator paymentGenerator;
        private Employee employeeSelected;
        public GeneratePayment(Employee employee)
        {
            InitializeComponent();
            generatePaymentFullNameLabel.Text = employee.FullName;
            employeeSelected = employee;
            paymentGenerator = new PaymentGenerator();
            paymentGenerator.PaymentGenerated += PaymentGenerator_PaymentGenerated;
        }

        private void paymentQuantityTextbox_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(paymentQuantityTextbox.Text, out decimal quantity))
            {
                e.Cancel = true;
                ValidationErrorProvider.SetError(paymentQuantityTextbox, "Introduce un número decimal");
                quantityErrorLabel.Text = "Solo se permiten números decimales.";
            }
            else
            {
                e.Cancel = false;
                ValidationErrorProvider.SetError(paymentQuantityTextbox, "");
                quantityErrorLabel.Text = "";
                paymentGenerator.GeneratePayment(employeeSelected, quantity);
                this.Close();
            }
        }
        private void PaymentGenerator_PaymentGenerated(object sender, PaymentEventArgs e)
        {
            MessageBox.Show($"Payment of {e.Amount:C} generated for {e.Employee.FullName}", "Payment Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
