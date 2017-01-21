namespace EjemploClasesAccesoSQLServer
{
    partial class FrmMain
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
            this.BienvenidoLabel = new System.Windows.Forms.Label();
            this.MostrarPersonasButton = new System.Windows.Forms.Button();
            this.RegistrarPersonaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BienvenidoLabel
            // 
            this.BienvenidoLabel.AutoSize = true;
            this.BienvenidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BienvenidoLabel.Location = new System.Drawing.Point(60, 77);
            this.BienvenidoLabel.Name = "BienvenidoLabel";
            this.BienvenidoLabel.Size = new System.Drawing.Size(167, 31);
            this.BienvenidoLabel.TabIndex = 5;
            this.BienvenidoLabel.Text = "Bienvenido!";
            // 
            // MostrarPersonasButton
            // 
            this.MostrarPersonasButton.Location = new System.Drawing.Point(145, 141);
            this.MostrarPersonasButton.Name = "MostrarPersonasButton";
            this.MostrarPersonasButton.Size = new System.Drawing.Size(117, 42);
            this.MostrarPersonasButton.TabIndex = 4;
            this.MostrarPersonasButton.Text = "Mostrar Personas";
            this.MostrarPersonasButton.UseVisualStyleBackColor = true;
            this.MostrarPersonasButton.Click += new System.EventHandler(this.BuscarPersonaButton_Click);
            // 
            // RegistrarPersonaButton
            // 
            this.RegistrarPersonaButton.Location = new System.Drawing.Point(22, 141);
            this.RegistrarPersonaButton.Name = "RegistrarPersonaButton";
            this.RegistrarPersonaButton.Size = new System.Drawing.Size(117, 42);
            this.RegistrarPersonaButton.TabIndex = 3;
            this.RegistrarPersonaButton.Text = "Registrar Persona";
            this.RegistrarPersonaButton.UseVisualStyleBackColor = true;
            this.RegistrarPersonaButton.Click += new System.EventHandler(this.RegistrarPersonaButton_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BienvenidoLabel);
            this.Controls.Add(this.MostrarPersonasButton);
            this.Controls.Add(this.RegistrarPersonaButton);
            this.Name = "FrmMain";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidoLabel;
        private System.Windows.Forms.Button MostrarPersonasButton;
        private System.Windows.Forms.Button RegistrarPersonaButton;
    }
}