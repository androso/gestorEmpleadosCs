namespace gestorEmpleados
{
    partial class NewEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newEmployeeTitle = new Label();
            newEmpFullNameLabel = new Label();
            newEmpFullNameTextbox = new TextBox();
            newEmpSeniorityLabel = new Label();
            newEmpSeniorityCombobox = new ComboBox();
            newEmpBirthDateLabel = new Label();
            newEmpBirthDateDateTimePicker = new DateTimePicker();
            newEmpSubmitButton = new Button();
            SuspendLayout();
            // 
            // newEmployeeTitle
            // 
            newEmployeeTitle.AutoSize = true;
            newEmployeeTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            newEmployeeTitle.ForeColor = SystemColors.ControlLight;
            newEmployeeTitle.Location = new Point(111, 41);
            newEmployeeTitle.Name = "newEmployeeTitle";
            newEmployeeTitle.Size = new Size(217, 35);
            newEmployeeTitle.TabIndex = 1;
            newEmployeeTitle.Text = "Nuevo empleado";
            // 
            // newEmpFullNameLabel
            // 
            newEmpFullNameLabel.AutoSize = true;
            newEmpFullNameLabel.ForeColor = Color.Snow;
            newEmpFullNameLabel.Location = new Point(39, 92);
            newEmpFullNameLabel.Name = "newEmpFullNameLabel";
            newEmpFullNameLabel.Size = new Size(134, 20);
            newEmpFullNameLabel.TabIndex = 2;
            newEmpFullNameLabel.Text = "Nombre Completo";
            // 
            // newEmpFullNameTextbox
            // 
            newEmpFullNameTextbox.Location = new Point(39, 115);
            newEmpFullNameTextbox.Name = "newEmpFullNameTextbox";
            newEmpFullNameTextbox.Size = new Size(364, 27);
            newEmpFullNameTextbox.TabIndex = 3;
            // 
            // newEmpSeniorityLabel
            // 
            newEmpSeniorityLabel.AutoSize = true;
            newEmpSeniorityLabel.ForeColor = Color.Snow;
            newEmpSeniorityLabel.Location = new Point(39, 159);
            newEmpSeniorityLabel.Name = "newEmpSeniorityLabel";
            newEmpSeniorityLabel.Size = new Size(144, 20);
            newEmpSeniorityLabel.TabIndex = 5;
            newEmpSeniorityLabel.Text = "Nivel de Experiencia";
            // 
            // newEmpSeniorityCombobox
            // 
            newEmpSeniorityCombobox.FormattingEnabled = true;
            newEmpSeniorityCombobox.Location = new Point(39, 183);
            newEmpSeniorityCombobox.Name = "newEmpSeniorityCombobox";
            newEmpSeniorityCombobox.Size = new Size(151, 28);
            newEmpSeniorityCombobox.TabIndex = 6;
            // 
            // newEmpBirthDateLabel
            // 
            newEmpBirthDateLabel.AutoSize = true;
            newEmpBirthDateLabel.ForeColor = Color.Snow;
            newEmpBirthDateLabel.Location = new Point(220, 159);
            newEmpBirthDateLabel.Name = "newEmpBirthDateLabel";
            newEmpBirthDateLabel.Size = new Size(146, 20);
            newEmpBirthDateLabel.TabIndex = 7;
            newEmpBirthDateLabel.Text = "Fecha de nacimiento";
            // 
            // newEmpBirthDateDateTimePicker
            // 
            newEmpBirthDateDateTimePicker.Location = new Point(220, 184);
            newEmpBirthDateDateTimePicker.Name = "newEmpBirthDateDateTimePicker";
            newEmpBirthDateDateTimePicker.Size = new Size(183, 27);
            newEmpBirthDateDateTimePicker.TabIndex = 8;
            // 
            // newEmpSubmitButton
            // 
            newEmpSubmitButton.Location = new Point(166, 249);
            newEmpSubmitButton.Name = "newEmpSubmitButton";
            newEmpSubmitButton.Size = new Size(94, 29);
            newEmpSubmitButton.TabIndex = 9;
            newEmpSubmitButton.Text = "Submit";
            newEmpSubmitButton.UseVisualStyleBackColor = true;
            // 
            // NewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(444, 339);
            Controls.Add(newEmpSubmitButton);
            Controls.Add(newEmpBirthDateDateTimePicker);
            Controls.Add(newEmpBirthDateLabel);
            Controls.Add(newEmpSeniorityCombobox);
            Controls.Add(newEmpSeniorityLabel);
            Controls.Add(newEmpFullNameTextbox);
            Controls.Add(newEmpFullNameLabel);
            Controls.Add(newEmployeeTitle);
            Name = "NewEmployeeForm";
            Text = "Form1";
            Load += NewEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newEmployeeTitle;
        private Label newEmpFullNameLabel;
        private TextBox newEmpFullNameTextbox;
        private Label newEmpSeniorityLabel;
        private ComboBox newEmpSeniorityCombobox;
        private Label newEmpBirthDateLabel;
        private DateTimePicker newEmpBirthDateDateTimePicker;
        private Button newEmpSubmitButton;
    }
}