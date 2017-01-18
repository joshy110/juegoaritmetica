namespace WFAProyecto_King_of_Maths
{
    partial class Estadisticas_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas_Usuario));
            this.lblestadistica = new System.Windows.Forms.Label();
            this.cmdRMEM = new System.Windows.Forms.Button();
            this.lblNJuEstadi = new System.Windows.Forms.Label();
            this.lblEstadisticaU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblestadistica
            // 
            this.lblestadistica.AutoSize = true;
            this.lblestadistica.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadistica.Location = new System.Drawing.Point(264, 9);
            this.lblestadistica.Name = "lblestadistica";
            this.lblestadistica.Size = new System.Drawing.Size(244, 26);
            this.lblestadistica.TabIndex = 1;
            this.lblestadistica.Text = "Su estaísticas es la siguiente ";
            // 
            // cmdRMEM
            // 
            this.cmdRMEM.Location = new System.Drawing.Point(386, 179);
            this.cmdRMEM.Name = "cmdRMEM";
            this.cmdRMEM.Size = new System.Drawing.Size(110, 47);
            this.cmdRMEM.TabIndex = 2;
            this.cmdRMEM.Text = "Regresar al menu de mundos ";
            this.cmdRMEM.UseVisualStyleBackColor = true;
            this.cmdRMEM.Click += new System.EventHandler(this.cmdRMEM_Click);
            // 
            // lblNJuEstadi
            // 
            this.lblNJuEstadi.AutoSize = true;
            this.lblNJuEstadi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNJuEstadi.Location = new System.Drawing.Point(12, 9);
            this.lblNJuEstadi.Name = "lblNJuEstadi";
            this.lblNJuEstadi.Size = new System.Drawing.Size(17, 25);
            this.lblNJuEstadi.TabIndex = 3;
            this.lblNJuEstadi.Text = ".";
            // 
            // lblEstadisticaU
            // 
            this.lblEstadisticaU.AutoSize = true;
            this.lblEstadisticaU.Location = new System.Drawing.Point(14, 84);
            this.lblEstadisticaU.Name = "lblEstadisticaU";
            this.lblEstadisticaU.Size = new System.Drawing.Size(10, 13);
            this.lblEstadisticaU.TabIndex = 4;
            this.lblEstadisticaU.Text = ".";
            // 
            // Estadisticas_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.Controls.Add(this.lblEstadisticaU);
            this.Controls.Add(this.lblNJuEstadi);
            this.Controls.Add(this.cmdRMEM);
            this.Controls.Add(this.lblestadistica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadisticas_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas_Usuario";
            this.Activated += new System.EventHandler(this.Estadisticas_Usuario_Activated);
            this.Load += new System.EventHandler(this.Estadisticas_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblestadistica;
        private System.Windows.Forms.Button cmdRMEM;
        public System.Windows.Forms.Label lblNJuEstadi;
        public System.Windows.Forms.Label lblEstadisticaU;
    }
}