﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestorEmpleados
{
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            newEmpSeniorityCombobox.Items.AddRange([
                "Junior",
                "Mid",
                "Senior"
                ]);
            newEmpSeniorityCombobox.SelectedIndex = 0;
        }
    }
}
