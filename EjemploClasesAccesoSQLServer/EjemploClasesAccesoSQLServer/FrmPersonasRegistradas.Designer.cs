namespace EjemploClasesAccesoSQLServer
{
    partial class FrmPersonasRegistradas
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
            this.BuscarPersonaLabel = new System.Windows.Forms.Label();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarPersonaLabel
            // 
            this.BuscarPersonaLabel.AutoSize = true;
            this.BuscarPersonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPersonaLabel.Location = new System.Drawing.Point(151, 9);
            this.BuscarPersonaLabel.Name = "BuscarPersonaLabel";
            this.BuscarPersonaLabel.Size = new System.Drawing.Size(270, 29);
            this.BuscarPersonaLabel.TabIndex = 19;
            this.BuscarPersonaLabel.Text = "Personas Registradas";
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Location = new System.Drawing.Point(156, 233);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(75, 23);
            this.ActualizarButton.TabIndex = 30;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(346, 233);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 31;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Location = new System.Drawing.Point(12, 57);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.Size = new System.Drawing.Size(544, 150);
            this.DatosDataGridView.TabIndex = 32;
            this.DatosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmMostrarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 268);
            this.Controls.Add(this.DatosDataGridView);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.BuscarPersonaLabel);
            this.Name = "FrmMostrarPersonas";
            this.Text = "Personas Registradas";
            this.Load += new System.EventHandler(this.FrmBuscarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BuscarPersonaLabel;
        private System.Windows.Forms.Button ActualizarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
    }
}