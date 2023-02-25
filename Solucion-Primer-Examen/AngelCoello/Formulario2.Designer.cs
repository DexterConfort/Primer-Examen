namespace AngelCoello
{
    partial class Formulario2
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
            this.FacturarButton = new System.Windows.Forms.Button();
            this.RegresarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Descripcion1TextBox = new System.Windows.Forms.TextBox();
            this.Precio1TextBox = new System.Windows.Forms.TextBox();
            this.Descripcion2TextBox = new System.Windows.Forms.TextBox();
            this.Precio2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Precio3TextBox = new System.Windows.Forms.TextBox();
            this.Descripcion3TextBox = new System.Windows.Forms.TextBox();
            this.RefrescarButton = new System.Windows.Forms.Button();
            this.PosibleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DescuentoLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotaFacturaLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturarButton
            // 
            this.FacturarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturarButton.Image = global::AngelCoello.Properties.Resources.pago_en_linea;
            this.FacturarButton.Location = new System.Drawing.Point(463, 52);
            this.FacturarButton.Name = "FacturarButton";
            this.FacturarButton.Size = new System.Drawing.Size(74, 49);
            this.FacturarButton.TabIndex = 2;
            this.FacturarButton.Text = "Facturar";
            this.FacturarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FacturarButton.UseVisualStyleBackColor = true;
            this.FacturarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegresarButton
            // 
            this.RegresarButton.Image = global::AngelCoello.Properties.Resources.regreso;
            this.RegresarButton.Location = new System.Drawing.Point(463, 221);
            this.RegresarButton.Name = "RegresarButton";
            this.RegresarButton.Size = new System.Drawing.Size(74, 46);
            this.RegresarButton.TabIndex = 1;
            this.RegresarButton.Text = "Regresar";
            this.RegresarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RegresarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RegresarButton.UseVisualStyleBackColor = true;
            this.RegresarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio: ";
            // 
            // Descripcion1TextBox
            // 
            this.Descripcion1TextBox.Location = new System.Drawing.Point(81, 52);
            this.Descripcion1TextBox.Name = "Descripcion1TextBox";
            this.Descripcion1TextBox.Size = new System.Drawing.Size(227, 20);
            this.Descripcion1TextBox.TabIndex = 5;
            // 
            // Precio1TextBox
            // 
            this.Precio1TextBox.Location = new System.Drawing.Point(340, 52);
            this.Precio1TextBox.Name = "Precio1TextBox";
            this.Precio1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Precio1TextBox.TabIndex = 6;
            // 
            // Descripcion2TextBox
            // 
            this.Descripcion2TextBox.Location = new System.Drawing.Point(81, 93);
            this.Descripcion2TextBox.Name = "Descripcion2TextBox";
            this.Descripcion2TextBox.Size = new System.Drawing.Size(227, 20);
            this.Descripcion2TextBox.TabIndex = 7;
            // 
            // Precio2TextBox
            // 
            this.Precio2TextBox.Location = new System.Drawing.Point(340, 93);
            this.Precio2TextBox.Name = "Precio2TextBox";
            this.Precio2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Precio2TextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "3";
            // 
            // Precio3TextBox
            // 
            this.Precio3TextBox.Location = new System.Drawing.Point(340, 128);
            this.Precio3TextBox.Name = "Precio3TextBox";
            this.Precio3TextBox.Size = new System.Drawing.Size(100, 20);
            this.Precio3TextBox.TabIndex = 14;
            // 
            // Descripcion3TextBox
            // 
            this.Descripcion3TextBox.Location = new System.Drawing.Point(81, 128);
            this.Descripcion3TextBox.Name = "Descripcion3TextBox";
            this.Descripcion3TextBox.Size = new System.Drawing.Size(227, 20);
            this.Descripcion3TextBox.TabIndex = 13;
            // 
            // RefrescarButton
            // 
            this.RefrescarButton.Enabled = false;
            this.RefrescarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefrescarButton.Image = global::AngelCoello.Properties.Resources.actualizar;
            this.RefrescarButton.Location = new System.Drawing.Point(463, 169);
            this.RefrescarButton.Name = "RefrescarButton";
            this.RefrescarButton.Size = new System.Drawing.Size(74, 46);
            this.RefrescarButton.TabIndex = 15;
            this.RefrescarButton.Text = "Refrescar";
            this.RefrescarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrescarButton.UseVisualStyleBackColor = true;
            this.RefrescarButton.Click += new System.EventHandler(this.RefrescarButton_Click);
            // 
            // PosibleErrorProvider
            // 
            this.PosibleErrorProvider.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descuento del 15%:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total a pagar: ";
            // 
            // DescuentoLabel
            // 
            this.DescuentoLabel.AutoSize = true;
            this.DescuentoLabel.Location = new System.Drawing.Point(212, 215);
            this.DescuentoLabel.Name = "DescuentoLabel";
            this.DescuentoLabel.Size = new System.Drawing.Size(0, 13);
            this.DescuentoLabel.TabIndex = 18;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(212, 243);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalLabel.TabIndex = 19;
            // 
            // TotaFacturaLabel
            // 
            this.TotaFacturaLabel.AutoSize = true;
            this.TotaFacturaLabel.Location = new System.Drawing.Point(212, 190);
            this.TotaFacturaLabel.Name = "TotaFacturaLabel";
            this.TotaFacturaLabel.Size = new System.Drawing.Size(0, 13);
            this.TotaFacturaLabel.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total de la Factura: ";
            // 
            // Formulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.RegresarButton;
            this.ClientSize = new System.Drawing.Size(548, 278);
            this.ControlBox = false;
            this.Controls.Add(this.TotaFacturaLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DescuentoLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RefrescarButton);
            this.Controls.Add(this.Precio3TextBox);
            this.Controls.Add(this.Descripcion3TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Precio2TextBox);
            this.Controls.Add(this.Descripcion2TextBox);
            this.Controls.Add(this.Precio1TextBox);
            this.Controls.Add(this.Descripcion1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacturarButton);
            this.Controls.Add(this.RegresarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Formulario2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario2";
            ((System.ComponentModel.ISupportInitialize)(this.PosibleErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegresarButton;
        private System.Windows.Forms.Button FacturarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descripcion1TextBox;
        private System.Windows.Forms.TextBox Precio1TextBox;
        private System.Windows.Forms.TextBox Descripcion2TextBox;
        private System.Windows.Forms.TextBox Precio2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Precio3TextBox;
        private System.Windows.Forms.TextBox Descripcion3TextBox;
        private System.Windows.Forms.Button RefrescarButton;
        private System.Windows.Forms.ErrorProvider PosibleErrorProvider;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label DescuentoLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotaFacturaLabel;
        private System.Windows.Forms.Label label10;
    }
}