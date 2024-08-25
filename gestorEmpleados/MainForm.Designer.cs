namespace gestorEmpleados
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            programTitleLabel = new Label();
            listingLabel = new Label();
            employeesListBox = new ListBox();
            newEmployeeButton = new Button();
            viewEmployeeButton = new Button();
            deleteEmployeeButton = new Button();
            paySalaryButton = new Button();
            SuspendLayout();
            // 
            // programTitleLabel
            // 
            programTitleLabel.AutoSize = true;
            programTitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            programTitleLabel.ForeColor = SystemColors.ControlLight;
            programTitleLabel.Location = new Point(218, 18);
            programTitleLabel.Name = "programTitleLabel";
            programTitleLabel.Size = new Size(271, 35);
            programTitleLabel.TabIndex = 0;
            programTitleLabel.Text = "Gestor de empleados ";
            // 
            // listingLabel
            // 
            listingLabel.AutoSize = true;
            listingLabel.Font = new Font("Segoe UI", 12F);
            listingLabel.ForeColor = SystemColors.ButtonFace;
            listingLabel.Location = new Point(31, 66);
            listingLabel.Name = "listingLabel";
            listingLabel.Size = new Size(75, 28);
            listingLabel.TabIndex = 1;
            listingLabel.Text = "Listado";
            // 
            // employeesListBox
            // 
            employeesListBox.BackColor = Color.FromArgb(44, 44, 44);
            employeesListBox.BorderStyle = BorderStyle.None;
            employeesListBox.ForeColor = SystemColors.Info;
            employeesListBox.FormattingEnabled = true;
            employeesListBox.Location = new Point(31, 103);
            employeesListBox.Margin = new Padding(0);
            employeesListBox.Name = "employeesListBox";
            employeesListBox.Size = new Size(387, 280);
            employeesListBox.TabIndex = 2;
            // 
            // newEmployeeButton
            // 
            newEmployeeButton.Location = new Point(474, 132);
            newEmployeeButton.Name = "newEmployeeButton";
            newEmployeeButton.Size = new Size(170, 51);
            newEmployeeButton.TabIndex = 3;
            newEmployeeButton.Text = "Nuevo empleado";
            newEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // viewEmployeeButton
            // 
            viewEmployeeButton.Location = new Point(474, 189);
            viewEmployeeButton.Name = "viewEmployeeButton";
            viewEmployeeButton.Size = new Size(170, 51);
            viewEmployeeButton.TabIndex = 4;
            viewEmployeeButton.Text = "Ver empleado";
            viewEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // deleteEmployeeButton
            // 
            deleteEmployeeButton.Location = new Point(474, 246);
            deleteEmployeeButton.Name = "deleteEmployeeButton";
            deleteEmployeeButton.Size = new Size(170, 51);
            deleteEmployeeButton.TabIndex = 5;
            deleteEmployeeButton.Text = "Eliminar empleado";
            deleteEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // paySalaryButton
            // 
            paySalaryButton.Location = new Point(474, 303);
            paySalaryButton.Name = "paySalaryButton";
            paySalaryButton.Size = new Size(170, 51);
            paySalaryButton.TabIndex = 6;
            paySalaryButton.Text = "Generar pago";
            paySalaryButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(683, 429);
            Controls.Add(paySalaryButton);
            Controls.Add(deleteEmployeeButton);
            Controls.Add(viewEmployeeButton);
            Controls.Add(newEmployeeButton);
            Controls.Add(employeesListBox);
            Controls.Add(listingLabel);
            Controls.Add(programTitleLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label programTitleLabel;
        private Label listingLabel;
        private ListBox employeesListBox;
        private Button newEmployeeButton;
        private Button viewEmployeeButton;
        private Button deleteEmployeeButton;
        private Button paySalaryButton;
    }
}
