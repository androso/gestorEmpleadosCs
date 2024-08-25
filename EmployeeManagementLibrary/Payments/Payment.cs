using EmployeeManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Payments
{
    public class PaymentEventArgs : EventArgs
    {
        public Employee Employee { get; }
        public decimal Amount { get; }

        public PaymentEventArgs(Employee employee, decimal amount)
        {
            Employee = employee;
            Amount = amount;
        }
    }

    public class PaymentGenerator
    {
        public event EventHandler<PaymentEventArgs> PaymentGenerated;

        public void GeneratePayment(Employee employee, decimal amount)
        {
            // Raise the event
            OnPaymentGenerated(new PaymentEventArgs(employee, amount));

            Console.WriteLine($"Payment of {amount:C} generated for {employee.FullName}");
        }

        protected virtual void OnPaymentGenerated(PaymentEventArgs e)
        {
            PaymentGenerated?.Invoke(this, e);
        }
    }
}
