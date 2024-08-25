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
            generatePaymentTitle = new Label();
            generatePaymentQuantityLabel = new Label();
            generatePaymentQuantityTextbox = new TextBox();
            generatePaymentButton = new Button();
            SuspendLayout();
            // 
            // generatePaymentTitle
            // 
            generatePaymentTitle.AutoSize = true;
            generatePaymentTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            generatePaymentTitle.ForeColor = SystemColors.ControlLight;
            generatePaymentTitle.Location = new Point(51, 30);
            generatePaymentTitle.Name = "generatePaymentTitle";
            generatePaymentTitle.Size = new Size(173, 35);
            generatePaymentTitle.TabIndex = 2;
            generatePaymentTitle.Text = "Generar Pago";
            // 
            // generatePaymentQuantityLabel
            // 
            generatePaymentQuantityLabel.AutoSize = true;
            generatePaymentQuantityLabel.ForeColor = Color.Snow;
            generatePaymentQuantityLabel.Location = new Point(67, 86);
            generatePaymentQuantityLabel.Name = "generatePaymentQuantityLabel";
            generatePaymentQuantityLabel.Size = new Size(135, 20);
            generatePaymentQuantityLabel.TabIndex = 3;
            generatePaymentQuantityLabel.Text = "Ingrese la cantidad";
            // 
            // generatePaymentQuantityTextbox
            // 
            generatePaymentQuantityTextbox.Location = new Point(77, 121);
            generatePaymentQuantityTextbox.Name = "generatePaymentQuantityTextbox";
            generatePaymentQuantityTextbox.Size = new Size(125, 27);
            generatePaymentQuantityTextbox.TabIndex = 4;
            // 
            // generatePaymentButton
            // 
            generatePaymentButton.Location = new Point(89, 169);
            generatePaymentButton.Name = "generatePaymentButton";
            generatePaymentButton.Size = new Size(94, 29);
            generatePaymentButton.TabIndex = 5;
            generatePaymentButton.Text = "Submit";
            generatePaymentButton.UseVisualStyleBackColor = true;
            // 
            // GeneratePayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(282, 311);
            Controls.Add(generatePaymentButton);
            Controls.Add(generatePaymentQuantityTextbox);
            Controls.Add(generatePaymentQuantityLabel);
            Controls.Add(generatePaymentTitle);
            Name = "GeneratePayment";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label generatePaymentTitle;
        private Label generatePaymentQuantityLabel;
        private TextBox generatePaymentQuantityTextbox;
        private Button generatePaymentButton;
    }
}