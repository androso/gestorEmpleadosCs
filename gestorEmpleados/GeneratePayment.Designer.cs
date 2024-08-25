namespace gestorEmpleados
{
    partial class GeneratePayment
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
            components = new System.ComponentModel.Container();
            generatePaymentTitle = new Label();
            generatePaymentQuantityLabel = new Label();
            generatePaymentButton = new Button();
            label1 = new Label();
            generatePaymentFullNameLabel = new Label();
            paymentQuantityTextbox = new TextBox();
            ValidationErrorProvider = new ErrorProvider(components);
            quantityErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ValidationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // generatePaymentTitle
            // 
            generatePaymentTitle.AutoSize = true;
            generatePaymentTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            generatePaymentTitle.ForeColor = SystemColors.ControlLight;
            generatePaymentTitle.Location = new Point(77, 27);
            generatePaymentTitle.Name = "generatePaymentTitle";
            generatePaymentTitle.Size = new Size(173, 35);
            generatePaymentTitle.TabIndex = 2;
            generatePaymentTitle.Text = "Generar Pago";
            // 
            // generatePaymentQuantityLabel
            // 
            generatePaymentQuantityLabel.AutoSize = true;
            generatePaymentQuantityLabel.ForeColor = Color.Snow;
            generatePaymentQuantityLabel.Location = new Point(40, 77);
            generatePaymentQuantityLabel.Name = "generatePaymentQuantityLabel";
            generatePaymentQuantityLabel.Size = new Size(250, 20);
            generatePaymentQuantityLabel.TabIndex = 3;
            generatePaymentQuantityLabel.Text = "Ingrese la cantidad que se enviará a ";
            // 
            // generatePaymentButton
            // 
            generatePaymentButton.Location = new Point(112, 205);
            generatePaymentButton.Name = "generatePaymentButton";
            generatePaymentButton.Size = new Size(94, 29);
            generatePaymentButton.TabIndex = 5;
            generatePaymentButton.Text = "Submit";
            generatePaymentButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 97);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // generatePaymentFullNameLabel
            // 
            generatePaymentFullNameLabel.AutoSize = true;
            generatePaymentFullNameLabel.ForeColor = Color.Snow;
            generatePaymentFullNameLabel.Location = new Point(40, 111);
            generatePaymentFullNameLabel.Name = "generatePaymentFullNameLabel";
            generatePaymentFullNameLabel.Size = new Size(0, 20);
            generatePaymentFullNameLabel.TabIndex = 7;
            // 
            // paymentQuantityTextbox
            // 
            paymentQuantityTextbox.Location = new Point(102, 151);
            paymentQuantityTextbox.Name = "paymentQuantityTextbox";
            paymentQuantityTextbox.Size = new Size(125, 27);
            paymentQuantityTextbox.TabIndex = 8;
            paymentQuantityTextbox.Validating += paymentQuantityTextbox_Validating;
            // 
            // ValidationErrorProvider
            // 
            ValidationErrorProvider.ContainerControl = this;
            // 
            // quantityErrorLabel
            // 
            quantityErrorLabel.AutoSize = true;
            quantityErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quantityErrorLabel.ForeColor = Color.Red;
            quantityErrorLabel.Location = new Point(75, 182);
            quantityErrorLabel.Name = "quantityErrorLabel";
            quantityErrorLabel.Size = new Size(0, 20);
            quantityErrorLabel.TabIndex = 9;
            quantityErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GeneratePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(331, 311);
            Controls.Add(quantityErrorLabel);
            Controls.Add(paymentQuantityTextbox);
            Controls.Add(generatePaymentFullNameLabel);
            Controls.Add(label1);
            Controls.Add(generatePaymentButton);
            Controls.Add(generatePaymentQuantityLabel);
            Controls.Add(generatePaymentTitle);
            Name = "GeneratePayment";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)ValidationErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label generatePaymentTitle;
        private Label generatePaymentQuantityLabel;
        private Button generatePaymentButton;
        private Label label1;
        private Label generatePaymentFullNameLabel;
        private TextBox paymentQuantityTextbox;
        private ErrorProvider ValidationErrorProvider;
        private Label quantityErrorLabel;
    }
}