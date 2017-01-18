namespace WFAProyecto_King_of_Maths
{
    partial class Niveles_Opera_Logicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Niveles_Opera_Logicos));
            this.TbcOL = new System.Windows.Forms.TabControl();
            this.tbPN1OL = new System.Windows.Forms.TabPage();
            this.picestreOLN1 = new System.Windows.Forms.PictureBox();
            this.cmdiniciarN1 = new System.Windows.Forms.Button();
            this.lbloperacionN1OL = new System.Windows.Forms.Label();
            this.lbltiempoN1OL = new System.Windows.Forms.Label();
            this.lblconteoN1OL = new System.Windows.Forms.Label();
            this.lblpunteoN1OL = new System.Windows.Forms.Label();
            this.cmdFalso = new System.Windows.Forms.Button();
            this.cmdVerdadero = new System.Windows.Forms.Button();
            this.tbPN2OL = new System.Windows.Forms.TabPage();
            this.cmdinicioN2OL = new System.Windows.Forms.Button();
            this.tbPN3OL = new System.Windows.Forms.TabPage();
            this.tbPN4OL = new System.Windows.Forms.TabPage();
            this.tbPN5OL = new System.Windows.Forms.TabPage();
            this.timerN1OPL = new System.Windows.Forms.Timer(this.components);
            this.imLOL1 = new System.Windows.Forms.ImageList(this.components);
            this.TbcOL.SuspendLayout();
            this.tbPN1OL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picestreOLN1)).BeginInit();
            this.tbPN2OL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcOL
            // 
            this.TbcOL.Controls.Add(this.tbPN1OL);
            this.TbcOL.Controls.Add(this.tbPN2OL);
            this.TbcOL.Controls.Add(this.tbPN3OL);
            this.TbcOL.Controls.Add(this.tbPN4OL);
            this.TbcOL.Controls.Add(this.tbPN5OL);
            this.TbcOL.Location = new System.Drawing.Point(5, 5);
            this.TbcOL.Name = "TbcOL";
            this.TbcOL.SelectedIndex = 0;
            this.TbcOL.Size = new System.Drawing.Size(396, 337);
            this.TbcOL.TabIndex = 0;
            // 
            // tbPN1OL
            // 
            this.tbPN1OL.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbPN1OL.Controls.Add(this.picestreOLN1);
            this.tbPN1OL.Controls.Add(this.cmdiniciarN1);
            this.tbPN1OL.Controls.Add(this.lbloperacionN1OL);
            this.tbPN1OL.Controls.Add(this.lbltiempoN1OL);
            this.tbPN1OL.Controls.Add(this.lblconteoN1OL);
            this.tbPN1OL.Controls.Add(this.lblpunteoN1OL);
            this.tbPN1OL.Controls.Add(this.cmdFalso);
            this.tbPN1OL.Controls.Add(this.cmdVerdadero);
            this.tbPN1OL.Location = new System.Drawing.Point(4, 22);
            this.tbPN1OL.Name = "tbPN1OL";
            this.tbPN1OL.Padding = new System.Windows.Forms.Padding(3);
            this.tbPN1OL.Size = new System.Drawing.Size(388, 311);
            this.tbPN1OL.TabIndex = 0;
            this.tbPN1OL.Text = "Nivel 1";
            this.tbPN1OL.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // picestreOLN1
            // 
            this.picestreOLN1.Location = new System.Drawing.Point(44, 129);
            this.picestreOLN1.Name = "picestreOLN1";
            this.picestreOLN1.Size = new System.Drawing.Size(200, 34);
            this.picestreOLN1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picestreOLN1.TabIndex = 7;
            this.picestreOLN1.TabStop = false;
            // 
            // cmdiniciarN1
            // 
            this.cmdiniciarN1.Location = new System.Drawing.Point(298, 162);
            this.cmdiniciarN1.Name = "cmdiniciarN1";
            this.cmdiniciarN1.Size = new System.Drawing.Size(75, 23);
            this.cmdiniciarN1.TabIndex = 6;
            this.cmdiniciarN1.Text = "Iniciar";
            this.cmdiniciarN1.UseVisualStyleBackColor = true;
            this.cmdiniciarN1.Click += new System.EventHandler(this.cmdiniciarN1_Click_1);
            // 
            // lbloperacionN1OL
            // 
            this.lbloperacionN1OL.AutoSize = true;
            this.lbloperacionN1OL.Location = new System.Drawing.Point(138, 199);
            this.lbloperacionN1OL.Name = "lbloperacionN1OL";
            this.lbloperacionN1OL.Size = new System.Drawing.Size(10, 13);
            this.lbloperacionN1OL.TabIndex = 5;
            this.lbloperacionN1OL.Text = ".";
            // 
            // lbltiempoN1OL
            // 
            this.lbltiempoN1OL.AutoSize = true;
            this.lbltiempoN1OL.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempoN1OL.Location = new System.Drawing.Point(321, 80);
            this.lbltiempoN1OL.Name = "lbltiempoN1OL";
            this.lbltiempoN1OL.Size = new System.Drawing.Size(14, 21);
            this.lbltiempoN1OL.TabIndex = 4;
            this.lbltiempoN1OL.Text = ".";
            // 
            // lblconteoN1OL
            // 
            this.lblconteoN1OL.AutoSize = true;
            this.lblconteoN1OL.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconteoN1OL.Location = new System.Drawing.Point(321, 35);
            this.lblconteoN1OL.Name = "lblconteoN1OL";
            this.lblconteoN1OL.Size = new System.Drawing.Size(14, 21);
            this.lblconteoN1OL.TabIndex = 3;
            this.lblconteoN1OL.Text = ".";
            // 
            // lblpunteoN1OL
            // 
            this.lblpunteoN1OL.AutoSize = true;
            this.lblpunteoN1OL.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpunteoN1OL.Location = new System.Drawing.Point(44, 35);
            this.lblpunteoN1OL.Name = "lblpunteoN1OL";
            this.lblpunteoN1OL.Size = new System.Drawing.Size(14, 21);
            this.lblpunteoN1OL.TabIndex = 2;
            this.lblpunteoN1OL.Text = ".";
            // 
            // cmdFalso
            // 
            this.cmdFalso.Enabled = false;
            this.cmdFalso.Location = new System.Drawing.Point(162, 246);
            this.cmdFalso.Name = "cmdFalso";
            this.cmdFalso.Size = new System.Drawing.Size(124, 34);
            this.cmdFalso.TabIndex = 1;
            this.cmdFalso.Text = "Falso";
            this.cmdFalso.UseVisualStyleBackColor = true;
            this.cmdFalso.Click += new System.EventHandler(this.cmdFalso_Click);
            // 
            // cmdVerdadero
            // 
            this.cmdVerdadero.Enabled = false;
            this.cmdVerdadero.Location = new System.Drawing.Point(21, 246);
            this.cmdVerdadero.Name = "cmdVerdadero";
            this.cmdVerdadero.Size = new System.Drawing.Size(113, 34);
            this.cmdVerdadero.TabIndex = 0;
            this.cmdVerdadero.Text = "Verdadero";
            this.cmdVerdadero.UseVisualStyleBackColor = true;
            this.cmdVerdadero.Click += new System.EventHandler(this.cmdVerdadero_Click);
            // 
            // tbPN2OL
            // 
            this.tbPN2OL.Controls.Add(this.cmdinicioN2OL);
            this.tbPN2OL.Location = new System.Drawing.Point(4, 22);
            this.tbPN2OL.Name = "tbPN2OL";
            this.tbPN2OL.Padding = new System.Windows.Forms.Padding(3);
            this.tbPN2OL.Size = new System.Drawing.Size(388, 311);
            this.tbPN2OL.TabIndex = 1;
            this.tbPN2OL.Text = "Nivel 2";
            this.tbPN2OL.UseVisualStyleBackColor = true;
            // 
            // cmdinicioN2OL
            // 
            this.cmdinicioN2OL.Enabled = false;
            this.cmdinicioN2OL.Location = new System.Drawing.Point(305, 254);
            this.cmdinicioN2OL.Name = "cmdinicioN2OL";
            this.cmdinicioN2OL.Size = new System.Drawing.Size(75, 23);
            this.cmdinicioN2OL.TabIndex = 0;
            this.cmdinicioN2OL.Text = "Iniciar";
            this.cmdinicioN2OL.UseVisualStyleBackColor = true;
            // 
            // tbPN3OL
            // 
            this.tbPN3OL.Location = new System.Drawing.Point(4, 22);
            this.tbPN3OL.Name = "tbPN3OL";
            this.tbPN3OL.Padding = new System.Windows.Forms.Padding(3);
            this.tbPN3OL.Size = new System.Drawing.Size(388, 311);
            this.tbPN3OL.TabIndex = 2;
            this.tbPN3OL.Text = "Nivel 3";
            this.tbPN3OL.UseVisualStyleBackColor = true;
            // 
            // tbPN4OL
            // 
            this.tbPN4OL.Location = new System.Drawing.Point(4, 22);
            this.tbPN4OL.Name = "tbPN4OL";
            this.tbPN4OL.Padding = new System.Windows.Forms.Padding(3);
            this.tbPN4OL.Size = new System.Drawing.Size(388, 311);
            this.tbPN4OL.TabIndex = 3;
            this.tbPN4OL.Text = "Nivel 4";
            this.tbPN4OL.UseVisualStyleBackColor = true;
            // 
            // tbPN5OL
            // 
            this.tbPN5OL.Location = new System.Drawing.Point(4, 22);
            this.tbPN5OL.Name = "tbPN5OL";
            this.tbPN5OL.Padding = new System.Windows.Forms.Padding(3);
            this.tbPN5OL.Size = new System.Drawing.Size(388, 311);
            this.tbPN5OL.TabIndex = 4;
            this.tbPN5OL.Text = "Nivel 5";
            this.tbPN5OL.UseVisualStyleBackColor = true;
            // 
            // timerN1OPL
            // 
            this.timerN1OPL.Interval = 1000;
            this.timerN1OPL.Tick += new System.EventHandler(this.timerN1OPL_Tick_1);
            // 
            // imLOL1
            // 
            this.imLOL1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imLOL1.ImageStream")));
            this.imLOL1.TransparentColor = System.Drawing.Color.Transparent;
            this.imLOL1.Images.SetKeyName(0, "0estrellas.png");
            this.imLOL1.Images.SetKeyName(1, "1estrellasSin título.png");
            this.imLOL1.Images.SetKeyName(2, "2estrellasSin título.png");
            this.imLOL1.Images.SetKeyName(3, "3estrellasSin título.png");
            // 
            // Niveles_Opera_Logicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 345);
            this.Controls.Add(this.TbcOL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Niveles_Opera_Logicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Niveles_Opera_Logicos";
            this.TbcOL.ResumeLayout(false);
            this.tbPN1OL.ResumeLayout(false);
            this.tbPN1OL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picestreOLN1)).EndInit();
            this.tbPN2OL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcOL;
        private System.Windows.Forms.TabPage tbPN1OL;
        private System.Windows.Forms.TabPage tbPN2OL;
        private System.Windows.Forms.TabPage tbPN3OL;
        private System.Windows.Forms.TabPage tbPN4OL;
        private System.Windows.Forms.TabPage tbPN5OL;
        private System.Windows.Forms.Label lbloperacionN1OL;
        private System.Windows.Forms.Label lbltiempoN1OL;
        private System.Windows.Forms.Label lblconteoN1OL;
        private System.Windows.Forms.Label lblpunteoN1OL;
        private System.Windows.Forms.Button cmdFalso;
        private System.Windows.Forms.Button cmdVerdadero;
        private System.Windows.Forms.Button cmdiniciarN1;
        private System.Windows.Forms.Timer timerN1OPL;
        private System.Windows.Forms.Button cmdinicioN2OL;
        private System.Windows.Forms.PictureBox picestreOLN1;
        private System.Windows.Forms.ImageList imLOL1;
    }
}