namespace IpsLiquidacionesGUI
{
    partial class PrincipalGUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.registrarLiquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLiquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLiquidacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLiquidacionesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(867, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // registrarLiquidacionesToolStripMenuItem
            // 
            this.registrarLiquidacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLiquidacionToolStripMenuItem,
            this.consultarLiquidacionToolStripMenuItem});
            this.registrarLiquidacionesToolStripMenuItem.Name = "registrarLiquidacionesToolStripMenuItem";
            this.registrarLiquidacionesToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.registrarLiquidacionesToolStripMenuItem.Text = "Menu Liquidaciones Moderadoras";
            // 
            // registrarLiquidacionToolStripMenuItem
            // 
            this.registrarLiquidacionToolStripMenuItem.Name = "registrarLiquidacionToolStripMenuItem";
            this.registrarLiquidacionToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.registrarLiquidacionToolStripMenuItem.Text = "Registrar Liquidacion";
            this.registrarLiquidacionToolStripMenuItem.Click += new System.EventHandler(this.registrarLiquidacionToolStripMenuItem_Click);
            // 
            // consultarLiquidacionToolStripMenuItem
            // 
            this.consultarLiquidacionToolStripMenuItem.Name = "consultarLiquidacionToolStripMenuItem";
            this.consultarLiquidacionToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultarLiquidacionToolStripMenuItem.Text = "Consultar Liquidacion";
            this.consultarLiquidacionToolStripMenuItem.Click += new System.EventHandler(this.consultarLiquidacionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IpsLiquidacionesGUI.Properties.Resources.hospital_health_clinic_urban_buildings_medical_icon_1285751;
            this.pictureBox1.Location = new System.Drawing.Point(97, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(504, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 501);
            this.panel1.TabIndex = 3;
            // 
            // PrincipalGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalGUI";
            this.Text = "Liquidaciones IPS  SALUDVIDA";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem registrarLiquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLiquidacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLiquidacionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

