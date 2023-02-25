namespace AngelCoello
{
    partial class Formulario3
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
            this.components = new System.ComponentModel.Container();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RefrescarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.PosibleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumerosComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Image = global::AngelCoello.Properties.Resources.calculadora;
            this.CalcularButton.Location = new System.Drawing.Point(375, 42);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(74, 49);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::AngelCoello.Properties.Resources.regreso;
            this.button1.Location = new System.Drawing.Point(375, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.Enabled = false;
            this.RefrescarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefrescarButton.Image = global::AngelCoello.Properties.Resources.actualizar;
            this.RefrescarButton.Location = new System.Drawing.Point(375, 170);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(74, 47);
            this.RefrescarButton.TabIndex = 16;
            this.RefrescarButton.Text = "Refrescar";
            this.RefrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrescarButton.UseVisualStyleBackColor = true;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ingrese su Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese su Apellido: ";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(209, 42);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(153, 20);
            this.NombreTextBox.TabIndex = 19;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(209, 98);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(153, 20);
            this.ApellidoTextBox.TabIndex = 20;
            // 
            // PosibleErrorProvider
            // 
            this.PosibleErrorProvider.ContainerControl = this;
            // 
            // NumerosComboBox
            // 
            this.NumerosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumerosComboBox.FormattingEnabled = true;
            this.NumerosComboBox.Location = new System.Drawing.Point(209, 148);
            this.NumerosComboBox.Name = "NumerosComboBox";
            this.NumerosComboBox.Size = new System.Drawing.Size(153, 21);
            this.NumerosComboBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seleccione un Número";
            // 
            // Formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(461, 285);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumerosComboBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefrescarButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Formulario3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario3";
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button RefrescarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.ErrorProvider PosibleErrorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NumerosComboBox;
    }
}