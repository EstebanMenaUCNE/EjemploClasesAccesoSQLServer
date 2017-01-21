namespace EjemploClasesAccesoSQLServer
{
    partial class FrmRegistrarPersona
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
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.TelefonoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(59, 98);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 0;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(117, 95);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 1;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(117, 121);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ApellidoTextBox.TabIndex = 3;
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Location = new System.Drawing.Point(59, 124);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(44, 13);
            this.ApellidoLabel.TabIndex = 2;
            this.ApellidoLabel.Text = "Apellido";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(117, 147);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DireccionTextBox.TabIndex = 5;
            this.DireccionTextBox.TextChanged += new System.EventHandler(this.DireccionTextBox_TextChanged);
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Location = new System.Drawing.Point(59, 150);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(52, 13);
            this.DireccionLabel.TabIndex = 4;
            this.DireccionLabel.Text = "Direccion";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Location = new System.Drawing.Point(59, 176);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLabel.TabIndex = 6;
            this.TelefonoLabel.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registrar Persona";
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(50, 209);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarButton.TabIndex = 9;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(117, 69);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 12;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(59, 72);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 11;
            this.IdLabel.Text = "ID";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(152, 209);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 10;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(117, 173);
            this.TelefonoTextBox.Mask = "(999)-999-9999";
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonoTextBox.TabIndex = 13;
            this.TelefonoTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // FrmRegistrarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Name = "FrmRegistrarPersona";
            this.Text = "Registrar Persona";
            this.Load += new System.EventHandler(this.FrmRegistrarPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.MaskedTextBox TelefonoTextBox;
    }
}